using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace SocketClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //关闭对文本框的非法线程操作检查
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        //创建 1个客户端套接字 和1个负责监听服务端请求的线程  
        Socket socketClient = null;
        Thread threadClient = null;

        private void btnBeginListen_Click(object sender, EventArgs e)
        {
            //定义一个套字节监听  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //需要获取文本框中的IP地址
            IPAddress ipaddress = IPAddress.Parse(txtIP.Text.Trim());
            //将获取的ip地址和端口号绑定到网络节点endpoint上
            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(txtPORT.Text.Trim()));
            //这里客户端套接字连接到网络节点(服务端)用的方法是Connect 而不是Bind
            socketClient.Connect(endpoint);
            //创建一个线程 用于监听服务端发来的消息
            threadClient = new Thread(RecMsg);
            //将窗体线程设置为与后台同步
            threadClient.IsBackground = true;
            //启动线程
            threadClient.Start();
        }

        /// <summary>
        /// 接收服务端发来信息的方法
        /// </summary>
        private void RecMsg()  //接受信息线程使用的函数
        {
            while (true) //持续监听服务端发来的消息
            {
                //定义一个1M的内存缓冲区 用于临时性存储接收到的信息
                byte[] arrRecMsg = new byte[1024 * 1024];
                //将客户端套接字接收到的数据存入内存缓冲区, 并获取其长度
                int length = socketClient.Receive(arrRecMsg);
                //将套接字获取到的字节数组转换为人可以看懂的字符串
                string strRecMsg = Encoding.UTF8.GetString(arrRecMsg, 0, length);
                //将发送的信息追加到聊天内容文本框中
                txtMsg.AppendText("来自服务器:" + GetCurrentTime() + "\r\n" + strRecMsg + "\r\n");
            }
        }

        /// <summary>
        /// 发送字符串信息到服务端的方法
        /// </summary>
        /// <param name="sendMsg">发送的字符串信息</param>
        private void ClientSendMsg(string sendMsg)
        {
            //将输入的内容字符串转换为机器可以识别的字节数组
            byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
            //调用客户端套接字发送字节数组
            socketClient.Send(arrClientSendMsg);
            //将发送的信息追加到聊天内容文本框中
            txtMsg.AppendText("客户端消息:" + GetCurrentTime() + "\r\n" + sendMsg + "\r\n");
        }

        //点击按钮btnSend 向服务端发送信息

        /// <summary>
        /// 获取当前系统时间的方法
        /// </summary>
        /// <returns>当前时间</returns>
        private DateTime GetCurrentTime()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            return currentTime;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //定义一个套字节监听  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //需要获取文本框中的IP地址
            IPAddress ipaddress = IPAddress.Parse(txtIP.Text.Trim());
            //将获取的ip地址和端口号绑定到网络节点endpoint上
            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(txtPORT.Text.Trim()));
            //这里客户端套接字连接到网络节点(服务端)用的方法是Connect
            socketClient.Connect(endpoint);
            //创建一个线程 用于监听服务端发来的消息
            threadClient = new Thread(RecMsg);
            //将窗体线程设置为与后台同步
            threadClient.IsBackground = true;
            //启动线程
            threadClient.Start();
            txtMsg.AppendText("Got Server:" + GetCurrentTime() +  "\r\n");
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            ClientSendMsg(txtSend.Text.Trim());
            txtSend.Text = "";
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这款软件由潘尚制作完成,主要功能有:聊天,聊天记录查询,聊天记录查询请向服务器端申请.联系作者:潘尚,QQ:574273250");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用之前请先填写服务器端的IP与端口号,然后开始聊天.客户端没有权限查看连天记录!若要查看聊天记录,请向服务器端申请,呆工作人员同一发送聊天记录给客户端!");
        }
    }
}
