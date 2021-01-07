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
using NtripClient.Util;

namespace NTRIPClient
{
    public partial class TCPForm
    {
        public TCPForm()
        {
            // VBConversions Note: Non-static class variable initialization is below.  Class variables cannot be initially assigned non-static values in C#.
            settingsfile = Application.StartupPath + "\\Settings.txt";
            lastSize = Size;

            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static TCPForm defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static TCPForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new TCPForm();
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

        public bool WriteEventsToFile = true;
        //System.Net.IPAddress ip = System.Net.IPAddress.Any;
        //public int TCPSercverPort = 3000;

        public string ReceiverCorrDataType = "RTCMV3";
        //private TcpListener listener;
        //public static string NTRIPMountPoint = "RTCM32";
        private int TCPByteCount = 0;
        String rtcm30 = "STR;##;##;RTCM 3.0;1004(1),1012(1),1005(10);2;GNSS;EagleGnss;CHN;0.00;0.00;1;0;NRS00380608;none;B;N;9600;";
        String rtcm32 = "STR;##;##;RTCM 3.2;1074(1),1084(1),1124(1),1005(5),1007(5),1033(5);2;GNSS;EagleGnss;CHN;0.00;0.00;1;1;NRS1.180703;none;B;N;19200;";
        TCPServer tcpServer1 = new TCPServer();
        TCPServer tcpServer2 = new TCPServer();
        TCPServer tcpServer3 = new TCPServer();
        TCPServer tcpServer4 = new TCPServer();
        TCPServer tcpServer5 = new TCPServer();
        TCPServer tcpServer6 = new TCPServer();
        TCPServer tcpServer7 = new TCPServer();
        TCPServer tcpServer8 = new TCPServer();

        private DateTime startTime =  DateTime.Now;

        Size lastSize; // VBConversions Note: Initial value cannot be assigned here since it is non-static.  Assignment has been moved to the class constructors.

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
            //SharpGPS.NMEA.GPGGA gga = new SharpGPS.NMEA.GPGGA("$GPGGA,175056.000,3402.1525,N,11710.8684,W,1,08,0.9,461.2,M,-32.5,M,,0000*65");
            //txServerPort.Text = TCPSercverPort.ToString();
            Timer1.Start();

            timerDog.Start();
        }

