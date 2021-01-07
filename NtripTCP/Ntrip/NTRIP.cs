using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using SharpGPS;
using SharpGPS.NTRIP;
using SharpGPS.NMEA;
using System.Threading;
using NtripClient;
using System.Runtime.InteropServices;
using System.Linq.Expressions;

namespace NtripShare.NTRIP
{

    public class NClient : IDisposable
    {
        private Socket sckt;
        private IPEndPoint _broadcaster;
        byte[] rtcmDataBuffer = new byte[10240];
        public AsyncCallback pfnCallBack;
        private bool isStart = false;
        string Username;
        string Password;
        string MountPoint;
        public string MostRecentGGA { get; set; }


        /// <summary>
        /// NTRIP Server
        /// </summary>
        public IPEndPoint BroadCaster
        {
            get { return _broadcaster; }
            set { _broadcaster = value; }
        }


        public NClient(IPEndPoint iPEndPoint, string username,string password,string mountPoint)
        {
            Username = username;
            Password = password;
            MountPoint = mountPoint;
            //System.Net.IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            //gps = gpsHandler;
            BroadCaster = iPEndPoint;
        }

        private void InitializeSocket()
        {
            sckt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }


        /// <summary>
        /// Creates request to NTRIP server
        /// </summary>
        /// <param name="strRequest">Resource to request. Leave blank to get NTRIP service data</param>
        private byte[] CreateRequest(string strRequest)
        {
            //Build request message
            string msg = "GET /" + strRequest + " HTTP/1.1\r\n";
            msg += "User-Agent: SharpGps iter.dk\r\n";
            //If password/username is specified, send login details
            if (Username != null && Username != "")
            {
                string auth = ToBase64(Username + ":" + Password);
                msg += "Authorization: Basic " + auth + "\r\n";
            }
            msg += "Accept: */*\r\nConnection: close\r\n";
            msg += "\r\n";

            return System.Text.Encoding.ASCII.GetBytes(msg);
        }

        private void Connect()
        {
            try
            {
                if (!sckt.Connected)
                    sckt.Connect(BroadCaster);
            }
            catch (Exception e) { 
            
            }
            //Connect to server	   
          
        }

        private void Close()
        {
            sckt.Shutdown(SocketShutdown.Both);
            sckt.Close();
        }

        /// <summary>
        /// 获取接入点列表
        /// </summary>
        /// <returns></returns>
        public SourceTable GetSourceTable()
        {
            this.InitializeSocket();
            sckt.Blocking = true;
            this.Connect();
            sckt.Send(CreateRequest(""));
            string responseData = "";
            System.Threading.Thread.Sleep(1000); //Wait for response
            while (sckt.Available > 0)
            {
                byte[] returndata = new byte[sckt.Available];
                sckt.Receive(returndata); //Get response
                responseData += System.Text.Encoding.ASCII.GetString(returndata, 0, returndata.Length);
                System.Threading.Thread.Sleep(100); //Wait for response
            }
            this.Close();

            if (!responseData.StartsWith("SOURCETABLE 200 OK"))
                return null;

            SourceTable result = new SourceTable();
            foreach (string line in responseData.Split('\n'))
            {
                if (line.StartsWith("STR"))
                    result.DataStreams.Add(SourceTable.NTRIPDataStream.ParseFromString(line));
                else if (line.StartsWith("CAS"))
                    result.Casters.Add(SourceTable.NTRIPCaster.ParseFromString(line));
                else if (line.StartsWith("NET"))
                    result.Networks.Add(SourceTable.NTRIPNetwork.ParseFromString(line));
            }
            return result;
        }

        /// <summary>
        /// Opens the connection to the NTRIP server and starts receiving
        /// </summary>
        public void StartNTRIP()
        {
            this.InitializeSocket();
            sckt.Blocking = true;
            isStart = true;
            this.Connect();
            sckt.Send(CreateRequest(MountPoint));
            //sckt.Blocking = false;
            //WaitForData(sckt);
            Thread processThread = new Thread(new ThreadStart(WaitForData));
            processThread.Start();
            NtripForm.Default.LogEvent("启动Ntrip客户端，IP" + BroadCaster.Address.ToString() + ",端口：" + BroadCaster.Port + ",接入点：" +MountPoint);
        }

