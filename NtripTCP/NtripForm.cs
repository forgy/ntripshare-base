// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports

using Microsoft.VisualBasic.CompilerServices;
using System.Net.Sockets;
using System.Threading;
using System.Text;

using SharpGPS.NTRIP;
using System.Net;
using SharpGPS.NMEA;
using System.IO;
using NTRIPClient;
using NtripShare.NTRIP;

namespace NtripClient
{
    public partial class NtripForm
    {
        public NtripForm()
        {
            // VBConversions Note: Non-static class variable initialization is below.  Class variables cannot be initially assigned non-static values in C#.
            settingsfile = Application.StartupPath + "\\Settings.txt";

            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static NtripForm defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static NtripForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new NtripForm();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
            set
            {
                defaultInstance = value;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        #endregion
        //Send comments to Lance@Lefebure.com

        private int TimerTickCount = 0;
        string settingsfile; // VBConversions Note: Initial value cannot be assigned here since it is non-static.  Assignment has been moved to the class constructors.

        public bool WriteEventsToFile = false;
        //System.Net.IPAddress ip = System.Net.IPAddress.Any;
        //public int TCPSercverPort = 3000;

        //private TcpListener listener;
        //public static string NTRIPMountPoint = "RTCM32";
        private int NtripByteCount = 0;
        private SourceTable sourceTable;
        //private SharpGPS.NTRIP.NTRIPClient client;
        NClient client;
        private string NtripMountPoint;
        private int rinexHourTick =0;
        private int rinexDaytick = 0;

        public void MainForm_Load(System.Object sender, System.EventArgs e)
        {
            lbl2.Text = "";
            lbl3.Text = "";
            string ver = "欢迎使用NTRIP SHARE,当前版本: " + System.Convert.ToString(Application.ProductVersion);
            if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Revision != 0)
            {
                ver += " (Rev " + System.Convert.ToString((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Revision) + ")";
            }
            rtbEvents.Text = ver;
            //LoadSettingsFile();
            readConfig();

            CasterForm.Default.Show();
            dgvMountPoints.DataSource = CasterForm.Default.dtmountpoints;
            dgvUsers.DataSource = CasterForm.Default.dtusers;
            CasterForm.Default.Hide();

            //txServerPort.Text = TCPSercverPort.ToString();
            Timer1.Start();

            tbRtcmHourSavePath.Text = Application.StartupPath;
            tbRtcmDaySavePath.Text = Application.StartupPath;
            tbRinexHourSavePath.Text = Application.StartupPath;
            tbRinexDaySavePath.Text = Application.StartupPath;
        }

        public void MainForm_LocationChanged(System.Object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
            }
        }
        public void MainForm_ResizeEnd(System.Object sender, System.EventArgs e)
        {

        }
        public void MainForm_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
        {

            //CloseDialog dialog = CloseDialog.Default;
            //int result = (int)(dialog.ShowDialog());
            //if (result == 1)
            //{
            //    string password = dialog.tbPassword.Text;
            //    if (password != "admin")
            //    {
            //        MessageBox.Show("密码错误！");
            //        e.Cancel = true;
            //        return;
            //    }
          
            //    //Clean out recording queue
            //    CasterForm.Default.Close();
            //}
            //else {
            //    e.Cancel = true;
            //    return;
            //}
            //CloseDialog dialog = CloseDialog.Default;
            //int result = (int)(dialog.ShowDialog());
            //if (result == 1)
            //{
            //    string password = dialog.tbPassword.Text;
            //    if (password != "admin")
            //    {
            //        MessageBox.Show("密码错误！");
            //        return;
            //    }
            //}
            //else
            //{
            //    return;
            //}
            Timer1.Stop();
            timer2.Stop();

            if (!CasterForm.Default.stopFlag)
            {
                CasterForm.Default.StopServer();
                client.StopNTRIP();
                btStartServer.Text = "启动";
                lbCorsStatus.Text = "未连接";
                lbNtripStatus.Text = "未连接";
            }
        }


        private void LoadSettingsFile()
        {
            //Check to make sure directory exists, if not, throw a WTF message.
            if (!(new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DirectoryExists(Application.StartupPath))
            {
                MessageBox.Show("Error: The Application\'s folder doesn\'t exist. Settings file not loaded.");
                return;
            }

            if (!(new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.FileExists(settingsfile)) //File doesn't exist. Create it.
            {
                System.IO.StreamWriter fn = new System.IO.StreamWriter(System.IO.File.Open(settingsfile, System.IO.FileMode.Create));
                fn.WriteLine("# This is the GG GPS Data Path Pointer file. You need to use the format \"Key=Value\" for all settings.");
                fn.WriteLine("# Any line that starts with a # symbol will be ignored.");
                fn.WriteLine("# The only setting in this file should be the Data Path Location.");
                fn.WriteLine("");
                fn.Close();
            }

            //Open and read file
            string[,] SettingsArray = new string[2, 1];
            string[] keyvalpair = new string[2];
            string key = "";
            string value = "";
            int lCtr = 0;

            try
            {
                System.IO.StreamReader oRead = System.IO.File.OpenText(settingsfile);
                string linein = null;

                while (oRead.Peek() != -1)
                {
                    linein = oRead.ReadLine().Trim();
                    if (Strings.Len(linein) < 3)
                    {
                        //Line is too short
                    }
                    else if (Strings.Asc(linein[0]) == 35)
                    {
                        //Line starts with a #
                    }
                    else if (linein.ToString().IndexOf("=") + 1 < 2)
                    {
                        //There is no equal sign in the string
                    }
                    else
                    {
                        keyvalpair = Strings.Split(System.Convert.ToString(linein), "=", 2);
                        key = keyvalpair[0].Trim();
                        value = keyvalpair[1].Trim();
                        if (key.Length > 0 && value.Length > 0)
                        {
                            //Looks good, add it to the array
                            SettingsArray = (string[,])Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array)SettingsArray, new string[2, lCtr + 1]);
                            SettingsArray[0, lCtr] = key.ToLower();
                            SettingsArray[1, lCtr] = value;
                            lCtr++;
                        }
                    }
                }
                oRead.Close();
            }
            catch (Exception e)
            {
            }

        }

        public void SaveNTRIPSettings()
        {
            Settings.Default.Save();
        }

        public void LogEvent(string Message)
        {
            if (rtbEvents.TextLength > 5000)
            {
                string NewText = rtbEvents.Text.Substring(999); //Drop first 1000 characters
                NewText = NewText.Remove(0, System.Convert.ToInt32(NewText.IndexOf(Strings.ChrW(10)) + 1)); //Drop up to the next new line
                rtbEvents.Text = NewText;
            }

            rtbEvents.AppendText("\r\n" + System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " - " + Message);
            rtbEvents.SelectionStart = rtbEvents.TextLength;
            rtbEvents.ScrollToCaret();

            if (WriteEventsToFile)
            {
                string logfolder = Application.StartupPath + "\\Logs";

                if (!(new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DirectoryExists(logfolder))
                {
                    try
                    {
                        (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.CreateDirectory(logfolder);
                    }
                    catch (Exception)
                    {
                    }
                }

                string logfile = logfolder + "\\" + System.Convert.ToString(DateAndTime.Year(DateTime.Now)) + Strings.Format(DateAndTime.Month(DateTime.Now), "00") + Strings.Format(DateAndTime.DatePart(DateInterval.Day, DateTime.Now), "00") + ".txt";

                for (var i = 0; i <= 10; i++)
                {
                    try
                    {
                        (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.WriteAllText(logfile, DateTime.Now + " - " + Message + "\r\n", true);
                        goto endOfForLoop; //This worked, don't try it again
                        System.Threading.Thread.Sleep(20);
                        Application.DoEvents();
                    }
                    catch (Exception)
                    {
                    }
                }
            endOfForLoop:
                1.GetHashCode();
            }
        }



        public void SendStuffToUIThread(int Action, string Message)
        {
            try
            {
                SendStuffToUIThreadDelegate uidel = new SendStuffToUIThreadDelegate(ProcessOnUIThread);
                object[] o = new object[2];
                o[0] = Action;
                o[1] = Message;
                Invoke(uidel, o);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        delegate void SendStuffToUIThreadDelegate(int Action, string Message);
        public void ProcessOnUIThread(int Action, string Message)
        {
            switch (Action)
            {
                case 0: //On start up, list IP and port
                    LogEvent(Message);
                    //lblTCPStatus.Text = Message;
                    break;
                case 99: //On start up, list IP and port
                    LogEvent(Message);
                    CasterForm.Default.StopServer();
                    btStartServer.Text = "启动";
                    //lblTCPStatus.Text = Message;
                    break;
            }
        }

        public void NtripUpdateUIThread(int Item, byte[] myBytes)
        {
            try
            {
                NtripUpdateUIThreadDelegate uidel = new NtripUpdateUIThreadDelegate(NtripCallBacktoUIThread);
                object[] o = new object[2];
                o[0] = Item;
                o[1] = myBytes;
                Invoke(uidel, o);
            }
            catch (Exception)
            {
            }
        }
        delegate void NtripUpdateUIThreadDelegate(int Item, byte[] myBytes);
        private void NtripCallBacktoUIThread(int Item, byte[] myBytes)
        {
            switch (Item)
            {
                case -1:
                    LogEvent("Waiting for NMEA GGA data...");
                    break;
                case 0:
                        LogEvent("Ntrip Client is attempting to connect.");
                    break;
                case 1:
                    LogEvent("Connected, Requesting Data...");
                    break;

                case 2:
                    pbNtrip.Value = 0;
                    pbNtrip.Visible = true;
                    LogEvent("NTRIP Client is Connected, Waiting for Data.");
                    break;

                case 3:
                    if (NtripByteCount == 0)
                    {
                        LogEvent("NTRIP Client is receiving data.");
                    }
                    NtripByteCount += myBytes.Length;

                    int remainder = System.Convert.ToInt32((NtripByteCount) % 5000);
                    remainder = (int)((double)remainder / 50);
                    pbNtrip.Value = remainder;
                    lbNtripCount.Text = NtripByteCount.ToString();
                    lbCorsCount.Text = NtripByteCount.ToString();

                    CasterForm.Default.SerialMountPoint = NtripMountPoint;
                    CasterForm.Default.CallBackSerialtoUIThread(NtripMountPoint, myBytes);
                    updateCoord();
                    saveToFile(myBytes);
                    break;

                case 100: //Thread commited suicide for some reason.
                  
                    break;

                case 101: //Got Source Table, parse it
                  
                    break;

            }
        }

        public void updateCoord() {
            //if (checkBoxFloatCoord.Checked)
            //{
            //    int num = 0;
            //    double lon = 0;
            //    double lat = 0;
            //    for (int ctr = CasterForm.Default.dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
            //    {
            //        try
            //        {
            //            lon += double.Parse(CasterForm.Default.dtconnections.Rows[ctr]["经度"].ToString());
            //            lat += double.Parse(CasterForm.Default.dtconnections.Rows[ctr]["纬度"].ToString());
            //            num++;
            //        }
            //        catch
            //        {
            //        }
            //    }
            //    if (num != 0)
            //    {
            //        tbLat.Text = (lat / num).ToString();
            //        tbLon.Text = (lon / num).ToString();
            //        client.MostRecentGGA = GPGGA.GenerateGPGGAcode(lon / num, lat / num);
            //    }
            //    client.sendGGA();
            //}
            //else {
            //    client.MostRecentGGA = GPGGA.GenerateGPGGAcode(double.Parse(tbLon.Text), double.Parse(tbLat.Text));
            //}
        }

        public void btnClearLog_Click(System.Object sender, System.EventArgs e)
        {
            rtbEvents.Text = "";
        }


        private void btnReloadUsers_Click(object sender, EventArgs e)
        {
            CasterForm.Default.btnReloadUsers_Click(sender, e);
            MessageBox.Show("加载成功");
        }

        private void btnSaveUsers_Click(object sender, EventArgs e)
        {
            CasterForm.Default.btnSaveUsers_Click(sender, e);
            MessageBox.Show("保存成功");
        }

        private void btStartServer_Click(object sender, EventArgs e)
        {
            //if (!RegisterDialog.Default.checkRegisted())
            //{
            //    DialogResult re = RegisterDialog.Default.ShowDialog();
            //    if (re != DialogResult.OK)
            //    {
            //        return;
            //    }
            //}
            System.Net.IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(this.tbIP.Text), int.Parse(tbPort.Text));
            if (sourceTable == null || string.IsNullOrEmpty( cbMountPoints.Text))
            {
                MessageBox.Show("请先选择接入点");
                return;
            }

            if (CasterForm.Default.stopFlag)
            {
                if (IsPortOccupedFun2(int.Parse(tbCasterPort.Text)))
                {
                    MessageBox.Show("端口" + tbCasterPort.Text + "被占用");
                    return;
                }
                LogEvent("正在启动....");
                NtripMountPoint = cbMountPoints.Text;
                string mountStr ="";
                for (int i = 0; i < sourceTable.DataStreams.Count; i++) {
                    if (sourceTable.DataStreams[i].MountPoint == cbMountPoints.Text) {
                        mountStr = sourceTable.DataStreams[i].Raw;
                        break;
                    }
                }
                CasterForm.Default.clearMountPoint();
                client = new NClient(iPEndPoint, tbUsername.Text, tbPassword.Text, NtripMountPoint);
                client.MostRecentGGA = GPGGA.GenerateGPGGAcode(double.Parse(tbLon.Text), double.Parse(tbLat.Text));
                //client.StartNTRIP(cbMountPoints.Text, OnDataReceivedEvent, OnMessageEvent, OnErrorEvent);
                CasterForm.Default.addMountPoint(mountStr);
                CasterForm.Default.port = int.Parse(tbCasterPort.Text);
                CasterForm.Default.StartServer();
                btStartServer.Text = "停止";
                lbCorsStatus.Text = "已连接";
                lbNtripStatus.Text = "已连接";
                timer2.Start();
                LogEvent("启动成功....");
            }
            else
            {
                LogEvent("正在关闭....");
                CasterForm.Default.StopServer();
                if (client.IsConnected()) {
                    client.StopNTRIP();
                }

                btStartServer.Text = "启动";
                lbCorsStatus.Text = "未连接";
                lbNtripStatus.Text = "未连接";
                timer2.Stop();
                LogEvent("关闭成功....");
            }
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {

            UserDialog dialog = UserDialog.Default;
            int result = (int)(dialog.ShowDialog());
            if (result == 1)
            {
                CloseDialog dialogmi = CloseDialog.Default;
                if (dialogmi.ShowDialog() == DialogResult.OK)
                {
                    string pass = dialogmi.tbPassword.Text;
                    if (pass != "admin")
                    {
                        MessageBox.Show("密码错误！");
                        return;
                    }
                }
                else
                {
                    return;
                }
                string username = dialog.tbUsername.Text;
                string password = dialog.tbPassword.Text;
                DateTime time = dialog.dateTimePicker1.Value;
                for (int ctr = CasterForm.Default.dtusers.Rows.Count - 1; ctr >= 0; ctr--)
                {
                    if (CasterForm.Default.dtusers.Rows[ctr]["用户名"].ToString() == username)
                    {
                        MessageBox.Show("用户名已存在！");
                        return;
                    }
                }
                CasterForm.Default.dtusers.Rows.Add(username, password, time.ToString("yyyy-MM-dd hh:mm:ss"));
            }
            dgvUsers.DataSource = CasterForm.Default.dtusers;
        }

        private void btDelUser_Click(object sender, EventArgs e)
        {
            CloseDialog dialogmi = CloseDialog.Default;
            int resultmi = (int)(dialogmi.ShowDialog());
            if (resultmi == 1)
            {
                string pass = dialogmi.tbPassword.Text;
                if (pass != "admin")
                {
                    MessageBox.Show("密码错误！");
                    return;
                }
            }
            else
            {
                return;
            }
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("请先选中用户！");
                return;
            }
            DataGridViewRow dgvr = dgvUsers.CurrentRow;
            string username = dgvr.Cells["用户名"].Value.ToString();


            for (int ctr = CasterForm.Default.dtusers.Rows.Count - 1; ctr >= 0; ctr--)
            {
                if (CasterForm.Default.dtusers.Rows[ctr]["用户名"].ToString() == username)
                {
                    CasterForm.Default.dtusers.Rows.RemoveAt(ctr);
                }
            }
            CasterForm.Default.btnSaveUsers_Click(sender, e);
        }

        private void btEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("请先选中用户！");
                return;
            }
            UserDialog dialog = UserDialog.Default;
            DataGridViewRow dgvr = dgvUsers.CurrentRow;
            dialog.tbUsername.Text = dgvr.Cells["用户名"].Value.ToString();
            dialog.tbUsername.Enabled = false;
            dialog.tbPassword.Text = dgvr.Cells["密码"].Value.ToString();
            dialog.dateTimePicker1.Value = DateTime.Parse(dgvr.Cells["过期时间"].Value.ToString());
            int result = (int)(dialog.ShowDialog());
            if (result == 1)
            {
                CloseDialog dialogmi = CloseDialog.Default;
                int resultmi = (int)(dialogmi.ShowDialog());
                if (resultmi == 1)
                {
                    string pass = dialogmi.tbPassword.Text;
                    if (pass != "admin")
                    {
                        MessageBox.Show("密码错误！");
                        return;
                    }
                }
                else
                {
                    return;
                }
                string username = dialog.tbUsername.Text;
                string password = dialog.tbPassword.Text;
                DateTime time = dialog.dateTimePicker1.Value;
                for (int ctr = CasterForm.Default.dtusers.Rows.Count - 1; ctr >= 0; ctr--)
                {
                    if (CasterForm.Default.dtusers.Rows[ctr]["用户名"].ToString() == username)
                    {
                        CasterForm.Default.dtusers.Rows[ctr]["密码"] = password;
                        CasterForm.Default.dtusers.Rows[ctr]["过期时间"] = time.ToString("yyyy-MM-dd hh:mm:ss");
                    }
                }
            }
            CasterForm.Default.btnSaveUsers_Click(sender, e);
        }

        private void txServerPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        public void Timer1_Tick(System.Object sender, System.EventArgs e)
        {
            if (TimerTickCount % 10 == 0) //Do this once per second
            {
                dgvConnections.DataSource = CasterForm.Default.dtconnections;
                lblStatusBar.Text = "Connected " + dgvConnections.RowCount;
            }
            if (!CasterForm.Default.stopFlag) {

                if (TimerTickCount % 600 == 0 && TimerTickCount/600 != this.rinexHourTick) { //一分钟
                    this.rinexHourTick = TimerTickCount / 600;
                    convertHourRenix();
                }
                if (TimerTickCount % 600*60 == 0 &&  TimerTickCount / (600*60) != this.rinexDaytick)//一小时
                {
                    this.rinexDaytick = TimerTickCount / (600 * 60);
                    convertDayRenix();
                }
            }
            TimerTickCount++;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            CloseDialog dialog = CloseDialog.Default;
            int result = (int)(dialog.ShowDialog());
            if (result == 1)
            {
                string password = dialog.tbPassword.Text;
                if (password != "admin")
                {
                    MessageBox.Show("密码错误！");
                    return;
                }
                saveConfig();
            }
        }


        private void saveConfig() {

            string config = "";
            foreach (Control control in groupBox1.Controls)  //在Form中遍历所有控件
            {
                //如果是文本框则操作
                if (control is TextBox )
                {
                    TextBox t = (TextBox)control;
                    config += t.Text + ";";
                }
                if (control is ComboBox)
                {
                    ComboBox t = (ComboBox)control;
                    config += t.Text + ";";
                }
            }
            foreach (Control control in groupBox2.Controls)  //在Form中遍历所有控件
            {
                //如果是文本框则操作
                if (control is TextBox)
                {
                    TextBox t = (TextBox)control;
                    config += t.Text + ";";
                }
                if (control is ComboBox)
                {
                    ComboBox t = (ComboBox)control;
                    config += t.Text + ";";
                }
            }

            config += tbCasterPort.Text;
            Settings.Default.config = config;
            Settings.Default.Save();
            MessageBox.Show("保存成功");
        }

        private void readConfig()
        {
            string config = Settings.Default.config;
            if (string.IsNullOrEmpty(config)) {
                return;
            }

            string[] arr = config.Split(';');

            int index = 0;
            foreach (Control control in groupBox1.Controls)  //在Form中遍历所有控件
            {
                //如果是文本框则操作
                if (control is TextBox)
                {
                    TextBox t = (TextBox)control;
                    t.Text = arr[index];
                    index++;
                }
                if (control is ComboBox)
                {
                    ComboBox t = (ComboBox)control;
                    t.Text = arr[index];
                    index++;
                }
            }
            foreach (Control control in groupBox2.Controls)  //在Form中遍历所有控件
            {
                //如果是文本框则操作
                if (control is TextBox)
                {
                    TextBox t = (TextBox)control;
                    t.Text = arr[index];
                    index++;
                }
                if (control is ComboBox)
                {
                    ComboBox t = (ComboBox)control;
                    t.Text = arr[index];
                    index++;
                }
            }

            tbCasterPort.Text = arr[index];
            btGetMountPoints_Click(null, null);
        }

        /// <summary>
        /// 判断指定端口号是否被占用
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        internal static Boolean IsPortOccupedFun2(Int32 port)
        {
            Boolean result = false;
            try
            {
                System.Net.NetworkInformation.IPGlobalProperties iproperties = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties();
                System.Net.IPEndPoint[] ipEndPoints = iproperties.GetActiveTcpListeners();
                foreach (var item in ipEndPoints)
                {
                    if (item.Port == port)
                    {
                        result = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        private void btGetMountPoints_Click(object sender, EventArgs e)
        {
          
            try {
                System.Net.IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(this.tbIP.Text), int.Parse(tbPort.Text));
                SharpGPS.NTRIP.NTRIPClient client = new SharpGPS.NTRIP.NTRIPClient(iPEndPoint, tbUsername.Text, tbPassword.Text, null);
                sourceTable = client.GetSourceTable();
                cbMountPoints.Items.Clear();
                for (int i = 0; i < sourceTable.DataStreams.Count; i++)
                {
                    cbMountPoints.Items.Add(sourceTable.DataStreams[i].MountPoint);
                    cbMountPoints.Text = sourceTable.DataStreams[i].MountPoint;
                }
            }catch(Exception esss){
                MessageBox.Show("获取接入点失败！");
            }
          
        }

        private void OnDataReceivedEvent(byte[] myBytes)
        {
            NtripUpdateUIThread(3, myBytes);
        }

        public  void OnMessageEvent(string msg){
            SendStuffToUIThread(0, msg);
            //LogEvent(msg);
        }


        public void OnErrorEvent(string msg)
        {
            MessageBox.Show(msg);
            SendStuffToUIThread(99, msg);
           
        }

        private void saveToFile(byte[] data) {
            if (cbSaveHour.Checked) {
                writerFile(getHourRtcmFileName(), data);
            }
            if (cbSaveDay.Checked)
            {
                writerFile(getDayRtcmFileName(), data);
            }
        }

        //利用byte[]数组写入文件
        protected void writerFile(string fileName,byte[] data)
        {
            if (!Directory.Exists(tbRtcmHourSavePath.Text + "\\" + tbSiteName.Text)) {
                Directory.CreateDirectory(tbRtcmHourSavePath.Text + "\\" + tbSiteName.Text);
            }
            //创建一个文件流
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            fs.Seek(0, System.IO.SeekOrigin.End);
            //将byte数组写入文件中
            fs.Write(data, 0, data.Length);
            //所有流类型都要关闭流，否则会出现内存泄露问题
            fs.Close();
        }

        private string getHourRtcmFileName() {
            DateTime UTCTime = DateTime.UtcNow;
            string fileName = tbSiteName.Text + "_" + UTCTime.ToString("yyyyMMddHH") + ".rtcm3";
            fileName = tbRtcmHourSavePath.Text + "\\"+ tbSiteName.Text + "\\" + fileName;
            return fileName;
        }

        private string getDayRtcmFileName()
        {
            DateTime UTCTime = DateTime.UtcNow;
            string fileName = tbSiteName.Text + "_" + UTCTime.ToString("yyyyMMdd") + ".rtcm3";
            fileName = tbRtcmHourSavePath.Text + "\\"+ tbSiteName.Text + "\\" + fileName;
            return fileName;
        }

        private void convertHourRenix()
        {
            if (!cbHourRinex.Checked) {
                return;
            }
            string file = getHourRtcmFileName();
            if (File.Exists(file)) {
                convertToRenix(file);
            }
            DateTime UTCTime = DateTime.UtcNow;
            if (UTCTime.Minute == 0) {
                UTCTime.AddMinutes(-1);
                string fileName = tbSiteName.Text + "_" + UTCTime.ToString("yyyyMMdd") + ".rtcm3";
                fileName = tbRtcmHourSavePath.Text + "\\" + tbSiteName.Text + "\\" + fileName;
                if (File.Exists(fileName))
                {
                    convertToRenix(fileName);
                }
            }
        }

        private void convertDayRenix()
        {
            if (!cbDayRinex.Checked)
            {
                return;
            }
            string file = getDayRtcmFileName();
            if (File.Exists(file))
            {
                convertToRenix(file);
            }
            DateTime UTCTime = DateTime.UtcNow;
            if (UTCTime.Hour == 0)
            {
                UTCTime.AddHours(-1);
                string fileName = tbSiteName.Text + "_" + UTCTime.ToString("yyyyMMdd") + ".rtcm3";
                fileName = tbRtcmHourSavePath.Text + "\\" + tbSiteName.Text + "\\" + fileName;
                if (File.Exists(fileName))
                {
                    convertToRenix(fileName);
                }
            }
        }

        private void convertToRenix(string fileName) 
        {
            string fromat = "rtcm3";
            if (cbMountPoints.Text.ToLower().Contains("rtcm2")) {
                fromat= "rtcm2";
            }
            Process p = new Process();
            p.StartInfo.FileName = "convbin.exe";//需要启动的程序名       
            p.StartInfo.Arguments = " "+ fileName + " -tr " + DateTime.UtcNow.ToString("yyyy/MM/dd hh:mm:ss") + " -hm " + tbSiteName.Text + "-o " + tbSiteName.Text + " - n " + tbSiteName.Text +" -d rinex/ -c " + tbSiteName.Text + " -r " + fromat;//启动参数    
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();//启动       
            p.WaitForExit();//等待程序执行完退出进程
            p.Close();
        }

        private void btHourConvert_Click(object sender, EventArgs e)
        {
            string file = getHourRtcmFileName();
            if (File.Exists(file))
            {
                convertToRenix(file);
                MessageBox.Show(file + "转换成功！");
            }
            else {
                MessageBox.Show("请先开启按小时保存原始数据！");
            }
        }

        private void btDayConvert_Click(object sender, EventArgs e)
        {
            string file = getDayRtcmFileName();
            if (File.Exists(file))
            {
                convertToRenix(file);
                MessageBox.Show(file + "转换成功！");
            }
            else
            {
                MessageBox.Show("请先开启按天保存原始数据！");
            }
        }

        private void checkBoxFloatCoord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFloatCoord.Checked)
            {
                tbLat.Enabled = false;
                tbLon.Enabled = false;
            }
            else {
                tbLat.Enabled = true;
                tbLon.Enabled = true;
            }
        }

        /// <summary>
        /// socket日志回调
        /// </summary>
        /// <param name="Action"></param>
        /// <param name="ConnID"></param>
        /// <param name="Message"></param>
        public void LogToUIThread(int Action, object Message)
        {
            try
            {
                LogToUIThreadDelegate uidel = new LogToUIThreadDelegate(LogOnUIThread);
                object[] o = new object[2];
                o[0] = Action;
                o[1] = Message;
                Invoke(uidel, o);
            }
            catch (Exception e)
            {
            }
        }
        delegate void LogToUIThreadDelegate(int Action, object Message);
        private void LogOnUIThread(int Action, object Message)
        {
            switch (Action)
            {
                case 0: //On start up, list IP and port
                    LogEvent(Message as string);
                    break;
                case 1: //On start up, list IP and port
                    //updateStatus();
                    break;
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (client != null && !CasterForm.Default.stopFlag) {
                if (CasterForm.Default.dgvConnections.Rows.Count > 0)
                {
                    if (tbLon.Text == "0" && tbLat.Text == "0" ||  string.IsNullOrEmpty(tbLat.Text)|| string.IsNullOrEmpty(tbLon.Text)) {
                        for (int i = 0; i < CasterForm.Default.dtconnections.Rows.Count; i++) {
                            if (tbLon.Text == "0" && tbLat.Text == "0" || string.IsNullOrEmpty(tbLat.Text) || string.IsNullOrEmpty(tbLon.Text))
                            {
                                tbLon.Text = CasterForm.Default.dtconnections.Rows[0]["经度"].ToString();
                                tbLat.Text = CasterForm.Default.dtconnections.Rows[0]["纬度"].ToString();
                            }
                        }
                      
                    }
                    if (!client.IsConnected())
                    {
                        client.StartNTRIP();
                    }
                    try
                    {
                        Random Rdm = new Random();
                        double d = Rdm.NextDouble() / 10000;
                        double lon = double.Parse(tbLon.Text) + d;
                        double lat = double.Parse(tbLat.Text) + d;
                        if (lon != 0.0 && lat != 0.0)
                        {
                            client.MostRecentGGA = GPGGA.GenerateGPGGAcode(double.Parse(tbLon.Text) + d, double.Parse(tbLat.Text) + d);
                            client.sendGGA();
                        }
                    }
                    catch
                    {

                    }
                }
                else {
                    try
                    {
                        if (client.IsConnected())
                        {
                            client.StopNTRIP();
                        }
                        if (checkBoxFloatCoord.Checked) {
                            tbLon.Text = "0";
                            tbLat.Text = "0";
                        }
                    }
                    catch { 
                    
                    }
                }
               
            }
        
        }

        private void buttonCoord_Click(object sender, EventArgs e)
        {
            FrmCoord frmCoord = FrmCoord.Default;
            try
            {
                frmCoord.Coord = new GMap.NET.PointLatLng(double.Parse(tbLat.Text), double.Parse(tbLon.Text));
            }
            catch (Exception eee)
            {

            }
            if (frmCoord.ShowDialog() == DialogResult.OK)
            {
                tbLon.Text = frmCoord.Coord.Lng.ToString();
                tbLat.Text = frmCoord.Coord.Lat.ToString();
            }
        }
    }

}
