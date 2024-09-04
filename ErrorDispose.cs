using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

//using System.Windows.Forms;

namespace WhyfdrCamera
{

    struct ErrorCfg
    {
        public int nErrType;          // 错误类型，1-提示，2-警告，3-错误
        public string strEventType;    // 所属事件类型，如“init”，“motion"
        public string strContent;      // 内容
    }

    struct ErrorLog
    {
        public int iErrorID;           // 
        public int nErrType;           // 错误类型，1-提示，2-警告，3-错误
        public string strEventType;    // 所属事件类型，如“init”，“motion"
        public string strContent;      // 内容
        public string strTime;         // 抛出报警的时间
    }

    class ErrorDispose
    {
        //                 错误码   对应的错误内容
        public  Dictionary<int,     ErrorCfg> mapErrCfg = new Dictionary<int, ErrorCfg>();

        //                 错误码   b报警记录
        //private Dictionary<int, ErrorLog> mapErrLog = new Dictionary<int, ErrorLog>();

        private List<ErrorLog> listTmpErr = new List<ErrorLog>();  // 记录最新的50条报警，用于显示


        private string strLogPath = System.IO.Directory.GetCurrentDirectory() + "\\Log\\";
        private string strProgLogPath = System.IO.Directory.GetCurrentDirectory() + "\\ProgLog\\";
        private object m_lock = new object();

        public ErrorDispose()
        {
            LoadErrorCfg();
        }