        /// <summary>
        /// 接收数据流循环
        /// </summary>
        /// <param name="sock"></param>
        public void WaitForData()
        {
            while (true)
            {
                if (!IsConnected())
                {
                    break;
                }
                if (!sckt.Connected)
                {
                    return;
                }
                try
                {
                    if (sckt.Available == 0) {
                        continue;
                    }
                    sckt.Blocking = true;
                    byte[] recvBytes = new byte[10240];
                    int len = sckt.Receive(recvBytes, recvBytes.Length, 0); //从客户端接受消息

                    if (len > 0 ) //Data was received.
                    {
                        byte[] bytes = new byte[len];
                        Array.Copy(recvBytes, bytes, len);
                        string responseData = System.Text.Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                        if (responseData.Contains("401 Unauthorized")) {
                            NtripForm.Default.LogToUIThread(0, "Ntrip客户端失败，用户名或密码错误，IP" + BroadCaster.Address + ",端口：" + BroadCaster.Port + ",接入点：" + MountPoint);
                            //NtripForm.Default.LogToUIThread(99,  bytes);
                        }
                        else if (responseData.Contains("ICY 200 OK")) 
                        {
                            NtripForm.Default.LogToUIThread(0, "Ntrip客户端登录验证成功，IP" + BroadCaster.Address + ",端口：" + BroadCaster.Port + ",接入点：" + MountPoint);
                        }
                        else if (responseData.Contains("SOURCETABLE 200 OK"))
                        {
                            NtripForm.Default.LogToUIThread(0,"Ntrip客户端获取接入点成功，IP" + BroadCaster.Address + ",端口：" + BroadCaster.Port + ",接入点：" + MountPoint);
                        }
                        else {
                            NtripForm.Default.NtripUpdateUIThread(3,bytes);
                        }

                    }
                }
                catch (Exception e)
                {
                    NtripForm.Default.LogToUIThread(0, "接收数据错误，" + e.Message);
                }
                Thread.Sleep(1000);
            }
        }


        /// <summary>
        /// 发送gga
        /// </summary>
        public void sendGGA()
        {
            if (!isStart)
            {
                return;
            }
            byte[] nmeadata = System.Text.Encoding.ASCII.GetBytes(MostRecentGGA + "\r\n");
            try
            {
                sckt.Send(nmeadata);
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Stops receiving data from the NTRIP server
        /// </summary>
        public void StopNTRIP()
        {
            isStart = false;
            this.Close();
            NtripForm.Default.LogEvent("关闭Ntrip数据接收 ");

        }

        /// <summary>
        /// Apply AsciiEncoding to user name and password to obtain it as an array of bytes
        /// </summary>
        /// <param name="str">username:password</param>
        /// <returns>Base64 encoded username/password</returns>
        private string ToBase64(string str)
        {
            Encoding asciiEncoding = Encoding.ASCII;
            byte[] byteArray = new byte[asciiEncoding.GetByteCount(str)];
            byteArray = asciiEncoding.GetBytes(str);
            return Convert.ToBase64String(byteArray, 0, byteArray.Length);
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.Close();
        }

        /// <summary>
        /// 计算是否处于连接状态
        /// </summary>
        /// <returns></returns>
        public bool IsConnected()
        {
            bool connected = false;
            if (sckt == null) {
                return false;
            }
            try
            {
                connected = !(sckt.Poll(1, SelectMode.SelectRead) && (sckt.Available == 0));
                bool blockingState = sckt.Blocking;
                try
                {
                    byte[] tmp = new byte[1];

                    sckt.Blocking = false;
                    sckt.Send(tmp, 0, 0);
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
                    sckt.Blocking = blockingState;
                }
            }
            catch
            {
            }
            return connected;
        }
        #endregion
    }
}