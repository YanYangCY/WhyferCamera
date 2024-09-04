using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WhyfdrCamera
{
    /// <summary>
    /// 变量信息
    /// </summary>
    /// 
    struct VarCfg 
    {
        public Int16 VarstyleID;
        public  string VarSection;
        public string VarName;
        public object VarDefault;//1:整形；2;布尔型；3：字符串型；4：实型
    }
    /// <summary>
    /// 
    /// </summary>
    class DataManage
    {
        public SysParamData SysParamData = new SysParamData();
        public DataCfg DataCfg = new DataCfg();
        //变量
        public  Dictionary<string, VarCfg> mapVarCfg = new Dictionary<string, VarCfg>();
        public  List<VarCfg> listVar = new List<VarCfg>();  // 记录所有变量信息
        public List<vecRecipe> WorktemCfg = new List<vecRecipe>();

        public InPut InPut = new InPut();
        public DataManage()
        {

        }
        // 单例模式
        public static DataManage instance;
        public static DataManage getInstance()
        {
            if (instance == null)
            {
                instance = new DataManage();

            }
            return instance;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nErrType"></param>
        /// <returns></returns>
        public string GetVarSection(int VarSection)
        {
            if (VarSection == (int)VarSecTion.AxisParam)
            {
                return "AxisParam";
            }
            else if (VarSection == (int)VarSecTion.CCDParam)
            {
                return "CCDParam";
            }
            else if (VarSection == (int)VarSecTion.Common)
            {
                return "Common";
            }
            else if (VarSection == (int)VarSecTion.LaserParam)
            {
                return "LaserParam";
            }
            return "Common";
        }
    }
    /// <summary>
    /// 变量配置
    /// </summary>
    /// 
    class DataCfg {

        //public DataCfg()
        //{
        //    //_filePath = System.IO.Directory.GetCurrentDirectory() + "\\SysCfg\\SysVar.ini";
        //    // LoadVarCfg();
        //}
        ///// <summary>
        ///// 储存变量
        ///// </summary>
        ///// <param name="VarSection"></param>
        ///// <param name="VarName"></param>
        ///// <param name="VarDefault"></param>
        //public void  SaveVarInf(int VarID,string VarSection,string VarName,object VarDefault)
        //{
        //    // 写入文件
        //    string writePath = System.IO.Directory.GetCurrentDirectory() + "\\SysCfg";
        //    if (!Directory.Exists(writePath))
        //    {
        //        Directory.CreateDirectory(writePath);
        //    }
        //    writePath = writePath + "\\SysVar.ini";
        //    StreamWriter sw = CreateAppendTxt(writePath);
        //    sw.WriteLine(VarID + "|" + VarSection + "|" + VarName + "|" + VarDefault);
        //    sw.Close();
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        //public void LoadVarCfg()
        //{
        //    DataManage.getInstance().mapVarCfg.Clear();
        //    //读取文件的位置
        //    string readPath = System.IO.Directory.GetCurrentDirectory() + "\\SysCfg\\SysVar.ini";
        //    //存储文件的位置及名字
        //    //  string writePath = this.textBox1.Text.Trim();
        //    //按行读取txt
        //    string[] lines = File.ReadAllLines(readPath, System.Text.Encoding.Default);
        //    foreach (var item in lines)
        //    {
        //        //分割数据
        //        string[] str = item.Split(new char[] { '|' });

        //        if (str.Length < 4)
        //        {
        //            continue;
        //        }
        //        //得到目标数据
        //        VarCfg VarCfgtem = new VarCfg();
        //        VarCfgtem.VarstyleID = Convert.ToInt16(str[0], 0);
        //        VarCfgtem.VarSection = str[1];
        //        VarCfgtem.VarName = str[2];
        //        VarCfgtem.VarDefault = null;
        //        DataManage.getInstance().mapVarCfg.Add(VarCfgtem.VarName, VarCfgtem);
        //    }
        //}
        ///// <summary>
        ///// 创建一个txt写入流
        ///// </summary>
        ///// <param name="path">写文件路径</param>
        ///// <returns>StreamWriter对象</returns>
        //private static StreamWriter CreateAppendTxt(string path)
        //{
        //    FileInfo myFile = new FileInfo(path);
        //    StreamWriter sw = myFile.AppendText();
        //    return sw;
        //}
    }
    /// <summary>
    /// 
    /// </summary>
    class SysParamData
    {
        private string  _filePath;
        public  int     nMontionType;
        public  double  AxisXSpeed;
        public  double  AxisYSpeed;
        public  double  AxisZSpeed;

        public double dbXSpeed;
        public double dbXAcc;

        public double dbzSpeed;
        public double dbzAcc;
        public double dbzApos;

        public double dbYSpeed;
        public double dbYAcc;

        public double dbRSpeed;
        public double dbRAcc;

        public int Cutpath;
        public bool cutdirecModel;
        public bool cutdirection;

        public double startpointext;
        public double endpointext;

        public double posoffset;
        public double backoffset;


        public double xoffset;
        public double yoffset;
        public double angoffset;

        public double limitx;
        public double limity;
        public double limitang;

        public double Point1_x;
        public double Point1_y;
        public double Point2_x;
        public double Point2_y;
        public double Point3_x;
        public double Point3_y;
        public double Point4_x;
        public double Point4_y;

        public double g_ccdoffsetx;
        public double g_ccdoffsety;
        public double g_ccdoffsetang;

        public double startx, starty, startr, endx, endy, endr;

        public  double  AxisZHomeOffset;
        public  string  CCDComNum="COM3";
        public  int     vecRecipeCount;
        public string []AeroFilePath = new string[4];
        public cutdata m_cutData = new cutdata();
        public vecRecipe[] vecRecipe=new vecRecipe[10];
        public recipedata[] recipedata = new recipedata[5];
        // public Dictionary<string, VarCfg> SysVarData = new Dictionary<string, VarCfg>();
        /// <summary>
        /// 
        /// </summary>
        public SysParamData()
        {
            _filePath = System.IO.Directory.GetCurrentDirectory() + "\\SysCfg\\sys.ini";
        }
        /// <summary>
        /// 
        /// </summary>
        public void LoadParams()
        {
            Ini ini = new Ini(_filePath);
            AxisXSpeed = ini.ReadDouble("AxisParam", "AxisXSpeed", 0.0);
            AxisYSpeed = ini.ReadDouble("AxisParam", "AxisYSpeed", 0.0);
            AxisZSpeed = ini.ReadDouble("AxisParam", "AxisZSpeed", 0.0);
            CCDComNum = ini.ReadString("CommonParam", "CCDComNum", "");
            //vecRecipeCount = ini.ReadInteger("CommonParam", "vecRecipeCount", 0);

            dbXSpeed = ini.ReadDouble("AXIS_X", "dbXSpeed", 100);
            dbXAcc = ini.ReadDouble("AXIS_X", "dbXAcc", 1000);
            dbYSpeed = ini.ReadDouble("AXIS_Y", "dbYSpeed", 100);
            dbYAcc = ini.ReadDouble("AXIS_Y", "dbYAcc", 1000);

            dbzSpeed = ini.ReadDouble("AXIS_z", "dbzSpeed", 100);
            dbzAcc = ini.ReadDouble("AXIS_z", "dbzAcc", 1000);

            dbzApos = ini.ReadDouble("AXIS_z", "dbzApos", 0);

            cutdirecModel = ini.ReadBoolean("CommonParam", "cutdirecModel", false);
            cutdirection = ini.ReadBoolean("CommonParam", "cutdirection", false);

            startpointext = ini.ReadDouble("CommonParam", "startpointext", 0.0);
            endpointext = ini.ReadDouble("CommonParam", "endpointext", 0.0);


            dbRSpeed = ini.ReadDouble("CommonParam", "dbRSpeed", 0.0);
            dbRAcc = ini.ReadDouble("CommonParam", "dbRAcc", 0.0);

            startx = ini.ReadDouble("CommonParam", "startx", 0.0);
            starty = ini.ReadDouble("CommonParam", "starty", 0.0);
            startr = ini.ReadDouble("CommonParam", "startr", 0.0);

            endx = ini.ReadDouble("CommonParam", "endx", 0.0);
            endy = ini.ReadDouble("CommonParam", "endy", 0.0);
            endr = ini.ReadDouble("CommonParam", "endr", 0.0);

            posoffset = ini.ReadDouble("CommonParam", "posoffset", 0.0);
            backoffset = ini.ReadDouble("CommonParam", "backoffset", 0.0);


            xoffset = ini.ReadDouble("CommonParam", "xoffset", 0.0);
            yoffset = ini.ReadDouble("CommonParam", "yoffset", 0.0);
            angoffset = ini.ReadDouble("CommonParam", "angoffset", 0.0);

            limitx = ini.ReadDouble("CommonParam", "limitx", 0.0);
            limity = ini.ReadDouble("CommonParam", "limity", 0.0);
            limitang = ini.ReadDouble("CommonParam", "limitang", 0.0);

            Point1_x = ini.ReadDouble("CommonParam", "Point1_x", 0.0);
            Point1_y = ini.ReadDouble("CommonParam", "Point1_y", 0.0);
            Point2_x = ini.ReadDouble("CommonParam", "Point2_x", 0.0);
            Point2_y = ini.ReadDouble("CommonParam", "Point2_y", 0.0);
            Point3_x = ini.ReadDouble("CommonParam", "Point3_x", 0.0);
            Point3_y = ini.ReadDouble("CommonParam", "Point3_y", 0.0);
            Point4_x = ini.ReadDouble("CommonParam", "Point4_x", 0.0);
            Point4_y = ini.ReadDouble("CommonParam", "Point4_y", 0.0);


            Cutpath = ini.ReadInteger("CommonParam", "Cutpath", 0);

            for (int i = 0; i < recipedata.Length; i++)
            {
                string stmsection = "RecipeIndex_" + i.ToString();
                recipedata[i].Cutspeed = ini.ReadInteger(stmsection, "Cutspeed", 0);
                recipedata[i].Cutdepth = ini.ReadDouble(stmsection, "Cutdepth", 0.0);
                recipedata[i].lasermode = ini.ReadString(stmsection, "lasermode", "");
                recipedata[i].Laserfrequency = ini.ReadInteger(stmsection, "Laserfrequency", 0);
                recipedata[i].Laserinterval = ini.ReadDouble(stmsection, "Laserinterval", 0.0);
                recipedata[i].laserwidth = ini.ReadDouble(stmsection, "Laserwidth", 0.0);

                recipedata[i].Laserpower = ini.ReadInteger(stmsection, "Laserpower", 0);
                recipedata[i].Lowpass = ini.ReadDouble(stmsection, "Lowpass", 0.0);
                recipedata[i].BrustNum = ini.ReadInteger(stmsection, "BrustNum", 0);
                recipedata[i].Cutacc = ini.ReadDouble(stmsection, "Cutacc", 0.0);
            }
            m_cutData.dbFocus = ini.ReadDouble("Cutparam", "dbFocus", 0.0);
            m_cutData.dbAcc = ini.ReadDouble("Cutparam", "dbAcc", 0.0);
            m_cutData.dbLineLength = ini.ReadDouble("Cutparam", "dbLineLength", 0.0);
            m_cutData.dbSpeed = ini.ReadDouble("Cutparam", "dbSpeed", 0.0);
            m_cutData.dbStep = ini.ReadDouble("Cutparam", "dbStep", 0.0);
            m_cutData.iLineNum = ini.ReadInteger("Cutparam", "iLineNum", 0);
            m_cutData.ZtextCutNum = ini.ReadInteger("Cutparam", "ZtextCutNum", 0);
            m_cutData.ZtextStep = ini.ReadDouble("Cutparam", "ZtextStep", 0.0);
            HandleTinCAT.getInstance().fWriteparamToPlc();
        }
        /// <summary>
        /// 
        /// </summary>
        public void SaveParams()
        {
            Ini ini = new Ini(_filePath);
            ini.WriteDouble("AxisParam", "AxisXSpeed", AxisXSpeed);
            ini.WriteDouble("AxisParam", "AxisYSpeed", AxisYSpeed);
            ini.WriteDouble("AxisParam", "AxisZSpeed", AxisZSpeed);
            ini.WriteString("CommonParam", "CCDComNum", CCDComNum);

            // ini.WriteInteger("CommonParam", "vecRecipeCount", vecRecipeCount);
            ini.WriteDouble("AXIS_X", "dbXSpeed", dbXSpeed);
            ini.WriteDouble("AXIS_X", "dbXAcc", dbXAcc);


            ini.WriteDouble("AXIS_z", "dbzSpeed", dbzSpeed);
            ini.WriteDouble("AXIS_z", "dbzAcc", dbzAcc);
            ini.WriteDouble("AXIS_z", "dbzApos", dbzApos);


            ini.WriteDouble("AXIS_Y", "dbYSpeed", dbYSpeed);
            ini.WriteDouble("AXIS_Y", "dbYAcc", dbYAcc);
            ini.WriteInteger("CommonParam", "Cutpath", Cutpath);

            ini.WriteBoolean("CommonParam", "cutdirecModel", cutdirecModel);
            ini.WriteBoolean("CommonParam", "cutdirection", cutdirection);

            ini.WriteDouble("CommonParam", "startpointext", startpointext);
            ini.WriteDouble("CommonParam", "endpointext", endpointext);

            ini.WriteDouble("CommonParam", "posoffset", posoffset);
            ini.WriteDouble("CommonParam", "backoffset", backoffset);


            ini.WriteDouble("CommonParam", "dbRSpeed", dbRSpeed);
            ini.WriteDouble("CommonParam", "dbRAcc", dbRAcc);

            ini.WriteDouble("CommonParam", "startx", startx);
            ini.WriteDouble("CommonParam", "starty", starty);
            ini.WriteDouble("CommonParam", "startr", startr);
            ini.WriteDouble("CommonParam", "endx", endx);
            ini.WriteDouble("CommonParam", "endy", endy);
            ini.WriteDouble("CommonParam", "endr", endr);

            ini.WriteDouble("CommonParam", "xoffset", xoffset);
            ini.WriteDouble("CommonParam", "yoffset", yoffset);
            ini.WriteDouble("CommonParam", "angoffset", angoffset);


            ini.WriteDouble("CommonParam", "limitx", limitx);
            ini.WriteDouble("CommonParam", "limity", limity);
            ini.WriteDouble("CommonParam", "limitang", limitang);


            ini.WriteDouble("CommonParam", "Point1_x", Point1_x);
            ini.WriteDouble("CommonParam", "Point1_y", Point1_y);
            ini.WriteDouble("CommonParam", "Point2_x", Point2_x);
            ini.WriteDouble("CommonParam", "Point2_y", Point2_y);
            ini.WriteDouble("CommonParam", "Point3_x", Point3_x);
            ini.WriteDouble("CommonParam", "Point3_y", Point3_y);
            ini.WriteDouble("CommonParam", "Point4_x", Point4_x);
            ini.WriteDouble("CommonParam", "Point4_y", Point4_y);


            for (int i = 0; i < recipedata.Length; i++)
            {
                string stmsection = "RecipeIndex_" + i.ToString();
                ini.WriteInteger(stmsection, "Cutspeed", recipedata[i].Cutspeed);
                ini.WriteDouble(stmsection, "Cutdepth", recipedata[i].Cutdepth);
                ini.WriteString(stmsection, "lasermode", recipedata[i].lasermode);
                ini.WriteInteger(stmsection, "Laserfrequency", recipedata[i].Laserfrequency);
                ini.WriteDouble(stmsection, "Laserinterval", recipedata[i].Laserinterval);
                ini.WriteDouble(stmsection, "Laserwidth", recipedata[i].laserwidth);
                ini.WriteInteger(stmsection, "Laserpower", recipedata[i].Laserpower);
                ini.WriteDouble(stmsection, "Lowpass", recipedata[i].Lowpass);
                ini.WriteInteger(stmsection, "BrustNum", recipedata[i].BrustNum);
                ini.WriteDouble(stmsection, "Cutacc", recipedata[i].Cutacc);
            }
            ini.WriteDouble("Cutparam", "dbFocus", m_cutData.dbFocus);
            ini.WriteDouble("Cutparam", "dbAcc", m_cutData.dbAcc);
            ini.WriteDouble("Cutparam", "dbLineLength", m_cutData.dbLineLength);
            ini.WriteDouble("Cutparam", "dbSpeed", m_cutData.dbSpeed);
            ini.WriteDouble("Cutparam", "dbStep", m_cutData.dbStep);
            ini.WriteDouble("Cutparam", "ZtextStep", m_cutData.ZtextStep);
            ini.WriteInteger("Cutparam", "iLineNum", m_cutData.iLineNum);
            ini.WriteInteger("Cutparam", "ZtextCutNum", m_cutData.ZtextCutNum);
            LoadParams();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    class InPut 
    {
        public bool[] InPutIO = new bool[100];
    }

    struct vecRecipe
    { 
        public int index;
        public int WorkPower;
        public int Worktime;
    }
    /// <summary>
    /// 切割参数
    /// </summary>
    struct cutdata
    {
        public double dbFocus;
        public double dbLineLength;
        public double dbStep;
        public int iLineNum;
        public double dbSpeed;
        public double dbAcc;
        public double ZtextStep;
        public int ZtextCutNum;
    }
}
