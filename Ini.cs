using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WhyfdrCamera
{
    class Ini
    {
        
	    private string m_szFileName;
        /// <summary>
        /// 
        /// </summary>
        public Ini()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szFileName"></param>
        public Ini( string szFileName )
        {
            m_szFileName = szFileName;
        }
        /// <summary>
        /// 
        /// </summary>
	    ~Ini()
        {
            WritePrivateProfileString( null, null, null, m_szFileName );
        }

        // Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szSection"></param>
        /// <param name="szKey"></param>
        /// <param name="iDefaultValue"></param>
        /// <returns></returns>
        public int ReadInteger(string szSection, string szKey, int iDefaultValue)
        {
            int iResult = GetPrivateProfileInt(szSection,  szKey, iDefaultValue, m_szFileName); 
	        return iResult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szSection"></param>
        /// <param name="szKey"></param>
        /// <param name="dbltDefaultValue"></param>
        /// <returns></returns>
        public double ReadDouble(string szSection, string szKey, double dbltDefaultValue)
        {
            StringBuilder strReturn = new StringBuilder(2048);
	        string szDefault = dbltDefaultValue.ToString();
	        string tmpResult;
	        GetPrivateProfileString( szSection,  szKey, szDefault, strReturn, 255, m_szFileName); 
	        tmpResult =  strReturn.ToString();
	        return GlobalMethod.getInstance().StringToDouble(tmpResult, 0.0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szSection"></param>
        /// <param name="szKey"></param>
        /// <param name="bolDefaultValue"></param>
        /// <returns></returns>
        public bool ReadBoolean(string szSection, string szKey, bool bolDefaultValue)
        {
            StringBuilder strReturn = new StringBuilder(2048);
            string szResult;
	        string szDefault = bolDefaultValue.ToString();
	        GetPrivateProfileString(szSection, szKey, szDefault, strReturn, 255, m_szFileName); 
            szResult = strReturn.ToString();
	        return GlobalMethod.getInstance().StringToBool(szResult, false);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szSection"></param>
        /// <param name="szKey"></param>
        /// <param name="szDefaultValue"></param>
        /// <returns></returns>
        public string ReadString(string szSection, string szKey, string szDefaultValue)
        {
            StringBuilder strReturn = new StringBuilder(2048);
            GetPrivateProfileString(szSection, szKey, szDefaultValue, strReturn, 255, m_szFileName);
            return strReturn.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szSection"></param>
        /// <param name="szKey"></param>
        /// <param name="iValue"></param>
        public void WriteInteger(string szSection, string szKey, int iValue)
        {
        	WritePrivateProfileString(szSection,  szKey, iValue.ToString(), m_szFileName); 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szSection"></param>
        /// <param name="szKey"></param>
        /// <param name="dbltValue"></param>
        public void WriteDouble(string szSection, string szKey, double dbltValue)
        {
            WritePrivateProfileString(szSection, szKey, dbltValue.ToString(), m_szFileName); 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szSection"></param>
        /// <param name="szKey"></param>
        /// <param name="bolValue"></param>
        public void WriteBoolean(string szSection, string szKey, bool bolValue)
        {
            WritePrivateProfileString(szSection, szKey, bolValue.ToString(), m_szFileName);  
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szSection"></param>
        /// <param name="szKey"></param>
        /// <param name="szValue"></param>
        public void WriteString(string szSection, string szKey, string szValue)
        {
            WritePrivateProfileString(szSection, szKey, szValue, m_szFileName); 
        }

        [DllImport("Kernel32.dll")]
        private static extern uint GetPrivateProfileString(string strAppName, string strKeyName, string strDefault,
            StringBuilder sbReturnString, int nSize, string strFileName);

        [DllImport("Kernel32.dll")]
        public static extern bool WritePrivateProfileString(string strAppName, string strKeyName, string strString,
            string strFileName);

        [DllImport("Kernel32.dll")]
        private static extern int GetPrivateProfileInt(string strAppName, string strKeyName, int nDefault,
            string strFileName);

    }
}
