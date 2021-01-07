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

using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using System.IO;

namespace NTRIPClient
{

    public partial class CasterForm
    {
        public CasterForm()
        {
            // VBConversions Note: Non-static class variable initialization is below.  Class variables cannot be initially assigned non-static values in C#.
            settingsfile = Application.StartupPath + "\\Settings.txt";
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static CasterForm defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static CasterForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new CasterForm();
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
        string settingsfile; // VBConversions Note: Initial value cannot be assigned here since it is non-static.  Assignment has been moved to the class constructors.

        private TcpListener listener;
        private System.Threading.Thread listenerThread;
        System.Net.IPAddress ip = System.Net.IPAddress.Any;
        public int port { get; set; } = 5000;
        Socket socket;
        public bool stopFlag = true; //Boolean used to indicate server stopping
        private object stopSyncObj = new object(); //Sync object used with StopFlag
        private ArrayList clients = new ArrayList(); //List containing client contexts

        public DataTable dtconnections = new DataTable();
        public DataTable dtmountpoints = new DataTable();
        public DataTable dtusers = new DataTable();

        private int TimerTickCount = 0;
        public string MyNetworkName = "GG RTK";
        public bool WriteEventsToFile = false;

        public static int ConnIDCount = 0; //Incrementing count of unique connection IDs

        public bool SerialShouldBeConnected = false;
        public int SerialPort = 1;
        public int SerialSpeed = 9600;
        public int SerialDataBits = 8;
        public int SerialStopBits = 1;
        public string SerialMountPoint = "RTCM32";
        private int SerialReceivedByteCount = 0;
        private string MountPoistsList = "";
        string sourceHeader = "SOURCETABLE 200 OK\r\n" +
"Server: EagleGnss-basic/180615 \r\n" +
"Date: 2018/07/17 15:09:53\r\n" +
"Content-Type: text/plain\r\n" +
"Content-Length:  27840\r\n";

        string sourceFoot = "ENDSOURCETABLE";


        System.IO.Ports.SerialPort COMPort = new System.IO.Ports.SerialPort();

        public void MainForm_Load(System.Object sender, System.EventArgs e)
        {
            lblVersion.Text += " " + System.Convert.ToString((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Major) + "." + Strings.Format((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Minor, "00") + "." + Strings.Format((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Build, "00");
            if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Revision != 0)
            {
                lblVersion.Text += " (Rev " + System.Convert.ToString((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Revision) + ")";
            }

            tbServerInfo.Text += "If there is a GPS base station connected to a serial port on this computer, you can use the built in NTRIP server to get that data stream out to other NTRIP Clients. Of course you can have other NTRIP Servers sending data in via the network. The local NTRIP Seriver is an option for those of you that want the Caster and Server on the same computer.";

            //LogEvent("NTRIP Caster 已启动，端口" + port);

            dtconnections.Columns.Add("ID", typeof(int));
            dtconnections.PrimaryKey = new DataColumn[] { dtconnections.Columns["ID"] };
            dtconnections.Columns.Add("接入时间");
            dtconnections.Columns.Add("接入点");
            dtconnections.Columns.Add("用户名");
            dtconnections.Columns.Add("数据量(MB)", typeof(double));
            dtconnections.Columns.Add("经度");
            dtconnections.Columns.Add("纬度");
            dtconnections.Columns.Add("状态");
            dtconnections.DefaultView.Sort = "ID";

            dtmountpoints.Columns.Add("类型");
            dtmountpoints.Columns.Add("接入点");
            dtmountpoints.Columns.Add("识别号");
            dtmountpoints.Columns.Add("差分数据格式");
            dtmountpoints.Columns.Add("频率");
            dtmountpoints.Columns.Add("载波相位数据");
            dtmountpoints.Columns.Add("导航系统");
            dtmountpoints.Columns.Add("网络");
            dtmountpoints.Columns.Add("国家");
            dtmountpoints.Columns.Add("纬度");
            dtmountpoints.Columns.Add("经度");
            dtmountpoints.Columns.Add("NMEA");
            dtmountpoints.Columns.Add("基站类型");
            dtmountpoints.Columns.Add("软件名称");
            dtmountpoints.Columns.Add("压缩算法");
            dtmountpoints.Columns.Add("访问保护");
            dtmountpoints.Columns.Add("Y/N");
            dtmountpoints.Columns.Add("比特率");
            dgvMountPoints.DataSource = dtmountpoints;

            dtusers.Columns.Add("用户名");
            dtusers.PrimaryKey = new DataColumn[] { dtusers.Columns["用户名"] };
            dtusers.Columns.Add("密码");
            dtusers.Columns.Add("过期时间");
            dtusers.Columns.Add("备注");
            dtusers.DefaultView.Sort = "用户名";
            dgvUsers.DataSource = dtusers;

            //LoadMountPointList();
            LoadUserList();
            LoadSettingsFile();

            if (WriteEventsToFile)
            {
                boxDoLogging.SelectedIndex = 1;
            }
            else
            {
                boxDoLogging.SelectedIndex = 0;
            }


            clients = ArrayList.Synchronized(clients); //use a synchronized arraylist to store the clients
            Timer1.Start();
            //StartServer();
        }
        public void MainForm_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //ProjectData.EndApp();
        }
        public void Timer1_Tick(System.Object sender, System.EventArgs e)
        {
            if (TimerTickCount % 10 == 0) //Do this once per second
            {
                dgvConnections.DataSource = dtconnections;
            }

            TimerTickCount++;
            if (TimerTickCount == 100) //Do this once every 10 seconds
            {
                TimerTickCount = 0;

                //Find connections with no username and an old start time.
                for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                {
                    if (dtconnections.Rows[ctr]["用户名"].ToString() == "")
                    {
                        if (DateAndTime.DateDiff(DateInterval.Second, System.Convert.ToDateTime(dtconnections.Rows[ctr]["接入时间"]), DateTime.Now) > 11)
                        {
                            SendStuffToSocketsThread(System.Convert.ToInt32(dtconnections.Rows[ctr]["ID"]), "401 Unauthorized", true, 0);
                        }
                    }
                }
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

            var datapathfile = Application.StartupPath + "\\Settings.txt";

            if (!(new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.FileExists(datapathfile))
            {
                //File doesn't exist. Create it.
                System.IO.StreamWriter fn = new System.IO.StreamWriter(System.IO.File.Open(datapathfile, System.IO.FileMode.Create));
                fn.WriteLine("# This is the GG  GPS Settings file. You need to use the format \"Key=Value\" for all settings.");
                fn.WriteLine("# Any line that starts with a # symbol will be ignored.");
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
                System.IO.StreamReader oRead = System.IO.File.OpenText(datapathfile);
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
            catch (Exception)
            {
            }

            if (lCtr > 0)
            {
                for (var i = 0; i <= Information.UBound(SettingsArray, 2); i++)
                {
                    value = SettingsArray[1, (int)i];
                    switch (SettingsArray[0, (int)i])
                    {
                        case "serial should be connected":
                            if (value.ToLower() == "yes")
                            {
                                SerialShouldBeConnected = true;
                            }
                            break;
                        case "serial port number":
                            if (Information.IsNumeric(value))
                            {
                                int portnumber = int.Parse(value);
                                if (portnumber > 0 & portnumber < 1025)
                                {
                                    SerialPort = portnumber;
                                }
                                else
                                {
                                    LogEvent("Specified Serial Port Number isn\'t in the range of 1 to 1024.");
                                }
                            }
                            else
                            {
                                LogEvent("Specified Serial Port Number isn\'t numeric.");
                            }
                            break;
                        case "serial port speed":
                            if (Information.IsNumeric(value))
                            {
                                int portspeed = int.Parse(value);
                                if (portspeed > 2399 & portspeed < 115201)
                                {
                                    SerialSpeed = portspeed;
                                }
                                else
                                {
                                    LogEvent("Specified Serial Port Speed isn\'t in the range of 2400 to 115200.");
                                }
                            }
                            else
                            {
                                LogEvent("Specified Serial Port Speed isn\'t numeric.");
                            }
                            break;
                        case "serial port data bits":
                            if (value == "7")
                            {
                                SerialDataBits = 7;
                            }
                            else if (value == "8")
                            {
                                SerialDataBits = 8;
                            }
                            else
                            {
                                LogEvent("Specified Serial Port Data bits should be 7 or 8.");
                            }
                            break;
                        case "serial port stop bits":
                            if (value == "0")
                            {
                                SerialStopBits = 0;
                            }
                            else if (value == "1")
                            {
                                SerialStopBits = 1;
                            }
                            else
                            {
                                LogEvent("Specified Serial Port Stop bits should be 0 or 1.");
                            }
                            break;
                        case "serial port mount point":
                            SerialMountPoint = value;
                            break;

                        case "write events to file":
                            if (value.ToLower() == "yes")
                            {
                                WriteEventsToFile = true;
                            }
                            break;

                        default:
                            break;
                            //Key not found
                            //If Not SettingsArray(0, i) = "" Then
                            //    'This will be blank if no settings were loaded
                            //End If
                    }
                }
            }

            tbServerMountPoint.Text = SerialMountPoint;

            boxSerialPort.Items.Clear();
            string targetport = "COM" + SerialPort.ToString();

            int portcount = 0;
            int portindex = 0;
            foreach (string portName in (new Microsoft.VisualBasic.Devices.Computer()).Ports.SerialPortNames)
            {
                boxSerialPort.Items.Add(portName);
                if (portName == targetport)
                {
                    portindex = portcount;
                }
                portcount++;
            }
            if (portcount == 0)
            {
                boxSerialPort.Items.Add("No Serial Ports Found");
            }
            boxSerialPort.SelectedIndex = portindex;

            if (boxSpeed.Items.Count == 9)
            {
                boxSpeed.Items.RemoveAt(8);
            }

            switch (SerialSpeed)
            {
                case 2400:
                    boxSpeed.SelectedIndex = 0;
                    break;
                case 4800:
                    boxSpeed.SelectedIndex = 1;
                    break;
                case 9600:
                    boxSpeed.SelectedIndex = 2;
                    break;
                case 14400:
                    boxSpeed.SelectedIndex = 3;
                    break;
                case 19200:
                    boxSpeed.SelectedIndex = 4;
                    break;
                case 38400:
                    boxSpeed.SelectedIndex = 5;
                    break;
                case 57600:
                    boxSpeed.SelectedIndex = 6;
                    break;
                case 115200:
                    boxSpeed.SelectedIndex = 7;
                    break;
                default: //How did this happen
                    if (boxSpeed.Items.Count == 8)
                    {
                        boxSpeed.Items.Add(SerialSpeed.ToString());
                    }
                    boxSpeed.SelectedIndex = 8;
                    break;
            }

            if (SerialDataBits == 7)
            {
                boxDataBits.SelectedIndex = 0;
            }
            else
            {
                boxDataBits.SelectedIndex = 1;
            }




            if (WriteEventsToFile)
            {
                boxDoLogging.SelectedIndex = 1;
            }
            else
            {
                boxDoLogging.SelectedIndex = 0;
            }


            if (SerialShouldBeConnected)
            {
                OpenMySerialPort(false);
            }
        }
        public void SaveSetting(string key1, string value1, string key2 = "", string value2 = "", string key3 = "", string value3 = "")
        {
            if (!(new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.FileExists(settingsfile)) //File doesn't exist. Create it.
            {
                System.IO.StreamWriter fn = new System.IO.StreamWriter(System.IO.File.Open(settingsfile, System.IO.FileMode.Create));
                fn.WriteLine("# This is the GG GPS Data Path Pointer file. You need to use the format \"Key=Value\" for all settings.");
                fn.WriteLine("# Any line that starts with a # symbol will be ignored.");
                fn.WriteLine("# The only setting in this file should be the Data Path Location.");
                fn.WriteLine("");
                fn.Close();
            }


            string[] keyvalpair = new string[2];
            System.IO.StreamReader oRead = System.IO.File.OpenText(settingsfile);
            string linein = "";
            string newfile = "";
            bool foundkey1 = false;
            bool foundkey2 = false;
            bool foundkey3 = false;

            while (oRead.Peek() != -1)
            {
                linein = oRead.ReadLine().Trim();
                if (linein.Length < 3)
                {
                    //Line is too short
                    newfile += linein;
                }
                else if (Strings.Asc(linein) == 35)
                {
                    //Line starts with a #
                    newfile += linein;
                }
                else if (linein.IndexOf("=") + 1 < 2)
                {
                    //There is no equal sign in the string
                    newfile += linein;
                }
                else
                {
                    keyvalpair = Strings.Split(linein, "=", 2);
                    if (keyvalpair[0].Trim().ToLower() == key1.ToLower())
                    {
                        //Found the right key, update it.
                        newfile += keyvalpair[0] + "=" + value1;
                        foundkey1 = true;
                    }
                    else if (key2.Length > 0 && keyvalpair[0].Trim().ToLower() == key2.ToLower())
                    {
                        newfile += keyvalpair[0] + "=" + value2;
                        foundkey2 = true;
                    }
                    else if (key3.Length > 0 && keyvalpair[0].Trim().ToLower() == key3.ToLower())
                    {
                        newfile += keyvalpair[0] + "=" + value3;
                        foundkey3 = true;
                    }
                    else
                    {
                        newfile += linein;
                    }
                }
                newfile += "\r\n";
            }
            oRead.Close();

            if (!foundkey1)
            {
                newfile += key1 + "=" + value1 + "\r\n";
            }
            if (key2.Length > 0 && !foundkey2)
            {
                newfile += key2 + "=" + value2 + "\r\n";
            }
            if (key3.Length > 0 && !foundkey3)
            {
                newfile += key3 + "=" + value3 + "\r\n";
            }


            try
            {
                System.IO.StreamWriter sWriter = new System.IO.StreamWriter(settingsfile);
                sWriter.Write(newfile);
                sWriter.Flush();
                sWriter.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadMountPointList()
        {
            //Load sourcetable file into drop down list
            string sourcetablefile = Application.StartupPath + "\\sourcetable.dat";
            if (System.IO.File.Exists(sourcetablefile))
            {
                FileStream fileStream = null;
                StreamReader streamReader = null;

                try
                {
                    fileStream = new FileStream(sourcetablefile, FileMode.Open, FileAccess.Read);
                    streamReader = new StreamReader(fileStream, Encoding.Default);

                    fileStream.Seek(0, SeekOrigin.Begin);

                    string linein = streamReader.ReadLine();
                    string sourcefile = "";

                    while (linein != null)
                    {
                        sourcefile += linein + "\r\n";
                        string[] objects = Strings.Split(System.Convert.ToString(linein), ";");
                        if (linein.Contains("STR"))
                        {
                            dtmountpoints.Rows.Add(objects[0], objects[1], objects[2], objects[3], objects[4], objects[5], objects[6], objects[7], objects[8], objects[9], objects[10]
                                , objects[11], objects[12], objects[13], objects[14], objects[15], objects[16], objects[17]);
                        }
                        linein = streamReader.ReadLine();
                    }

                    MountPoistsList = sourcefile;
                }
                catch (Exception e)
                {
                    string ss = e.Message;
                }
                finally
                {
                    if (fileStream != null)
                    {
                        fileStream.Close();
                    }
                    if (streamReader != null)
                    {
                        streamReader.Close();
                    }
                }
            }
            else
            {
                dtmountpoints.Rows.Add("RTCM32", "1234", "RTCM", "2", "GPS", "41.0", "117.0");
                SaveMountPointList();
            }
        }
        public void addMountPoint(string data)
        {
            string[] objects = Strings.Split(data, ";");
            if (data.Contains("STR"))
            {
                dtmountpoints.Rows.Add(objects[0], objects[1], objects[2], objects[3], objects[4], objects[5], objects[6], objects[7], objects[8], objects[9], objects[10]
                    , objects[11], objects[12], objects[13], objects[14], objects[15], objects[16], objects[17]);
            }

            MountPoistsList += data + "\r\n";
        }

        public void clearMountPoint()
        {
            MountPoistsList =  "";
        }

        public void removeMountPoint(string data)
        {
            MountPoistsList = "";
            for (int ctr = dtmountpoints.Rows.Count - 1; ctr >= 0; ctr--)
            {
                if (dtmountpoints.Rows[ctr][1].ToString() == data)
                {
                    dtmountpoints.Rows.RemoveAt(ctr);
                    continue;
                }
                else
                {
                    MountPoistsList += dtmountpoints.Rows[ctr][0] + ";" + dtmountpoints.Rows[ctr][1] + ";" +
                    dtmountpoints.Rows[ctr][2] + ";" + dtmountpoints.Rows[ctr][3] + ";" +
                    dtmountpoints.Rows[ctr][4] + ";" + dtmountpoints.Rows[ctr][5] + ";" +
                    dtmountpoints.Rows[ctr][6] + ";" + dtmountpoints.Rows[ctr][7] + ";" +
                    dtmountpoints.Rows[ctr][8] + ";" + dtmountpoints.Rows[ctr][9] + ";" +
                    dtmountpoints.Rows[ctr][10] + ";" + dtmountpoints.Rows[ctr][11] + ";" +
                    dtmountpoints.Rows[ctr][12] + ";" + dtmountpoints.Rows[ctr][13] + ";" +
                    dtmountpoints.Rows[ctr][14] + ";" + dtmountpoints.Rows[ctr][15] + ";" +
                    dtmountpoints.Rows[ctr][16] + ";" + dtmountpoints.Rows[ctr][17] + "\r\n";
                }
            }
        }


        private void SaveMountPointList()
        {
            //var mountpointlistfile = Application.StartupPath + "\\mountpoints.txt";

            //System.IO.StreamWriter fn = new System.IO.StreamWriter(System.IO.File.Open(mountpointlistfile, System.IO.FileMode.Create));
            //fn.WriteLine("#MountPoint Name;MountPoint Password;Format;Carrier;Navigation System;Latitude;Longitude");
            //for (int ctr = 0; ctr <= dtmountpoints.Rows.Count - 1; ctr++)
            //{
            //    fn.WriteLine(dtmountpoints.Rows[ctr]["MountPoint"] + ";" + dtmountpoints.Rows[ctr]["Password"] + ";" + dtmountpoints.Rows[ctr]["Format"] + ";" + dtmountpoints.Rows[ctr]["Carrier"] + ";" + dtmountpoints.Rows[ctr]["NavSys"] + ";" + dtmountpoints.Rows[ctr]["Lat"] + ";" + dtmountpoints.Rows[ctr]["Lon"]);
            //}
            //fn.Close();
        }
        public void btnReloadMountPoints_Click(System.Object sender, System.EventArgs e)
        {
            LoadMountPointList();
        }
        public void btnSaveMountPoints_Click(System.Object sender, System.EventArgs e)
        {
            SaveMountPointList();
        }


        private void LoadUserList()
        {
            var userlistfile = Application.StartupPath + "\\users.txt";
            dtusers.Rows.Clear();
            if (File.Exists(userlistfile))
            {
                try
                {
                    System.IO.StreamReader oRead = System.IO.File.OpenText(userlistfile);
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
                        else if (linein.ToString().IndexOf(";") + 1 < 1)
                        {
                            //There is no equal sign in the string
                        }
                        else
                        {
                            string[] objects = Strings.Split(System.Convert.ToString(linein), ";");
                            if ((objects.Length - 1) >= 3)
                            {
                                dtusers.Rows.Add(objects[0], objects[1], objects[2], objects[3]);
                            }
                        }
                    }
                    oRead.Close();
                }
                catch (Exception)
                {
                }
            }
            //else
            //{
            //    dtusers.Rows.Add("test", "1234");
            //    SaveUserList();
            //}
        }
        private void SaveUserList()
        {
            var userlistfile = Application.StartupPath + "\\users.txt";

            System.IO.StreamWriter fn = new System.IO.StreamWriter(System.IO.File.Open(userlistfile, System.IO.FileMode.Create));
            fn.WriteLine("#用户名;密码;过期时间");
            for (int ctr = 0; ctr <= dtusers.Rows.Count - 1; ctr++)
            {
                fn.WriteLine(dtusers.Rows[ctr]["用户名"] + ";" + dtusers.Rows[ctr]["密码"] + ";" + dtusers.Rows[ctr]["过期时间"] + ";" + dtusers.Rows[ctr]["备注"]);
            }
            fn.Close();
        }
        public void btnReloadUsers_Click(System.Object sender, System.EventArgs e)
        {
            LoadUserList();
        }
        public void btnSaveUsers_Click(System.Object sender, System.EventArgs e)
        {
            SaveUserList();
        }


        public void LogEvent(string Message)
        {
            TCPForm.Default.LogEvent(Message);
            if (rtbEvents.TextLength > 5000)
            {
                string NewText = rtbEvents.Text.Substring(999); //Drop first 1000 characters
                NewText = NewText.Remove(0, System.Convert.ToInt32(NewText.IndexOf(Strings.ChrW(10)) + 1)); //Drop up to the next new line
                rtbEvents.Text = NewText;
            }

            rtbEvents.AppendText("\r\n" + System.Convert.ToString(DateAndTime.TimeOfDay) + " - " + Message);
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
        public void boxDoLogging_SelectionChangeCommitted(System.Object sender, System.EventArgs e)
        {
            if (boxDoLogging.SelectedIndex == 0)
            {
                if (WriteEventsToFile)
                {
                    SaveSetting("Write Events to File", "No");
                    WriteEventsToFile = false;
                }
            }
            else
            {
                if (!WriteEventsToFile)
                {
                    SaveSetting("Write Events to File", "Yes");
                    WriteEventsToFile = true;
                }
            }
        }

        public void btnSerialConnect_Click(System.Object sender, System.EventArgs e)
        {
            if (btnSerialConnect.Text == "Connect")
            {
                //Save settings
                if ((string)boxSerialPort.SelectedItem == "No Serial Ports Found")
                {
                    LogEvent("No serial port was selected. NTRIP Server cannot start.");
                    return;
                }
                else //Some serial port was selected
                {
                    SerialPort = int.Parse(Strings.Replace(System.Convert.ToString(boxSerialPort.SelectedItem), "COM", ""));
                    SaveSetting("Serial Port Number", System.Convert.ToString(SerialPort));
                }

                switch (boxSpeed.SelectedIndex)
                {
                    case 0:
                        SerialSpeed = 2400;
                        break;
                    case 1:
                        SerialSpeed = 4800;
                        break;
                    case 2:
                        SerialSpeed = 9600;
                        break;
                    case 3:
                        SerialSpeed = 14400;
                        break;
                    case 4:
                        SerialSpeed = 19200;
                        break;
                    case 5:
                        SerialSpeed = 38400;
                        break;
                    case 6:
                        SerialSpeed = 57600;
                        break;
                    case 7:
                        SerialSpeed = 115200;
                        break;
                    case 8:
                        break;
                        //custom speed selected. Don't change it
                }

                if (boxDataBits.SelectedIndex == 0)
                {
                    SerialDataBits = 7;
                }
                else
                {
                    SerialDataBits = 8;
                }

                SerialMountPoint = tbServerMountPoint.Text;

                SaveSetting("Serial Port Speed", System.Convert.ToString(SerialSpeed), "Serial Port Data Bits", System.Convert.ToString(SerialDataBits), "Serial Port Mount Point", SerialMountPoint);
                LogEvent("Serial Port Settings Saved");

                if (string.IsNullOrEmpty(SerialMountPoint))
                {
                    lblSerialStatus.Text = "No Mount Point Specified";
                    return;
                }

                OpenMySerialPort(true);
            }
            else
            {
                CloseMySerialPort();
                SaveSetting("Serial Should be Connected", "No");
            }
        }

        public void OpenMySerialPort(bool UserClickedConnect)
        {
            if (COMPort.IsOpen)
            {
                COMPort.RtsEnable = false;
                COMPort.DtrEnable = false;
                COMPort.Close();
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
            }

            if (string.IsNullOrEmpty(SerialMountPoint))
            {
                lblSerialStatus.Text = "No Mount Point Specified";
                return;
            }
            bool FoundMP = false;
            for (int ctr = dtmountpoints.Rows.Count - 1; ctr >= 0; ctr--)
            {
                if (dtmountpoints.Rows[ctr]["MountPoint"].ToString() == SerialMountPoint)
                {
                    FoundMP = true;
                }
            }
            if (!FoundMP)
            {
                lblSerialStatus.Text = "Mount Point not found";
                return;
            }


            SerialReceivedByteCount = 0;
            lblSerialStatus.Text = "Connecting";

            COMPort.PortName = "COM" + System.Convert.ToString(SerialPort);
            COMPort.BaudRate = SerialSpeed;
            COMPort.DataBits = SerialDataBits;
            //If SerialStopBits = 1 Then
            COMPort.StopBits = System.IO.Ports.StopBits.One;
            //Else
            //COMPort.StopBits = IO.Ports.StopBits.None
            //End If
            COMPort.WriteTimeout = 2000;
            COMPort.ReadTimeout = 2000;

            COMPort.DataReceived += SerialInput;

            try
            {
                COMPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (COMPort.IsOpen)
            {
                COMPort.RtsEnable = true;
                COMPort.DtrEnable = true;

                //Kick start the serial port so it starts reading data.
                COMPort.BreakState = true;
                System.Threading.Thread.Sleep((int)(((double)11000 / COMPort.BaudRate) + 2)); // Min. 11 bit delay (startbit, 8 data bits, parity bit, stopbit)
                COMPort.BreakState = false;


                if (UserClickedConnect)
                {
                    SaveSetting("Serial Should be Connected", "Yes");
                }

                //Change connect/disconnect button display status
                lblSerialStatus.Text = "Connected to COM " + System.Convert.ToString(SerialPort) + " at " + System.Convert.ToString(SerialSpeed) + "bps";
                btnSerialConnect.Text = "Disconnect";

                tbServerMountPoint.Enabled = false;
                boxSerialPort.Enabled = false;
                boxSpeed.Enabled = false;
                boxDataBits.Enabled = false;

            }
            else
            {
                lblSerialStatus.Text = "Unable to open serial port";
            }
        }
        public void CloseMySerialPort()
        {
            COMPort.DataReceived -= SerialInput;
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);

            if (COMPort.IsOpen)
            {
                COMPort.Close();
            }

            //Change connect/disconnect button display status
            btnSerialConnect.Text = "Connect";
            lblSerialStatus.Text = "Disconnected";

            tbServerMountPoint.Enabled = true;
            boxSerialPort.Enabled = true;
            boxSpeed.Enabled = true;
            boxDataBits.Enabled = true;
        }

        private void SerialInput(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1024];
                int len = COMPort.Read(buffer, 0, buffer.Length);
                if (len > 0)
                {
                    byte[] bytes = new byte[len - 1 + 1];
                    Array.Copy(buffer, bytes, len); //Copy to another buffer
                    SendSerialLineToUIThread(SerialMountPoint, bytes);
                }
            }
            catch (TimeoutException)
            {
            }
        }
        public void SendSerialLineToUIThread(string MountPoint, byte[] MyBytes)
        {
            try
            {
                SendSerialLineToUIThreadDelegate uidel = new SendSerialLineToUIThreadDelegate(CallBackSerialtoUIThread);
                object[] o = new object[1];
                o[0] = MountPoint;
                o[1] = MyBytes;
                Invoke(uidel, o);
            }
            catch (Exception)
            {
            }
        }
        delegate void SendSerialLineToUIThreadDelegate(string MountPoint, byte[] MyBytes);
        public void CallBackSerialtoUIThread(string MountPoint, byte[] MyBytes)
        {
            SerialReceivedByteCount += MyBytes.Length;
            lblSerialStatus.Text = "Received " + System.Convert.ToString(SerialReceivedByteCount) + " bytes.";
            SendSerialBytesToCasterThread(MountPoint, MyBytes);
        }
        public void SendSerialBytesToCasterThread(string MountPoint, byte[] bytes)
        {
            try
            {
                SendSerialBytesToCasterThreadDelegate uidel = new SendSerialBytesToCasterThreadDelegate(PropagateStreamData);
                object[] o = new object[2];
                o[0] = MountPoint;
                o[1] = bytes;
                Invoke(uidel, o);
            }
            catch (Exception)
            {
            }
        }
        delegate void SendSerialBytesToCasterThreadDelegate(string MountPoint, byte[] bytes);

        public void StartServer() //This gets called by a button on another form.
        {
            if (listener != null)
            {
                StopServer();
            }

            try
            {
                listener = new TcpListener(ip, port);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            stopFlag = false;
            SendStuffToUIThread(0, 0, "0"); //Report no connections

            listenerThread = new System.Threading.Thread(new System.Threading.ThreadStart(DoListen));
            listenerThread.Start();

            Thread processThread = new Thread(new System.Threading.ThreadStart(ProcessQueues));
            processThread.Start();
        }
        public void StopServer() //This gets called by a button on another form, and on form close.
        {
            //To reuse a socket, call Disconnect(true) instead of Close(). Close will release all the socket resources.
            //It's recommended to call Shutdown() before Disconnect to allow all data to be sent and received.
            stopFlag = true;

            if (listener != null)
            {
                try
                {
                    listener.Stop(); //Causes DoListen() to abort
                }
                catch
                {
                }
            }

            try
            {
                if (socket != null && socket.Connected)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Disconnect(true);
                }

                if (!(listenerThread == null))
                {
                    listenerThread.Abort();
                }
            }
            catch (Exception)
            {
            }

            SendStuffToUIThread(0, 0, "0"); //Report no connections
        }
        private void DoListen()
        {
            ClientContext context = default(ClientContext);
            Socket socket = default(Socket);

            listener.Start(); //Start listening

            SendStuffToUIThread(-1, 0, "Caster正在监听端口" + port); //Request Mountpoint

            try //The try block is merely to exit gracefully when you stop listening
            {
                do //Loop to handle multiple connections
                {
                    socket = listener.AcceptSocket(); //AcceptSocket blocks until a connection is established
                    if (!(socket == null)) //can't hurt to double-check
                    {
                        int ConnectionCount = -1;
                        lock (clients) //lock the list and add the ClientContext
                        {
                            context = new ClientContext(socket); //create a new context
                            clients.Add(context); //Add it to the list
                            ConnectionCount = clients.Count;
                        }
                        if (ConnectionCount > -1)
                        {
                            SendStuffToUIThread(0, 0, clients.Count.ToString());
                        }
                    }
                } while (true);
            }
            catch
            {
            }
        }
        private void ProcessQueues()
        {
            byte[] buffer = new byte[1024];
            int len = 0;
            do
            {
                //-- Get a lock on the entire collection
                lock (clients)
                {
                    foreach (ClientContext client in clients)
                    {
                        if (client.IsConnected() == false) //Is the socket connected
                        {
                            client.RemoveFlag = true;
                        }
                        else
                        {
                            //-- Process outgoing messages.
                            if (client.SendQueue.Count > 0) //Is there an item to send
                            {
                                lock (client.SendQueue.Peek()) //Get a lock on the outgoing byte array
                                {
                                    byte[] bytes = (byte[])(client.SendQueue.Dequeue()); //Retrieve the byte array
                                    try //Try sending
                                    {
                                        client.Socket.Send(bytes, bytes.Length, SocketFlags.None);
                                    }
                                    catch (System.Net.Sockets.SocketException)
                                    {
                                        client.RemoveFlag = true; //The socket has disconnected. Mark it for death.
                                    }
                                }
                            }
                            else
                            {
                                if (client.RemoveAfterSend) //Send Queue is now empty, kill connection
                                {
                                    client.RemoveFlag = true;
                                }
                            }
                            lock (stopSyncObj) //Are we stopped
                            {
                                if (stopFlag == true)
                                {
                                    goto endOfDoLoop;
                                }
                            }

                            //Process incoming messages
                            if (client.RemoveFlag == false)
                            {
                                if (client.Socket != null) //Do we have a socket
                                {
                                    if (client.FirstTime)
                                    {
                                        SendStuffToUIThread(1, client.ConnID, client.Socket.RemoteEndPoint.ToString()); //Add ID to the users table on the UI thread
                                        client.FirstTime = false;
                                    }

                                    if (client.Socket.Poll(10, SelectMode.SelectRead) == true) //Did we receive data
                                    {
                                        try //Try reading from the socket
                                        {
                                            len = client.Socket.Receive(buffer, buffer.Length, SocketFlags.None); //len returns the number of bytes received
                                            if (len > 0) //Data was received.
                                            {
                                                byte[] bytes = new byte[len - 1 + 1];
                                                Array.Copy(buffer, bytes, len); //Copy to another buffer

                                                if (client.ConnLevel == 2) //This is a server sending in data
                                                {
                                                    PropagateStreamData(client.MountPoint, bytes);
                                                }
                                                else if (client.ConnLevel == 1) //This is a client, and we don't care about the data.
                                                {
                                                    string data = Encoding.ASCII.GetString(bytes).Replace("\n", "");
                                                    ProcessMessages(client, data.Trim());
                                                }
                                                else //Not authenticated yet, process data
                                                {
                                                    //Decode data and append to incoming buffer
                                                    client.IncomingData += Encoding.ASCII.GetString(bytes).Replace("\n", "");
                                                    if (client.IncomingData.IndexOf(('\r').ToString()) >= 0) //Contains at least one carridge return
                                                    {
                                                        string[] lines = Strings.Split(client.IncomingData, System.Convert.ToString('\r'));
                                                        for (var i = 0; i <= (lines.Length - 1) - 1; i++)
                                                        {
                                                            ProcessMessages(client, lines[(int)i].Trim());
                                                        }
                                                        client.IncomingData = lines[lines.Length - 1];
                                                    }
                                                    else //Data doesn't contain any line breaks
                                                    {
                                                        if (client.IncomingData.Length > 4000)
                                                        {
                                                            client.IncomingData = ""; //Clean out stale data
                                                        }
                                                    }
                                                }

                                            }
                                        }
                                        catch (System.Net.Sockets.SocketException)
                                        {
                                            client.RemoveFlag = true; //The socket has disconnected. Mark it for death
                                        }
                                    }
                                }
                            }

                            lock (stopSyncObj)
                            {
                                if (stopFlag == true) //Are we stopped
                                {
                                    goto endOfDoLoop;
                                }
                            }
                        }

                        Thread.Sleep(10); //To prevent CPU overload
                    }
                }

                lock (clients) //Remove any dead sockets
                {
                    bool removed = false;
                    int curCount = clients.Count;
                    do
                    {
                        removed = false;
                        for (int i = 0; i <= clients.Count - 1; i++)
                        {
                            if (((ClientContext)(clients[i])).RemoveFlag == true)
                            {
                                try
                                {
                                    SendStuffToUIThread(2, ((ClientContext)(clients[i])).ConnID, null); //Remove ID from the connections table on the UI thread

                                    ((ClientContext)(clients[i])).Socket.Shutdown(SocketShutdown.Both);
                                    ((ClientContext)(clients[i])).Socket.Close();
                                    clients.Remove(clients[i]);
                                    removed = true;
                                }
                                catch (System.Net.Sockets.SocketException e)
                                {
                                    SendStuffToUIThread(-1, ((ClientContext)(clients[i])).ConnID, "Socket错误！");
                                }
                                break;
                            }
                        }
                    } while (!(removed == false));
                    if (clients.Count != curCount) //Client count changed
                    {
                        SendStuffToUIThread(0, 0, clients.Count.ToString());
                    }
                }

                lock (stopSyncObj)
                {
                    if (stopFlag == true) //Are we stopped
                    {
                        break;
                    }
                }

                Thread.Sleep(10);
            } while (true);
        endOfDoLoop:
            1.GetHashCode(); //VBConversions note: C# requires an executable line here, so a dummy line was added.
        }
        private void PropagateStreamData(string MountPoint, byte[] bytes)
        {
            SendStuffToUIThread(99, bytes.Length, MountPoint);
            foreach (ClientContext client in clients)
            {
                if (client.MountPoint == MountPoint && client.ConnLevel == 1)
                {
                    client.SendQueue.Enqueue(bytes);
                }
            }
        }


        private void SendMessage(string response, ClientContext sender)
        {
            sender.SendQueue.Enqueue(ASCIIEncoding.ASCII.GetBytes(response + "\r\n"));
        }
        private void ProcessMessages(ClientContext sender, string Message)
        {
            if (Message.StartsWith("GET "))
            {
                string mp = Message.Substring(4);
                mp = mp.Substring(0, mp.IndexOf(" "));
                if (mp.Substring(0, 1) == "/")
                {
                    mp = mp.Substring(1);
                }
                SendStuffToUIThread(3, sender.ConnID, mp); //Request Mountpoint
            }
            else if (Message.StartsWith("User-Agent: NTRIP "))
            {
                SendStuffToUIThread(4, sender.ConnID, Message.Replace("User-Agent: NTRIP ", "")); //Update User Agent
            }
            else if (Message.StartsWith("Authorization: Basic "))
            {
                SendStuffToUIThread(5, sender.ConnID, Message.Replace("Authorization: Basic ", "")); //Login
            }
            else if (Message.StartsWith("SOURCE ")) //Request ability to send stream
            {
                SendStuffToUIThread(6, sender.ConnID, Message.Replace("SOURCE ", ""));
            }
            else if (Message.StartsWith("Source-Agent: NTRIP "))
            {
                SendStuffToUIThread(4, sender.ConnID, Message.Replace("Source-Agent: NTRIP ", "")); //Update User Agent
            }
            else if (Message.StartsWith("$GPGGA") || Message.StartsWith("$GNGGA") || Message.StartsWith("BDGGA"))
            {
                SendStuffToUIThread(7, sender.ConnID, Message);
            }
            else
            {
                //Some other message that we don't care about
            }
        }


        private void SendStuffToSocketsThread(int ConnID, string Message, bool Disconnect, int NewStatus)
        {
            try
            {
                SendStuffToSocketsThreadDelegate uidel = new SendStuffToSocketsThreadDelegate(SendBackToClient);
                object[] o = new object[4];
                o[0] = ConnID;
                o[1] = Message;
                o[2] = Disconnect;
                o[3] = NewStatus;
                Invoke(uidel, o);
            }
            catch (Exception)
            {
            }
        }
        delegate void SendStuffToSocketsThreadDelegate(int ConnID, string Message, bool Disconnect, int NewStatus);
        public void SendBackToClient(int ConnID, string Message, bool Disconnect, int NewStatus)
        {
            //SyncLock clients
            string tempmp = "";
            foreach (ClientContext client in clients)
            {
                if (client.ConnID == ConnID)
                {
                    if (NewStatus == 3) //Means the message is the mountpoint
                    {
                        client.MountPoint = Message;
                    }
                    else
                    {
                        client.SendQueue.Enqueue(ASCIIEncoding.ASCII.GetBytes(Message + "\r\n"));
                        if (Disconnect)
                        {
                            client.RemoveAfterSend = true;
                        }
                        if (NewStatus > 0)
                        {
                            client.ConnLevel = NewStatus;
                            if (NewStatus == 2)
                            {
                                tempmp = client.MountPoint;
                            }
                        }
                    }
                }
            }
            if (NewStatus == 2 & tempmp.Length > 0) //this is a server sending data in, disconnect all other servers with same mountpoint
            {
                foreach (ClientContext client in clients)
                {
                    if (!(client.ConnID == ConnID))
                    {
                        if (client.MountPoint == tempmp && client.ConnLevel == 2)
                        {
                            client.RemoveFlag = true;
                        }
                    }
                }
            }
            //End SyncLock
        }

        private void SendStuffToUIThread(int Action, int ConnID, string Message)
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
                case -1: //On start up, list IP and port
                    LogEvent(Message);
                    break;
                case 0: //Connection count change
                    lblStatusBar.Text = "Connections: " + Message;
                    break;
                case 1: //Register user
                    dtconnections.Rows.Add(ConnID, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), "", "", 0);
                    break;
                case 2: //UnRegister user
                    for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                    {
                        if ((int)dtconnections.Rows[ctr]["ID"] == ConnID)
                        {
                            //If dtconnections.Rows(ctr).Item("Bytes") > 0 Then
                            LogEvent("Connection ID " + System.Convert.ToString(ConnID) + " - 用户 " + dtconnections.Rows[ctr]["用户名"] +
                                " 断开连接.");
                            //End If
                            dtconnections.Rows[ctr].Delete();
                        }
                    }
                    break;
                case 3: //Request Mountpoint
                    bool FoundMP_1 = false;
                    for (int ctr = dtmountpoints.Rows.Count - 1; ctr >= 0; ctr--)
                    {
                        if (dtmountpoints.Rows[ctr]["接入点"].ToString() == Message)
                        {
                            FoundMP_1 = true;
                        }
                    }

                    if (!FoundMP_1)
                    {
                        LogEvent("Connection ID " + System.Convert.ToString(ConnID) + " - 接入点 " + Message +
                            " 不存在或未启动 ");
                        Message = "Sending SourceTable";
                    }

                    for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                    {
                        if ((int)dtconnections.Rows[ctr]["ID"] == ConnID)
                        {
                            dtconnections.Rows[ctr]["接入点"] = Message;
                        }
                    }

                    if (FoundMP_1)
                    {
                        SendStuffToSocketsThread(ConnID, Message, false, 3);
                    }
                    else
                    {
                        GenerateAndSendSourceTable(ConnID);
                    }
                    break;

                case 4: //Update User Agent
                    for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                    {
                        if ((int)dtconnections.Rows[ctr]["ID"] == ConnID)
                        {
                            //dtconnections.Rows[ctr]["UA"] = Message;
                        }
                    }
                    break;

                case 5: //Login
                    for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                    {
                        if ((int)dtconnections.Rows[ctr]["ID"] == ConnID)
                        {
                            if (dtconnections.Rows[ctr]["接入点"].ToString().Length > 0) //A mountpoint was specified
                            {
                                DecryptLoginInfo(ConnID, Message);
                            }
                        }
                    }
                    break;

                case 6: //A server sending in the password and mount point
                    bool FoundMP = false;
                    bool GoodPassword = false;

                    string mountpoint = "";
                    if (Message.Contains(" "))
                    {
                        int firstspace = Message.IndexOf(" ");
                        if (Message.Length > firstspace + 2)
                        {
                            string password = Message.Substring(0, firstspace);
                            mountpoint = Message.Substring(firstspace + 2);
                            for (int ctr = dtmountpoints.Rows.Count - 1; ctr >= 0; ctr--)
                            {
                                if (dtmountpoints.Rows[ctr]["MountPoint"].ToString() == mountpoint)
                                {
                                    FoundMP = true;
                                    if (dtmountpoints.Rows[ctr]["密码"].ToString() == password)
                                    {
                                        GoodPassword = true;
                                    }
                                }
                            }
                        }
                    }
                    if (!FoundMP)
                    {
                        mountpoint = "NonExistant";
                    }
                    for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                    {
                        if ((int)dtconnections.Rows[ctr]["ID"] == ConnID)
                        {
                            dtconnections.Rows[ctr]["MountPoint"] = mountpoint;
                        }
                    }
                    if (FoundMP)
                    {
                        if (GoodPassword)
                        {
                            for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                            {
                                if ((int)dtconnections.Rows[ctr]["ID"] == ConnID)
                                {
                                    dtconnections.Rows[ctr]["开始时间"] = DateTime.Now.ToString();
                                    dtconnections.Rows[ctr]["用户名"] = "--SERVER--";
                                    LogEvent("Connection ID " + System.Convert.ToString(ConnID) + " - Server " + dtconnections.Rows[ctr]["地址"] + " is streaming to mountpoint " + mountpoint + ".");
                                }
                            }
                            SendStuffToSocketsThread(ConnID, mountpoint, false, 3);
                            SendStuffToSocketsThread(ConnID, "ICY 200 OK", false, 2);
                        }
                        else
                        {
                            SendStuffToSocketsThread(ConnID, "ERROR - Bad Password", true, 0);
                        }
                    }
                    else
                    {
                        SendStuffToSocketsThread(ConnID, "ERROR - Invalid MountPoint", true, 0);
                    }
                    break;

                case 7:
                    string[] aryNMEAString = Message.Split(',');
                    //LogEvent("Connection ID " + System.Convert.ToString(ConnID) + Message);
                    SharpGPS.NMEA.GPGGA gga = new SharpGPS.NMEA.GPGGA(Message);

                    string gpstype = "";
                    string shorttype = "";
                    if ((aryNMEAString.Length - 1) > 13) //we have at least 14 fields.
                    {
                        int InFixQuality = int.Parse(aryNMEAString[6]);
                        switch (InFixQuality)
                        {
                            case 1: //GPS fix (SPS)
                                gpstype = "GPS fix (No Differential Correction)";
                                shorttype = "单点解";
                                break;
                            case 2: //DGPS fix
                                gpstype = "DGPS";
                                shorttype = "差分解";
                                break;
                            case 3: //PPS fix
                                gpstype = "PPS Fix";
                                shorttype = "PPS";
                                break;
                            case 4: //Real Time Kinematic
                                gpstype = "RTK";
                                shorttype = "固定解";
                                break;
                            case 5: //Float RTK
                                gpstype = "Float RTK";
                                shorttype = "浮点解";
                                break;
                            case 6: //estimated (dead reckoning) (2.3 feature)
                                gpstype = "Estimated";
                                shorttype = "Estimated";
                                break;
                            case 7: //Manual input mode
                                gpstype = "Manual Input Mode";
                                shorttype = "Manual";
                                break;
                            case 8: //Simulation mode
                                gpstype = "Simulation";
                                shorttype = "Simulation";
                                break;
                            case 9: //WAAS
                                gpstype = "WAAS";
                                shorttype = "WAAS";
                                break;
                            default: //0 = invalid
                                gpstype = "Invalid";
                                shorttype = "无效解";
                                break;
                        }
                    }
                    else
                    {
                        shorttype = "无效解";
                    }
                    for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                    {
                        if ((int)dtconnections.Rows[ctr]["ID"] == ConnID)
                        {
                            dtconnections.Rows[ctr]["状态"] = shorttype;
                            dtconnections.Rows[ctr]["经度"] = gga.Position.X;
                            dtconnections.Rows[ctr]["纬度"] = gga.Position.Y;
                        }
                    }

                    break;
                case 99:
                    for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                    {
                        if (dtconnections.Rows[ctr]["接入点"].ToString() == Message && !(dtconnections.Rows[ctr]["用户名"].ToString() == ""))
                        {
                            dtconnections.Rows[ctr]["数据量(MB)"] = ((double)dtconnections.Rows[ctr]["数据量(MB)"] + (ConnID/1024.0/1024.0));
                        }
                    }
                    break;
            }
        }

        public void GenerateAndSendSourceTable(int ConnID)
        {
            string sourceTable = sourceHeader + MountPoistsList + sourceFoot;
            SendStuffToSocketsThread(ConnID, sourceTable, true, 0);

            //Remove client from the list
            for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
            {
                if ((int)dtconnections.Rows[ctr]["ID"] == ConnID)
                {
                    if ((int)dtconnections.Rows[ctr]["数据量(MB)"] > 0)
                    {
                        LogEvent("Connection ID " + System.Convert.ToString(ConnID) + " - 用户 " 
                            + dtconnections.Rows[ctr]["用户名"] + " 断开连接，已接收 " + dtconnections.Rows[ctr]["数据量(MB)"] + " MB.");
                    }
                    dtconnections.Rows[ctr].Delete();
                }
            }
        }
        public void DecryptLoginInfo(int ConnID, string Message)
        {
            bool LoginFound = false;
            string username = "";
            bool haveuser = false;

            if (Message.Length > 1)
            {
                //Decrypt info
                byte[] originalbytes = Convert.FromBase64String(Message);
                string originaltext = System.Text.Encoding.ASCII.GetString(originalbytes);
                if (originaltext.IndexOf(":") >= 0)
                {
                    //Check info
                    int colinlocation = originaltext.IndexOf(":");
                    if (originaltext.Length >= colinlocation + 1)
                    {
                        username = originaltext.Substring(0, colinlocation);
                        string password = originaltext.Substring(colinlocation + 1);


                        for (int ctr = dtusers.Rows.Count - 1; ctr >= 0; ctr--)
                        {
                            if (dtusers.Rows[ctr]["用户名"].ToString() == username
                                && dtusers.Rows[ctr]["密码"].ToString() == password
                                && DateTime.Parse(dtusers.Rows[ctr]["过期时间"].ToString()) > DateTime.Now)
                            {
                                LoginFound = true;
                                haveuser = true;
                            }
                            else
                            {
                                if (dtusers.Rows[ctr]["用户名"].ToString() == username
                                && dtusers.Rows[ctr]["密码"].ToString() != password)
                                {
                                    haveuser = true;
                                    LogEvent("Connection ID " + System.Convert.ToString(ConnID) + " - 用户 " + username + " 断开连接,密码验证错误");
                                }
                                if (dtusers.Rows[ctr]["用户名"].ToString() == username
                               && DateTime.Parse(dtusers.Rows[ctr]["过期时间"].ToString()) < DateTime.Now)
                                {
                                    haveuser = true;
                                    LogEvent("Connection ID " + System.Convert.ToString(ConnID) + " - 用户 " + username + " 断开连接,用户已过期");
                                }
                            }
                        }
                        if (!haveuser)
                        {
                            LogEvent("Connection ID " + System.Convert.ToString(ConnID) + " - 用户 " + username + " 不存在");
                        }
                        for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                        {
                            if (dtconnections.Rows[ctr]["用户名"].ToString() == username && !string.IsNullOrEmpty(username))
                            {
                                for (int i = 0; i <= clients.Count - 1; i++)
                                {
                                    if (((ClientContext)(clients[i])).ConnID.ToString() == dtconnections.Rows[ctr]["ID"].ToString())
                                    {
                                        //((ClientContext)(clients[i])).RemoveFlag = true;
                                        ////LoginFound = false;
                                        //LogEvent("Connection ID " + System.Convert.ToString(ConnID) + " - 用户 " + username + " 已登录,被强制下线！");
                                    }

                                }
                              
                            }
                        }

                        int stophere = 0;
                    }
                }
            }

            if (LoginFound)
            {
                LogEvent("Connection ID " + System.Convert.ToString(ConnID) + " - 用户 " + username + " 登录成功");
                for (int ctr = dtconnections.Rows.Count - 1; ctr >= 0; ctr--)
                {
                    if ((int)dtconnections.Rows[ctr]["ID"] == ConnID)
                    {
                        //dtconnections.Rows(ctr).Item("Start Time") = Now.ToString
                        dtconnections.Rows[ctr]["用户名"] = username;
                    }
                }
                SendStuffToSocketsThread(ConnID, "ICY 200 OK", false, 1);
                LogEvent("Connection ID " + System.Convert.ToString(ConnID) + " - 用户 " + username + " 已连接.");

            }
            else //Oops, send back a fail message
            {
                SendStuffToSocketsThread(ConnID, "401 Unauthorized", true, 0);
            }
        }



        public string CalculateChecksum(string sentence)
        {
            // Calculates the checksum for a sentence
            // Loop through all chars to get a checksum
            char Character = '\0';
            int Checksum = 0;
            foreach (char tempLoopVar_Character in sentence)
            {
                Character = tempLoopVar_Character;
                switch (Character)
                {
                    case '$':
                        break;
                    // Ignore the dollar sign
                    case '*':
                        // Stop processing before the asterisk
                        goto endOfForLoop;
                    default:
                        // Is this the first value for the checksum
                        if (Checksum == 0)
                        {
                            // Yes. Set the checksum to the value
                            Checksum = Convert.ToByte(Character);
                        }
                        else
                        {
                            // No. XOR the checksum with this character's value
                            Checksum = Checksum ^ Convert.ToByte(Character);
                        }
                        break;
                }
            }
        endOfForLoop:
            // Return the checksum formatted as a two-character hexadecimal
            return Checksum.ToString("X2");
        }
    }



    public class ClientContext
    {
        private Socket _socket;
        public bool FirstTime = true;
        public int ConnID = 0;
        public string IncomingData = "";
        public int ConnLevel = 0;
        public string MountPoint = "";
        public bool RemoveAfterSend = false;

        public ClientContext(Socket Socket)
        {
            _socket = Socket;
            FirstTime = true;
            CasterForm.ConnIDCount++;
            ConnID = CasterForm.ConnIDCount;
            IncomingData = "";
            ConnLevel = 0;
            MountPoint = "";
            RemoveAfterSend = false;
        }
        public Socket Socket
        {
            get
            {
                return _socket;
            }
        }


        private Queue _sendQueue;
        public Queue SendQueue
        {
            get
            {
                if (_sendQueue == null)
                {
                    _sendQueue = new Queue();
                }
                return _sendQueue;
            }
        }



        private bool _removeFlag;
        public bool RemoveFlag
        {
            get
            {
                return _removeFlag;
            }
            set
            {
                _removeFlag = value;
            }
        }


        public bool IsConnected()
        {
            bool connected = false;
            try
            {
                connected = !(Socket.Poll(1, SelectMode.SelectRead) && (Socket.Available == 0));
                bool blockingState = Socket.Blocking;
                try
                {
                    byte[] tmp = new byte[1];

                    Socket.Blocking = false;
                    Socket.Send(tmp, 0, 0);
                }
                catch (SocketException e)
                {
                    // 10035 == WSAEWOULDBLOCK
                    if (e.NativeErrorCode.Equals(10035))
                    {
                        //Console.WriteLine("Still Connected, but the Send would block");
                    }
                    else
                    {
                        //Console.WriteLine("Disconnected: error code {0}!", e.NativeErrorCode);
                        connected = false;
                    }
                }
                finally
                {
                    Socket.Blocking = blockingState;
                }
            }
            catch
            {
            }
            return connected;
        }


        public void SendNow(string message)
        {
            try
            {
                if (Socket != null)
                {
                    if (IsConnected())
                    {
                        byte[] bytes = System.Text.ASCIIEncoding.ASCII.GetBytes(message);
                        Socket.Send(bytes, bytes.Length, SocketFlags.None);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