        // 单例模式
        public static ErrorDispose instance;
        public static ErrorDispose getInstance()
        {
            if (instance == null)
            {
                instance = new ErrorDispose();

            }
            return instance;
        }
        /// <summary>
        /// 
        /// </summary>
        public void LoadErrorCfg()
        {
            mapErrCfg.Clear();

            //读取文件的位置
            string readPath = System.IO.Directory.GetCurrentDirectory() + "\\SysCfg\\Error.ini";
            //存储文件的位置及名字
            //  string writePath = this.textBox1.Text.Trim();
            //按行读取txt
            string[] lines = File.ReadAllLines(readPath, System.Text.Encoding.Default);
            foreach (var item in lines)
            {
                //分割数据
                string[] str = item.Split(new char[] { '|' });

                if (str.Length < 4)
                {
                    continue;
                }
                //得到目标数据
                int nErrID = GlobalMethod.getInstance().StringToInt(str[0], 0);
                ErrorCfg errCfg;
                errCfg.nErrType = GlobalMethod.getInstance().StringToInt(str[1], 0);
                errCfg.strEventType = str[2];   
                errCfg.strContent = str[3];

                mapErrCfg.Add(nErrID,errCfg);
            }
        }
        /// <summary>
        /// 创建一个txt写入流
        /// </summary>
        /// <param name="path">写文件路径</param>
        /// <returns>StreamWriter对象</returns>
        private static StreamWriter CreateAppendTxt(string path)
        {
            FileInfo myFile = new FileInfo(path);
            StreamWriter sw = myFile.AppendText();
            return sw;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nCode"></param>
        public void AddErrLog(int nCode,string Inf)
        {
            lock (m_lock)
            {
                // 找到对应的错误信息
                ErrorCfg errCfg;
                if (mapErrCfg.ContainsKey((int)nCode))
                {
                    errCfg = mapErrCfg[(int)nCode];
                }
                else
                {
                    errCfg.nErrType = (int)ErrorType.ET_ERROR;
                    errCfg.strEventType = GlobalDefine.getInstance().ERR_EVENT_LOG;
                    errCfg.strContent = "con not find error id :" + Inf;
                }
               
                // 存入list
                ErrorLog errLog;
                errLog.iErrorID = nCode;
                errLog.nErrType = errCfg.nErrType;
                errLog.strEventType = errCfg.strEventType;
                errLog.strContent = errCfg.strContent;
                errLog.strTime = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.TimeOfDay.ToString();

                if (listTmpErr.Count >= 50)
                {
                    listTmpErr.RemoveRange(0, listTmpErr.Count - 50);
                }
                listTmpErr.Add(errLog);

                MainForm.m_MainForm.fALAMHMI(GetErrorType(errLog.nErrType), (uint)errLog.nErrType, errLog.iErrorID);

                // 写入文件 
                string writePath = strLogPath + DateTime.Now.Year.ToString() +
                    "\\" + DateTime.Now.Month.ToString();

                if (!Directory.Exists(writePath))
                {
                    Directory.CreateDirectory(writePath);
                }

                writePath = writePath + "\\" + DateTime.Now.Day.ToString() + ".txt";
                StreamWriter sw = CreateAppendTxt(writePath);
                sw.WriteLine(errLog.strTime + "|" + errLog.iErrorID + "|" + errLog.nErrType + "|" +
                    errLog.strEventType + "|" + errLog.strContent);
                sw.Close();

                //AddProgErrLog(strProgLogPath,errCfg.strContent);
                LogControl.m_LogControl.fUpdateList();
                // 如果是严重报警，峰鸣，红灯
                if (errCfg.nErrType == (int)ErrorType.ET_ERROR)
                {
                    // HandleMotion.getInstance().Output((int)MotionInput.MI_REDLIGHT, 1);
                    //HandleMotion.getInstance().Output((int)MotionInput.MI_BUZZER, 1);
                }

                // 关闭峰鸣
                Task t = new Task(() =>
                {
                    for (int i = 0; i < 5; ++i)
                    {
                        System.Threading.Thread.Sleep(1000);
                    }
                    //HandleMotion.getInstance().Output((int)MotionInput.MI_BUZZER, 0);
                });
                t.Start();
            }           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strInfo"></param>
        public void AddProgErrLog(string LogPath,string strInfo)
        {
            // 写入文件
            string writePath = LogPath + DateTime.Now.Year.ToString() +
                "\\" + DateTime.Now.Month.ToString();

            if (!Directory.Exists(writePath))
            {
                Directory.CreateDirectory(writePath);
            }

            writePath = writePath + "\\" + DateTime.Now.Day.ToString() + ".txt";
            StreamWriter sw = CreateAppendTxt(writePath);

            string strTime = DateTime.Now.ToShortDateString().ToString() +" "+ DateTime.Now.TimeOfDay.ToString();
            sw.WriteLine(strTime + ":    " + strInfo);
            sw.Close();
        }

        /// <summary>
        /// 添加导出数据
        /// </summary>
        /// <param name="strInfo"></param>
        public void AddDataLog(string LogPath, string strInfo)
        {
            // 写入文件
            if (!Directory.Exists(LogPath))
            {
                Directory.CreateDirectory(LogPath);
            }

            string writePath = LogPath + "\\" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + 
                                DateTime.Now.Hour+ DateTime.Now.Minute + DateTime.Now.Second + ".txt";
            StreamWriter sw = CreateAppendTxt(writePath);

            string strTime = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.TimeOfDay.ToString();
            sw.WriteLine(strTime + ":    " + strInfo);
            sw.Close();
        }

        // 获取临时最新的50条报警
        public List<ErrorLog> GetNewLogList()
        {
            return listTmpErr;
        }

        // 获取某一天的日志信息
        public List<ErrorLog> GetLogByDate(int nYear, int nMonth, int nDay)
        {
            //读取文件的位置
            string readPath = strLogPath + nYear.ToString() +
                "\\" + nMonth.ToString() + "\\" + nDay.ToString() + ".txt"; 
            string[] lines={""};
            //按行读取txt
            try
            {
                lines = File.ReadAllLines(readPath, System.Text.Encoding.UTF8);
            }
            catch{
                
                lines[0] = DateTime.Now.ToString() +"|"+"-1"+"|"+"1"+"|"+"未知"+"|"+"找不到文件，请检查搜索条件是否有误！";
            }

            List<ErrorLog> listTmp =  new List<ErrorLog>();
            foreach (var item in lines)
            {
                //分割数据
                string[] str = item.Split(new char[] { '|' });
                //得到目标数据
                ErrorLog errLog;
                try
                {

                    errLog.iErrorID = GlobalMethod.getInstance().StringToInt(str[1], 0);
                    errLog.nErrType = GlobalMethod.getInstance().StringToInt(str[2], 0);
                    errLog.strEventType = str[3];
                    errLog.strContent = str[4];
                    errLog.strTime = str[0];
                }
                catch 
                {
                    errLog.iErrorID = -1;
                    errLog.nErrType = 1;
                    errLog.strEventType ="未知";
                    errLog.strContent = "读取异常";
                    errLog.strTime = DateTime.Now.ToString();
                }
                listTmp.Add(errLog);
            }
            return listTmp;
        }

        /// <summary>
        ///  定时删除三个月前的调试日志
        /// </summary>

        
        public void DeleteProgLog()
        {
            int nYear = DateTime.Now.Year;
            int nMonth = DateTime.Now.Month - 3;

            if (nMonth  <= 0 )
            {
                nMonth += 12;
                nYear -= 1;
            }

            // 删除月份文件夹
            for (int i = 1;i<= nMonth;++i )
            {
                GlobalMethod.getInstance().ClearDirectors(strProgLogPath + DateTime.Now.Year.ToString() + "\\" + i.ToString());
            }

            // 删除年文件夹
            for (int i = 2020; i < nYear; ++i)
            {
                GlobalMethod.getInstance().ClearDirectors(strProgLogPath + i.ToString());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void fSaveLogData(List<ErrorLog> ListDataLog)
        {
            ;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nErrType"></param>
        /// <returns></returns>
        public string GetErrorType(int nErrType)
        {
            if (nErrType == (int)ErrorType.ET_TIPS)
            {
                return "提示";
            }
            else if (nErrType == (int)ErrorType.ET_OPLOG)
            {
                return "操作记录";
            }
            else if (nErrType == (int)ErrorType.ET_ERROR)
            {
                return "报警";
            }

            return "报警";
        }
        
    }
}