        public void MainForm_LocationChanged(System.Object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
            }
        }
        public void MainForm_ResizeEnd(System.Object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                lastSize = this.Size;
            }
        }
        public void MainForm_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
        {

            CloseDialog dialog = CloseDialog.Default;
            int result = (int)(dialog.ShowDialog());
            if (result == 1)
            {
                string password = dialog.tbPassword.Text;
                if (password != "admin")
                {
                    MessageBox.Show("密码错误！");
                    e.Cancel = true;
                    return;
                }
                Timer1.Stop();
                tcpServer1.StopServer();
                tcpServer2.StopServer();
                tcpServer3.StopServer();
                tcpServer4.StopServer();
                tcpServer5.StopServer();
                tcpServer6.StopServer();
                tcpServer7.StopServer();
                tcpServer8.StopServer();
                CasterForm.Default.StopServer();
                //CasterForm.Default.Close();
            }
            else
            {
                e.Cancel = true;
                return;
            }

        }

        public void stop() {
            tcpServer1.StopServer();
            tcpServer2.StopServer();
            tcpServer3.StopServer();
            tcpServer4.StopServer();
            tcpServer5.StopServer();
            tcpServer6.StopServer();
            tcpServer7.StopServer();
            tcpServer8.StopServer();
            CasterForm.Default.Close();
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
            // Save setting value
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
            string mm = "\r\n" + System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " - " + Message;
            rtbEvents.AppendText(mm);
            rtbEvents.SelectionStart = rtbEvents.TextLength;
            rtbEvents.ScrollToCaret();

            if (WriteEventsToFile)
            {
                    try
                    {
                    LogUtil.WriteLog(mm);
                    }
                    catch (Exception)
                    {
                    }            
            }
        }

        public void SendStuffToUIThread(int Action, int ConnID, string Message)
        {
            try
            {
                SendStuffToUIThreadDelegate uidel = new SendStuffToUIThreadDelegate(ProcessOnUIThread);
                object[] o = new object[3];
                o[0] = Action;
                o[1] = ConnID;
                o[2] = Message;
                Invoke(uidel, o);
            }
            catch (Exception e)
            {
            }
        }
        delegate void SendStuffToUIThreadDelegate(int Action, int ConnID, string Message);
        public void ProcessOnUIThread(int Action, int ConnID, string Message)
        {
            switch (Action)
            {
                case 0: //On start up, list IP and port
                    LogEvent(Message);
                    //lblTCPStatus.Text = Message;
                    break;
            }
        }

        public void TCPUpdateUIThread(int Item, string Value, byte[] myBytes)
        {
            try
            {
                TCPUpdateUIThreadDelegate uidel = new TCPUpdateUIThreadDelegate(TCPCallBacktoUIThread);
                object[] o = new object[3];
                o[0] = Item;
                o[1] = Value;
                o[2] = myBytes;
                Invoke(uidel, o);
            }
            catch (Exception)
            {
            }
        }
        delegate void TCPUpdateUIThreadDelegate(int Item, string Value, byte[] myBytes);
        public void TCPCallBacktoUIThread(int Item, string Value, byte[] myBytes)
        {
            switch (Item)
            {
                case 3:
                    TCPByteCount += myBytes.Length;
                    lbTCPStatus.Text = "已连接,正在接收数据";
                    int remainder = System.Convert.ToInt32((TCPByteCount) % 5000);
                    remainder = (int)((double)remainder / 50);
                    pbTCP.Value = remainder;
                    //CasterForm.Default.SerialMountPoint = Value;
                    CasterForm.Default.CallBackSerialtoUIThread(Value,myBytes);

                    foreach (Control cur in splitContainer2.Panel1.Controls)
                    {
                        if (cur is TextBox && cur.Tag != null && cur.Tag.ToString() == Value)
                        {
                            cur.Text = (double.Parse(cur.Text) + (myBytes.Length/1024.0/1024.0)).ToString("f6");
                        }
                    }

                    break;
            }
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

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void txServerPort_TextChanged(object sender, EventArgs e)
        {
            //TCPSercverPort = int.Parse(txServerPort.Text);
        }

        private void btStartServer_Click(object sender, EventArgs e)
        {
            if (btStartServer.Text == "启动")
            {
                CasterForm.Default.port = int.Parse(tbCasterPort.Text);
                if (IsPortOccupedFun2(int.Parse(tbCasterPort.Text)))
                {
                    MessageBox.Show("端口" + tbCasterPort.Text + "被占用");
                    return;
                }
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
                }
                else
                {
                    return;
                }
                CasterForm.Default.StartServer();
                btStartServer.Text = "停止";
                startTime = DateTime.Now;
                timer3.Start();
            }
            else
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
                }
                else
                {
                    return;
                }
                CasterForm.Default.StopServer();
                btStartServer.Text = "启动";
                startTime = DateTime.Now;
                timer3.Stop();
                labelStartTime.Text = "未启动";
            }
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            
            UserDialog dialog = UserDialog.Default;
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
                string des = dialog.tbDes.Text;
                for (int ctr = CasterForm.Default.dtusers.Rows.Count - 1; ctr >= 0; ctr--)
                {
                    if (CasterForm.Default.dtusers.Rows[ctr]["用户名"].ToString() == username)
                    {
                        MessageBox.Show("用户名已存在！");
                        return;
                    }
                }
                CasterForm.Default.dtusers.Rows.Add(username, password, time.ToString("yyyy-MM-dd hh:mm:ss"),des);
            }
            CasterForm.Default.btnSaveUsers_Click(sender, e);
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
            dialog.tbDes.Text = dgvr.Cells["备注"].Value.ToString();
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
                string des = dialog.tbDes.Text;
                for (int ctr = CasterForm.Default.dtusers.Rows.Count - 1; ctr >= 0; ctr--)
                {
                    if (CasterForm.Default.dtusers.Rows[ctr]["用户名"].ToString() == username)
                    {
                        CasterForm.Default.dtusers.Rows[ctr]["密码"] = password;
                        CasterForm.Default.dtusers.Rows[ctr]["过期时间"] = time.ToString("yyyy-MM-dd hh:mm:ss");
                        CasterForm.Default.dtusers.Rows[ctr]["备注"] = des;
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
            TimerTickCount++;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
        
            tcpServer1.port = int.Parse(txServerPort.Text);
            tcpServer1.pointName = tbPointName.Text;
            if (tcpServer1.stopFlag)
            {
                if (IsPortOccupedFun2(int.Parse(txServerPort.Text)))
                {
                    MessageBox.Show("端口" + txServerPort.Text + "被占用");
                    return;
                }
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
                    tcpServer1.StartServer();
                    if (cbFormat.Text.Contains("RTCM32"))
                    {
                        string mountStr = rtcm32.Replace("##", tbPointName.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    else
                    {
                        string mountStr = rtcm30.Replace("##", tbPointName.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    bt1.Text = "停止";
                }
            }
            else
            {

                CloseDialog dialog = CloseDialog.Default;
                int result = (int)(dialog.ShowDialog());
                if (result == 1)
                {
                    string password = dialog.tbPassword.Text;
                    if (password != "admin") {
                        MessageBox.Show("密码错误！");
                        return;
                    }
                    tcpServer1.StopServer();
                    CasterForm.Default.removeMountPoint(tbPointName.Text);
                    bt1.Text = "启动";
                }
               
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
          
            tcpServer2.port = int.Parse(txServerPort2.Text);
            tcpServer2.pointName = tbPointName2.Text;
            if (tcpServer2.stopFlag)
            {
                if (IsPortOccupedFun2(int.Parse(txServerPort2.Text)))
                {
                    MessageBox.Show("端口" + txServerPort2.Text + "被占用");
                    return;
                }
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
                    tcpServer2.StartServer();
                    if (cbFormat2.Text.Contains("RTCM32"))
                    {
                        string mountStr = rtcm32.Replace("##", tbPointName2.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    else
                    {
                        string mountStr = rtcm30.Replace("##", tbPointName2.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    bt2.Text = "停止";
                }
            }
            else
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
                    tcpServer2.StopServer();
                    CasterForm.Default.removeMountPoint(tbPointName2.Text);
                    bt2.Text = "启动";
                }
               
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
          
            tcpServer3.port = int.Parse(txServerPort3.Text);
            tcpServer3.pointName = tbPointName3.Text;
            if (tcpServer3.stopFlag)
            {
                if (IsPortOccupedFun2(int.Parse(txServerPort3.Text)))
                {
                    MessageBox.Show("端口" + txServerPort3.Text + "被占用");
                    return;
                }
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
                    tcpServer3.StartServer();
                    if (cbFormat3.Text.Contains("RTCM32"))
                    {
                        string mountStr = rtcm32.Replace("##", tbPointName3.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    else
                    {
                        string mountStr = rtcm30.Replace("##", tbPointName3.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    bt3.Text = "停止";
                }
            }
            else
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
                    tcpServer3.StopServer();
                    CasterForm.Default.removeMountPoint(tbPointName3.Text);
                    bt3.Text = "启动";
                }
                
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
          
            tcpServer4.port = int.Parse(txServerPort4.Text);
            tcpServer4.pointName = tbPointName4.Text;
            if (tcpServer4.stopFlag)
            {
                if (IsPortOccupedFun2(int.Parse(txServerPort4.Text)))
                {
                    MessageBox.Show("端口" + txServerPort4.Text + "被占用");
                    return;
                }
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
                    tcpServer4.StartServer();
                    if (cbFormat4.Text.Contains("RTCM32"))
                    {
                        string mountStr = rtcm32.Replace("##", tbPointName4.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    else
                    {
                        string mountStr = rtcm30.Replace("##", tbPointName4.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    bt4.Text = "停止";
                }
            }
            else
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
                    tcpServer4.StopServer();
                    CasterForm.Default.removeMountPoint(tbPointName4.Text);
                    bt4.Text = "启动";
                }
              
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
           
            tcpServer5.port = int.Parse(txServerPort5.Text);
            tcpServer5.pointName = tbPointName5.Text;
            if (tcpServer5.stopFlag)
            {
                if (IsPortOccupedFun2(int.Parse(txServerPort5.Text)))
                {
                    MessageBox.Show("端口" + txServerPort5.Text + "被占用");
                    return;
                }
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
                    tcpServer5.StartServer();
                    if (cbFormat5.Text.Contains("RTCM32"))
                    {
                        string mountStr = rtcm32.Replace("##", tbPointName5.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    else
                    {
                        string mountStr = rtcm30.Replace("##", tbPointName5.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    bt5.Text = "停止";
                }
            }
            else
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
                    tcpServer5.StopServer();
                    CasterForm.Default.removeMountPoint(tbPointName5.Text);
                    bt5.Text = "启动";
                }
             
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tcpServer6.port = int.Parse(txServerPort6.Text);
            tcpServer6.pointName = tbPointName6.Text;
            if (tcpServer6.stopFlag)
            {
                if (IsPortOccupedFun2(int.Parse(txServerPort6.Text)))
                {
                    MessageBox.Show("端口" + txServerPort6.Text + "被占用");
                    return;
                }
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
                    tcpServer6.StartServer();
                    if (cbFormat6.Text.Contains("RTCM32"))
                    {
                        string mountStr = rtcm32.Replace("##", tbPointName6.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    else
                    {
                        string mountStr = rtcm30.Replace("##", tbPointName6.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    bt6.Text = "停止";
                }
            }
            else
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
                    tcpServer6.StopServer();
                    CasterForm.Default.removeMountPoint(tbPointName6.Text);
                    bt6.Text = "启动";
                }
               
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
           
            tcpServer7.port = int.Parse(txServerPort7.Text);
            tcpServer7.pointName = tbPointName7.Text;
            if (tcpServer7.stopFlag)
            {
                if (IsPortOccupedFun2(int.Parse(txServerPort7.Text)))
                {
                    MessageBox.Show("端口" + txServerPort7.Text + "被占用");
                    return;
                }

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
                    tcpServer7.StartServer();
                    if (cbFormat7.Text.Contains("RTCM32"))
                    {
                        string mountStr = rtcm32.Replace("##", tbPointName7.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    else
                    {
                        string mountStr = rtcm30.Replace("##", tbPointName7.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    bt7.Text = "停止";
                }
            }
            else
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
                    tcpServer7.StopServer();
                    CasterForm.Default.removeMountPoint(tbPointName7.Text);
                    bt7.Text = "启动";
                }
               
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
          
            tcpServer8.port = int.Parse(txServerPort8.Text);
            tcpServer8.pointName = tbPointName8.Text;
            if (tcpServer8.stopFlag)
            {
                if (IsPortOccupedFun2(int.Parse(txServerPort8.Text)))
                {
                    MessageBox.Show("端口" + txServerPort8.Text + "被占用");
                    return;
                }
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
                    tcpServer8.StartServer();
                    if (cbFormat8.Text.Contains("RTCM32"))
                    {
                        string mountStr = rtcm32.Replace("##", tbPointName8.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    else
                    {
                        string mountStr = rtcm30.Replace("##", tbPointName8.Text);
                        CasterForm.Default.addMountPoint(mountStr);
                    }
                    bt8.Text = "停止";
                }
            }
            else
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
                    tcpServer8.StopServer();
                    CasterForm.Default.removeMountPoint(tbPointName8.Text);
                    bt8.Text = "启动";
                }
               
            }
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

            string config = txServerPort.Text + ";" + tbPointName.Text + ";" + cbFormat.Text + ";";
            config += txServerPort2.Text + ";" + tbPointName2.Text + ";" + cbFormat2.Text + ";";
            config += txServerPort3.Text + ";" + tbPointName3.Text + ";" + cbFormat3.Text + ";";
            config += txServerPort4.Text + ";" + tbPointName4.Text + ";" + cbFormat4.Text + ";";
            config += txServerPort5.Text + ";" + tbPointName5.Text + ";" + cbFormat5.Text + ";";
            config += txServerPort6.Text + ";" + tbPointName6.Text + ";" + cbFormat6.Text + ";";
            config += txServerPort7.Text + ";" + tbPointName7.Text + ";" + cbFormat7.Text + ";";
            config += txServerPort8.Text + ";" + tbPointName8.Text + ";" + cbFormat8.Text + ";";
            config += tbCasterPort.Text;
            Settings.Default.config = config;
            Settings.Default.Save();
            MessageBox.Show("保存成功");
        }

        private void readConfig()
        {
            string config = Settings.Default.config;

            string[] arr = config.Split(';');
            if (arr.Length < 25) {
                return;
            }
            int index = 0;
            txServerPort.Text = arr[index];
            index++; 
            tbPointName.Text = arr[index];
            index++;
            cbFormat.Text = arr[index];
            index++;
            txServerPort2.Text = arr[index];
            index++;
            tbPointName2.Text = arr[index];
            index++;
            cbFormat2.Text = arr[index];
            index++;
            txServerPort3.Text = arr[index];
            index++;

            tbPointName3.Text = arr[index];
            index++;

            cbFormat3.Text = arr[index];
            index++;

            txServerPort4.Text = arr[index];
            index++;

            tbPointName4.Text = arr[index];
            index++;

            cbFormat4.Text = arr[index];
            index++;

            txServerPort5.Text = arr[index];
            index++;

            tbPointName5.Text = arr[index];
            index++;

            cbFormat5.Text = arr[index];
            index++;

            txServerPort6.Text = arr[index];
            index++;

            tbPointName6.Text = arr[index];
            index++;

            cbFormat6.Text = arr[index];
            index++;

            txServerPort7.Text = arr[index];
            index++;

            tbPointName7.Text = arr[index];
            index++;

            cbFormat7.Text = arr[index];
            index++;

            txServerPort8.Text = arr[index];
            index++;

            tbPointName8.Text = arr[index];
            index++;

            cbFormat8.Text = arr[index];
            index++;

            tbCasterPort.Text = arr[index];
            textBox1.Tag = tbPointName.Text;
            textBox2.Tag = tbPointName2.Text;
            textBox3.Tag = tbPointName3.Text;
            textBox4.Tag = tbPointName4.Text;
            textBox5.Tag = tbPointName5.Text;
            textBox6.Tag = tbPointName6.Text;
            textBox7.Tag = tbPointName7.Text;
            textBox8.Tag = tbPointName8.Text;
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPointName_TextChanged(object sender, EventArgs e)
        {
            textBox1.Tag = tbPointName.Text;
        }

        private void tbPointName2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Tag = tbPointName2.Text;
        }

        private void tbPointName3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Tag = tbPointName3.Text;
        }

        private void tbPointName4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Tag = tbPointName4.Text;
        }

        private void tbPointName5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Tag = tbPointName5.Text;
        }

        private void tbPointName6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Tag = tbPointName6.Text;
        }

        private void tbPointName7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Tag = tbPointName7.Text;
        }

        private void tbPointName8_TextChanged(object sender, EventArgs e)
        {
            textBox8.Tag = tbPointName8.Text;
        }

        private void TCPForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void TCPForm_VisibleChanged(object sender, EventArgs e)
        {
           
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            labelStartTime.Text = "系统已运行："+(DateTime.Now - startTime).ToString("c").Substring(0, 8);
        }

        private void timerDog_Tick(object sender, EventArgs e)
        {
            if (!tcpServer1.stopFlag && tcpServer1.RecentDataTime < DateTime.Now.AddSeconds(-30)) {
                LogEvent(tcpServer1.port + "检测到数据30秒未更新，正在重启...");
                tcpServer1.StopServer();
                tcpServer1.StartServer();
            }
            if (!tcpServer2.stopFlag && tcpServer2.RecentDataTime < DateTime.Now.AddSeconds(-30))
            {
                LogEvent(tcpServer2.port + "检测到数据30秒未更新，正在重启...");
                tcpServer2.StopServer();
                tcpServer2.StartServer();
            }
            if (!tcpServer3.stopFlag && tcpServer3.RecentDataTime < DateTime.Now.AddSeconds(-30))
            {
                LogEvent(tcpServer3.port + "检测到数据30秒未更新，正在重启...");
                tcpServer3.StopServer();
                tcpServer3.StartServer();
            }
            if (!tcpServer4.stopFlag && tcpServer4.RecentDataTime < DateTime.Now.AddSeconds(-30))
            {
                LogEvent(tcpServer4.port + "检测到数据30秒未更新，正在重启...");
                tcpServer4.StopServer();
                tcpServer4.StartServer();
            }
            if (!tcpServer5.stopFlag && tcpServer5.RecentDataTime < DateTime.Now.AddSeconds(-30))
            {
                LogEvent(tcpServer5.port + "检测到数据30秒未更新，正在重启...");
                tcpServer5.StopServer();
                tcpServer5.StartServer();
            }
            if (!tcpServer6.stopFlag && tcpServer6.RecentDataTime < DateTime.Now.AddSeconds(-30))
            {
                LogEvent(tcpServer6.port + "检测到数据30秒未更新，正在重启...");
                tcpServer6.StopServer();
                tcpServer6.StartServer();
            }
            if (!tcpServer7.stopFlag && tcpServer7.RecentDataTime < DateTime.Now.AddSeconds(-30))
            {
                LogEvent(tcpServer7.port + "检测到数据30秒未更新，正在重启...");
                tcpServer7.StopServer();
                tcpServer7.StartServer();
            }
            if (!tcpServer8.stopFlag && tcpServer8.RecentDataTime < DateTime.Now.AddSeconds(-30))
            {
                LogEvent(tcpServer8.port + "检测到数据30秒未更新，正在重启...");
                tcpServer8.StopServer();
                tcpServer8.StartServer();
            }
        }
    }

}
