using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Data.SqlClient;

namespace SocketServer
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false; //关闭文本框非法线程的检测
        }
        string dataDir = AppDomain.CurrentDomain.BaseDirectory;
        Thread threadWatch = null; //负责监听客户端的线程
        Socket socketWatch = null; //负责监听客户端的套接字
        string Conn = "server=潘尚\\SQLEXPRESS;database=Server;uid=sa;pwd=123";
        string sys = "系统消息:";
        string sys1 = "系统开始监听:";
        string sys2 = "监听到客户端:";
        string user1 = "潘尚:";
        string user2 = "潘下:";
        private void btnServerConn_Click(object sender, EventArgs e)
        {
            //套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress = IPAddress.Parse(txtIP.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(txtPORT.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch.Bind(endpoint);
            //将套接字的监听队列长度限制为20
            socketWatch.Listen(20);
            //创建一个监听线程 
            threadWatch = new Thread(WatchConnecting);
            threadWatch.IsBackground = true;  //窗体程序与后台程序同步
            threadWatch.Start();
            txtMsg.AppendText("Server Start Listen :" +"\r\n"+ GetCurrentTime()+ "\r\n");  //将信息显示到RichTextBox
            //将日志加入到数据库中 ,数据库为本地文件,在我的文档中,连接方式见下
            SqlConnection myConn = new SqlConnection("server=潘尚\\sqlexpress;database=talk;uid=sa;pwd=123");
            SqlCommand cmd = new SqlCommand("insert into Server values('" +sys+GetCurrentTime()+ "','" +sys1 + "')",myConn);
            myConn.Open();
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {

            }
            else
            {
                MessageBox.Show("数据库出问题了!");
            }
        }
        Socket socConnection = null;  //负责和客户端通通信的套接字

        /// <summary>
        /// 监听客户端发来的请求
        /// </summary>
        private void WatchConnecting()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection = socketWatch.Accept();
                txtMsg.AppendText("Got Client:" + "\r\n");
                SqlConnection myConn = new SqlConnection("server=潘尚\\sqlexpress;database=talk;uid=sa;pwd=123");
                SqlCommand cmd = new SqlCommand("insert into Server values('" + sys + GetCurrentTime() + "','" + sys2 + "')", myConn);
                myConn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {

                }
                else
                {
                    MessageBox.Show("数据库出问题了!");
                }
                //创建一个通信线程 
                ParameterizedThreadStart pts = new ParameterizedThreadStart(ServerRecMsg);
                Thread thr = new Thread(pts);
                thr.IsBackground = true;
                //启动线程
                thr.Start(socConnection);
            }
        }

        /// <summary>
        /// 发送信息到客户端的方法
        /// </summary>
        /// <param name="sendMsg">发送的字符串信息</param>
        private void ServerSendMsg(string sendMsg)
        {
            //将输入的字符串转换成 机器可以识别的字节数组
            byte[] arrSendMsg = Encoding.UTF8.GetBytes(sendMsg);
            //向客户端发送字节数组信息
            socConnection.Send(arrSendMsg);
            //将发送的字符串信息附加到文本框txtMsg上
            txtMsg.AppendText("潘尚:" + GetCurrentTime() + "\r\n" + sendMsg + "\r\n");
            //发送消息后,清空发送栏
            //将消息存入数据库
            SqlConnection myConn = new SqlConnection("server=潘尚\\sqlexpress;database=talk;uid=sa;pwd=123");
            SqlCommand cmd = new SqlCommand("insert into Server values('" +user1+GetCurrentTime() + "','" + sendMsg.Trim() + "')", myConn);
            myConn.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {

            }
            else
            {
                MessageBox.Show("数据库出问题了!");
            }
        }

        /// <summary>
        /// 接收客户端发来的信息 
        /// </summary>
        /// <param name="socketClientPara">客户端套接字对象</param>
        private void ServerRecMsg(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;
            while (true)
            {
                //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                byte[] arrServerRecMsg = new byte[1024 * 1024];
                //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                int length = socketServer.Receive(arrServerRecMsg);
                //将机器接受到的字节数组转换为人可以读懂的字符串
                string strSRecMsg = Encoding.UTF8.GetString(arrServerRecMsg, 0, length);
                //将发送的字符串信息附加到文本框txtMsg上  
                txtMsg.AppendText("来自潘下:" + GetCurrentTime() + "\r\n" + strSRecMsg + "\r\n");
                SqlConnection myConn = new SqlConnection("server=潘尚\\sqlexpress;database=talk;uid=sa;pwd=123");
                SqlCommand cmd = new SqlCommand("insert into Server values('" + user2 + GetCurrentTime() + "','" + strSRecMsg + "')", myConn);
                myConn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {

                }
                else
                {
                    MessageBox.Show("数据库出问题了!");
                }
            }
        }

        //发送信息到客户端
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            //调用 ServerSendMsg方法  发送信息到客户端
            ServerSendMsg(txtSendMsg.Text.Trim());
            //清空发送消息栏
            txtSendMsg.Text = "";
        }

        //快捷键 Enter 发送信息
        private void txtSendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            //如果用户按下了Enter键
            if (e.KeyCode == Keys.Enter)
            {
                //则调用 服务器向客户端发送信息的方法
                ServerSendMsg(txtSendMsg.Text.Trim());
            }
        }

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

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HForm hf = new HForm();
            hf.Show();
        }

        private void txtSendMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* 本来想使用VS2013内置的mdf,但是受技术限制,还是使用了SQL 2008的版本的数据库
            if (dataDir.EndsWith(@"\bin\Debug") || dataDir.EndsWith(@"\bin\Release"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);

            }
            SqlConnection conn = new SqlConnection("DataSource=(LocalDB)\\v11.0;AttachDbFilename=d:\\用户目录\\我的文档\\visual studio 2013\\Projects\\SocketServer\\SocketServer\\Database1.mdf;Integrated Security=True");
            conn.Open();
            txtMsg.AppendText("已连接至数据库" + GetCurrentTime()  + "\r\n");
             * */
            string myConn = "server=潘尚\\SQLEXPRESS;database=talk;uid=sa;pwd=123";
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = myConn;
            try
            {
                sc.Open();
                MessageBox.Show("已与数据库建立连接");
            }
            catch(Exception ex)
            {
                MessageBox.Show("打开数据库错误{0}", ex.Message);
            }
        }
    }
}
