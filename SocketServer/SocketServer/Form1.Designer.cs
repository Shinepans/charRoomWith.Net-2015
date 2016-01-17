namespace SocketServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPORT = new System.Windows.Forms.TextBox();
            this.btnServerConn = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(58, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(285, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(112, 18);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(110, 21);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtPORT
            // 
            this.txtPORT.Location = new System.Drawing.Point(368, 18);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.Size = new System.Drawing.Size(110, 21);
            this.txtPORT.TabIndex = 3;
            this.txtPORT.Text = "40";
            // 
            // btnServerConn
            // 
            this.btnServerConn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServerConn.BackgroundImage")));
            this.btnServerConn.ForeColor = System.Drawing.Color.Transparent;
            this.btnServerConn.Location = new System.Drawing.Point(515, 18);
            this.btnServerConn.Name = "btnServerConn";
            this.btnServerConn.Size = new System.Drawing.Size(112, 23);
            this.btnServerConn.TabIndex = 4;
            this.btnServerConn.Text = "Start server";
            this.btnServerConn.UseVisualStyleBackColor = true;
            this.btnServerConn.Click += new System.EventHandler(this.btnServerConn_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(71, 59);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(802, 187);
            this.txtMsg.TabIndex = 5;
            this.txtMsg.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Msg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Send Msg";
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Location = new System.Drawing.Point(71, 316);
            this.txtSendMsg.Multiline = true;
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(802, 64);
            this.txtSendMsg.TabIndex = 8;
            this.txtSendMsg.TextChanged += new System.EventHandler(this.txtSendMsg_TextChanged);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendMsg.BackgroundImage")));
            this.btnSendMsg.ForeColor = System.Drawing.Color.Transparent;
            this.btnSendMsg.Location = new System.Drawing.Point(746, 409);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(127, 40);
            this.btnSendMsg.TabIndex = 9;
            this.btnSendMsg.Text = "Send";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.BackgroundImage")));
            this.btnHistory.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistory.Location = new System.Drawing.Point(800, 266);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(73, 25);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(962, 461);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnServerConn);
            this.Controls.Add(this.txtPORT);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Shine聊天工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPORT;
        private System.Windows.Forms.Button btnServerConn;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button btnHistory;
    }
}

