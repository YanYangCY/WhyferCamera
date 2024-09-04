using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace WhyfdrCamera
{
    class GlobalMethod
    {
        public static GlobalMethod m_GlobalMethod; 
        public GlobalMethod()
        {
            m_GlobalMethod = this;
        }
        // 单例模式
        public static GlobalMethod instance;
        public static GlobalMethod getInstance()
        {
            if (instance == null)
            {
                instance = new GlobalMethod();

            }
            return instance;
        }

        #region 字符串转换数字
        //
        public double StringToDouble(string strValue, double Fail)
        {
            double result = Fail;
            if (strValue == null || strValue == "")
            {
                return result;
            }
            if (!Double.TryParse(strValue, out result))
            {
                result = Fail;
            }
            return result;
        }

        public float StringToFloat(string strValue, float Fail)
        {
            float result = Fail;
            if (strValue == null || strValue == "")
            {
                return result;
            }
            if (!float.TryParse(strValue, out result))
            {
                result = Fail;
            }
            return result;
        }

        public int StringToInt(string strValue, int Fail)
        {
            int result = Fail;
            if (strValue == null || strValue == "")
            {
                return result;
            }
            if (!Int32.TryParse(strValue, out result))
            {
                result = Fail;
            }
            return result;
        }

        public bool StringToBool(string strValue, bool Fail)
        {
            bool result = Fail;
            if (strValue == null || strValue == "")
            {
                return result;
            }
            if (!bool.TryParse(strValue, out result))
            {
                result = Fail;
            }
            return result;
        }

        #endregion

        // 删除文件夹
        public bool ClearDirectors(string strPath)
        {
            try
            {
                //去除文件夹和子文件的只读属性
                //去除文件夹的只读属性
                DirectoryInfo fileInfo = new DirectoryInfo(strPath);
                fileInfo.Attributes = FileAttributes.Normal & FileAttributes.Directory;

                //去除文件的只读属性
                File.SetAttributes(strPath, FileAttributes.Normal);

                //判断文件夹是否还存在
                if (Directory.Exists(strPath))
                {
                    foreach (string f in Directory.GetFileSystemEntries(strPath))
                    {
                        if (File.Exists(f))
                        {
                            //如果有子文件删除文件
                            File.Delete(f);
                            Console.WriteLine(f);
                        }
                        else
                        {
                            //循环递归删除子文件夹
                            ClearDirectors(f);
                        }
                    }

                    //删除空文件夹
                    Directory.Delete(strPath);
                }
                return true;
            }
            catch (Exception ex) // 异常处理
            {
                return false;
            }
        }

        #region 十六进制字符串转字节型
        /// <summary>
        /// 把十六进制字符串转换成字节型(方法1)
        /// </summary>
        /// <param name="InString"></param>
        /// <returns></returns>
        public static byte[] StringToByte(string InString)
        {
            string[] ByteStrings;
            ByteStrings = InString.Split(" ".ToCharArray());
            byte[] ByteOut;
            ByteOut = new byte[ByteStrings.Length];

            for (int i = 0; i <= ByteStrings.Length - 1; i++)
            {
                //ByteOut[i] = System.Text.Encoding.ASCII.GetBytes(ByteStrings[i]);
                ByteOut[i] = Byte.Parse(ByteStrings[i], System.Globalization.NumberStyles.HexNumber);
                //ByteOut[i] =Convert.ToByte("0x" + ByteStrings[i]);
            }

            return ByteOut;
        }

        /// <summary>
        /// 十六进制字节转十六进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string BytesToString(byte[] bytes)
        {
            string strRe = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; ++i)
                {
                    strRe += bytes[i].ToString("X2");
                }
            }

            return strRe;
        }
        #endregion

        #region CRC校验
        /// <summary>
        /// CRC校验
        /// </summary>
        /// <param name="data">校验数据</param>
        /// <returns>高低8位</returns>
        public static string CRCCalc(string data)
        {
            string[] datas = data.Split(' ');
            List<byte> bytedata = new List<byte>();

            foreach (string str in datas)
            {
                bytedata.Add(byte.Parse(str, System.Globalization.NumberStyles.AllowHexSpecifier));
            }
            byte[] crcbuf = bytedata.ToArray();
            //计算并填写CRC校验码
            int crc = 0xffff;
            int len = crcbuf.Length;
            for (int n = 0; n < len; n++)
            {
                byte i;
                crc = crc ^ crcbuf[n];
                for (i = 0; i < 8; i++)
                {
                    int TT;
                    TT = crc & 1;
                    crc = crc >> 1;
                    crc = crc & 0x7fff;
                    if (TT == 1)
                    {
                        crc = crc ^ 0xa001;
                    }
                    crc = crc & 0xffff;
                }
            }
            string[] redata = new string[2];
            redata[1] = Convert.ToString((byte)((crc >> 8) & 0xff), 16);
            redata[0] = Convert.ToString((byte)((crc & 0xff)), 16);
            return data + " " + redata[0] + " " + redata[1];
        }
        /// <summary>
        /// CRC校验
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static byte[] CRC16(byte[] bytes)
        {
            //计算并填写CRC校验码
            int crc = 0xffff;
            int len = bytes.Length;
            for (int n = 0; n < len; n++)
            {
                byte i;
                crc = crc ^ bytes[n];
                for (i = 0; i < 8; i++)
                {
                    int TT;
                    TT = crc & 1;
                    crc = crc >> 1;
                    crc = crc & 0x7fff;
                    if (TT == 1)
                    {
                        crc = crc ^ 0xa001;
                    }
                    crc = crc & 0xffff;
                }
            }

            var nl = bytes.Length + 2;
            //生成的两位校验码
            byte[] redata = new byte[2];
            redata[0] = (byte)((crc & 0xff));
            redata[1] = (byte)((crc >> 8) & 0xff);

            //重新组织字节数组
            var newByte = new byte[nl];
            for (int i = 0; i < bytes.Length; i++)
            {
                newByte[i] = bytes[i];
            }
            newByte[nl - 2] = (byte)redata[0];
            newByte[nl - 1] = redata[1];

            return newByte;
        }

        #endregion

        #region 超时检测
        public static T TimeOutCheck<T>(int ms, Func<T> func)
        {
            var wait = new ManualResetEvent(false);
            bool bRunOK = false;
            var task = Task.Run<T>(() =>
            {
               var result = func.Invoke();
               bRunOK = true;
               wait.Set();

               return result;
            });

            wait.WaitOne(ms);
            if (bRunOK)
            {
                return task.Result;
            }
            else
            {
                return default(T);
            }
        }
        #endregion


    }
}
