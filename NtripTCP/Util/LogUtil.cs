using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtripClient.Util
{
    class LogUtil
    {
        /// <summary>
                /// 锁对象
                /// </summary>
        private static object lockHelper = new object();


        /// <summary>
                /// 写error级别日志
                /// </summary>
                /// <param name="errorMessage">异常信息</param>
                /// <param name="ex">异常类</param>
        public static void WriteLog(string str)
        {
            if (!Directory.Exists("Log"))
            {
                Directory.CreateDirectory("Log");
            }

            using (var sw = new StreamWriter(@"Log\Log.txt", true))
            {
                sw.WriteLine(str);
                sw.WriteLine("---------------------------------------------------------");
                sw.Close();
            }
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="str"></param>
        public static void WriteErrorLog(string str)
        {
            try
            {
                if (!Directory.Exists("Log"))
                {
                    Directory.CreateDirectory("Log");
                }

                using (var sw = new StreamWriter(@"Log\ErrLog.txt", true))
                {
                    sw.WriteLine(str);
                    sw.WriteLine("---------------------------------------------------------");
                    sw.Close();
                }
            }
            catch (Exception e) {

            }
           
        }
    }
}
