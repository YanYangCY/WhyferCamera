using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace WhyfdrCamera
{
    enum MotionType
    {
        MT_GT = 1,		// 固高卡
        TinCAT,//倍福PLC
    };
    enum VarSecTion
    {
        AxisParam = 1,//轴变量
        CCDParam,//CCD
        LaserParam,//激光参数
        Common,//公共变量       
    };
    enum ErrorType
    {
        ET_TIPS = 1,
        ET_OPLOG,
        ET_ERROR,
    };
    enum AxisNo
    {
        AxisX = 0,
        AxisY,
        AxisZ,
        AxisW,
    };
    enum Authority
    {
        AU_Adminostrator = 1,
        AU_Engineer,
        AU_Vendor,
        AU_Operator,
    }

    #region 错误码
    /// <summary>
    /// 0-200PLC报警
    /// </summary>
    enum PLCErrCode
    {
        PEC_SUC = 0,
        PEC_HOMETIMEOUT = 1,                          // 复位超时
        
    }
    /// <summary>
    /// 201-300上位系统提示
    /// </summary>
    enum TipsErrCode
    {
        TEC_SUC = 0,
        TEC_CONNECTPLCFAIL= 200 + 1,                          // acsPLC失败
        TEC_CONNECTPLCSUC,                                    // acsPLC成功
        TEC_CASEXITNOFINISH,                                  //出花篮未完成
        TEC_SYSTEMPAUSE,                                      //系统暂停
        TEC_SYSTEMRESTART,                                    //系统恢复运行
        TEC_SETPLCPARAMFAIL,                                  //设置PLC参数失败
        TEC_MAINDOOROPEN,                                     //主机安全门打开，禁止运行
        TEC_LOADDOOROPEN,                                     //接驳台安全门打开，禁止运行
        TEC_SYSNOTRESET,//系统未复位
        TEC_TABLEHASWAFER,//台面有硅片
        TEC_SYSTEMRUN,//系统自动化运行
        TEC_SYSRESETCOMPLETE,//系统复位完成
        TEC_MAX,
        TEC_LASERERROR,//激光加工失败
    }
    /// <summary>
    /// 操作日志401-500
    /// </summary>
    enum OperateErrCode { 
        OEC_RECIPESAVESUC=400+1,
    }
    /// <summary>
    /// 301-400CCD报警
    /// </summary>
    enum CCDErrCode
    {
        CEC_SUC = 0,
        CEC_INITSUC = 300 + 1,                          // 相机初始化成功
        CEC_INITFAIL,                                   // 相机初始化失败
        CEC_CCDCLECTFAIL,//图像采集异常
        CEC_CCDCOVER,//遮挡
        CEC_CCDNGPIECE,//破片
        CEC_MARKEROR,//MARK异常
        CEC_DATAFALSHFAIL,//数据刷新失败
        CEC_MAX,                                        
    }
    #endregion
    /// <summary>
    /// POS工艺参数
    /// </summary>
    struct recipedata 
    { 
        public int Cutspeed;
        public double Cutdepth;
        public string lasermode;
        public double Laserinterval;
        public double laserwidth;

        public int Laserfrequency;
        public int Laserpower;
        public int BrustNum;
        public double Cutacc;
        public double Lowpass;
    }
    /// <summary>
    /// 绘图元素
    /// </summary>
    //struct drawelet 
    //{
    //    public double startpointx;
    //    public double startpointy;
    //    public double endpointx;
    //    public double endpointy;
    //    public double centerpointx;
    //    public double centerpointy;
    //    public int layer;
    //    public int elestyle;
    //}
    /// <summary>
    /// 加工工艺
    /// </summary>
    struct Cutrecipe
    {
        public double startpointx;
        public double startpointy;
        public double endpointx;
        public double endpointy;
        public double centerpointx;
        public double centerpointy;
        public int layer;
        public int elestyle;//0直线，1圆弧，2圆
        public int cutdirection;//1顺时针、0逆时针
        public bool cutcontinue;//切割图形连续标志位，true表示连续，false表示不连续
        public recipedata cutrecipedata;
    }
    /// <summary>
    /// 
    /// </summary>
    class GlobalDefine
    {
        public string ERR_EVENT_LOG = "LOG";

        public int GT_ERROR = 100000;
        public Input st_Input = new Input();
        public bool[] stInpu=new bool[160];
        public vecRecipe[]  vecRecipetem=new vecRecipe[10];
        //public List<WindowsFormsApplication.drawelet> draweletload = new List<drawelet>();
        public List<WindowsFormsApplication.Cutrecipe> Cutrecipe = new List<Cutrecipe>();

        public List<WindowsFormsApplication.Cutrecipe> Cutrecipearc = new List<Cutrecipe>();
        public List<double[]> cutdata = new List<double[]>();

        public bool g_AlarmStu, g_AutoRunFlag, g_SysResetFlag, g_DDArrive, m_SysParaSetFlag, g_ResetClick, g_CameraWafer, g_SysResetErr;
        public int g_WaferBreak = 0, g_MainStepnew = 0, g_CCDAlarm = 0, g_CCDFinishFlag, g_Authority, g_TotalQulity;
        public double[] g_CCDSource = new double[16];

        public GlobalDefine()
        {
           
        }
        // 单例模式
        public static GlobalDefine instance;
        public static GlobalDefine getInstance()
        {
            if (instance == null)
            {
                instance = new GlobalDefine();
            }
            return instance;
        }
    }

    #region IO定义
    struct Input
    {
        public bool SafeMainDoorCheck;
        public bool SafeLoadDoorCheck;
        public bool TableAVac;
        public bool TableBVac;
        public bool TableCVac;
        public bool TableDVac;
        public bool Cyl_FlexEnter_InBasic;
        public bool Cyl_FlexExit_InBasic;
        public bool AIn9;
        public bool AIn10;
        public bool AIn11;
        public bool AIn12;
        public bool AIn13;
        public bool AIn14;
        public bool AIn15;
        public bool AIn16;

        public bool BIn1;
        public bool BIn2;
        public bool BIn3;
        public bool BIn4;
        public bool BIn5;
        public bool BIn6;
        public bool BIn7;
        public bool BIn8;
        public bool BIn9;
        public bool BIn10;
        public bool BIn11;
        public bool BIn12;
        public bool BIn13;
        public bool BIn14;
        public bool BIn15;
        public bool BIn16;

        public bool CIn1;
        public bool CIn2;
        public bool CIn3;
        public bool CIn4;
        public bool CIn5;
        public bool CIn6;
        public bool CIn7;
        public bool CIn8;
        public bool CIn9;
        public bool CIn10;
        public bool CIn11;
        public bool CIn12;
        public bool CIn13;
        public bool CIn14;
        public bool CIn15;
        public bool CIn16;

        public bool DIn1;
        public bool DIn2;
        public bool DIn3;
        public bool DIn4;
        public bool DIn5;
        public bool DIn6;
        public bool DIn7;
        public bool DIn8;
        public bool DIn9;
        public bool DIn10;
        public bool DIn11;
        public bool DIn12;
        public bool DIn13;
        public bool DIn14;
        public bool DIn15;
        public bool DIn16;

        public bool EIn1;
        public bool EIn2;
        public bool EIn3;
        public bool EIn4;
        public bool EIn5;
        public bool EIn6;
        public bool EIn7;
        public bool EIn8;
        public bool EIn9;
        public bool EIn10;
        public bool EIn11;
        public bool EIn12;
        public bool EIn13;
        public bool EIn14;
        public bool EIn15;
        public bool EIn16;
    }
    #endregion
}
