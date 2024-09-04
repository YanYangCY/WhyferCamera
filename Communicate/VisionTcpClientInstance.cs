using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;    // 引入SimpleTCP库

namespace WhyferCamera
{
    public static class GlobalVariables
    {
        public static string RectResult = null;
    }
    /// <summary>
    /// 用于管理TCP客户端
    /// </summary>
    public class SimpleTcpClientInstance
    {
        // 静态变量，用于跟踪是否连接到服务器
        public static bool Connected = false;
        // 静态变量，存储TCP客户端的实例
        public static SimpleTcpClient _tcpClient;
        // 回调函数
        // public static event EventHandler<string> DataReceived;
        // TcpClient属性，用于加载和返回TCP客户端实例
        public static SimpleTcpClient TcpClient
        {
            get
            {
                // 如果_tcpClient为空，则创建实例
                if (_tcpClient == null)
                {
                    string ip = "127.0.0.1";// "192.168.3.5";
                    int port = 60001; //5000;
                    _tcpClient = GetInstance(ip, port);
                }
                // 返回TCP客户端实例
                return _tcpClient;
            }
            set { } // set为空，只读属性
        }
        // 静态方法，断开与服务器的连接并重置_tcpClient为null
        public static void Disconnect()
        {
            _tcpClient.Disconnect();
            _tcpClient = null;
            Connected = false;
        }
        // 静态方法，用于获取或创建TCP客户端的实例，并连接到指定的IP和端口
        public static SimpleTcpClient GetInstance(string ip, int port)
        {
            try
            {
                // 创建SimpleTcpClient的新实例
                SimpleTcpClient tccpClient = new SimpleTcpClient();
                // 设置消息的分隔符为回车符（0x0D）
                tccpClient.Delimiter = 0x0A;
                // 移除已存在的DelimiterDataReceived事件处理器（如果有的话），防止重复绑定
                tccpClient.DelimiterDataReceived -= tccpClient_DelimiterDataReceived;
                // 绑定DelimiterDataReceived事件处理器
                tccpClient.DelimiterDataReceived += tccpClient_DelimiterDataReceived;
                // 连接到服务器
                tccpClient.Connect(ip, port);
                // 标记为已连接
                Connected = true;
                // 返回创建的TCP客户端实例
                return tccpClient;
            }
            catch (Exception err)
            {
                // 连接失败时，标记为未连接，并返回null
                Connected = false;
                return null;
            }

        }
        // 私有静态方法，作为DelimiterDataReceived事件的处理器
        public static void tccpClient_DelimiterDataReceived(object sender, Message e)
        {
            try
            {
                // 简单的延时以避免过快处理（实际使用时可能需要更合适的处理方式）
                System.Threading.Thread.Sleep(15);
                // 获取接收到的字符串消息
                string strReceive = e.MessageString;
                // 调用AnalyseData方法处理接收到的数据
                AnalyseData(strReceive.Replace("\n", ""));
                // 触发DataReceived事件
                // DataReceived?.Invoke(null, strReceive);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // 静态方法，用于分析接收到的数据
        public static void AnalyseData(string strReceive)
        {
            // 使用分号作为分隔符分割字符串，并将结果存储在DataBuffer数组中
            // 注意：这里没有进一步处理DataBuffer数组，你可能需要根据实际需求添加代码
            string[] DataBuffer = strReceive.Split(new char[1] { ';' });  //获取字符串数组
            /*if (DataBuffer[0] == "A")
            {
                SendData("CNM");
            }*/
            if (DataBuffer[0] == "OK")
            {
                GlobalVariables.RectResult = "OK";
            }
            
        }
        // 添加发送数据的方法
        public static void SendData(string data)
        {
            if (_tcpClient != null && Connected == true)
            {
                // 假设SimpleTcpClient有WriteLine方法来发送带有换行符的数据
                // 如果你的库有不同的方法，请相应更改
                _tcpClient.WriteLine(data);
            }
            else
            {
                // 如果_tcpClient为空或未连接，则输出错误信息或执行其他操作
                Console.WriteLine("TCP client is not connected or not initialized.");
            }
        }

    }
}
