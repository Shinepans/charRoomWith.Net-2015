namespace SocketServer
{
    partial class HForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talkDataSet1 = new SocketServer.talkDataSet1();
            this.talkDataSet = new SocketServer.talkDataSet();
            this.talkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talkTableAdapter = new SocketServer.talkDataSetTableAdapters.talkTableAdapter();
            this.serverTableAdapter = new SocketServer.talkDataSet1TableAdapters.ServerTableAdapter();
            this.usersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serverBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 522);
            this.dataGridView1.TabIndex = 0;
            // 
            // serverBindingSource
            // 
            this.serverBindingSource.DataMember = "Server";
            this.serverBindingSource.DataSource = this.talkDataSet1;
            // 
            // talkDataSet1
            // 
            this.talkDataSet1.DataSetName = "talkDataSet1";
            this.talkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // talkDataSet
            // 
            this.talkDataSet.DataSetName = "talkDataSet";
            this.talkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // talkBindingSource
            // 
            this.talkBindingSource.DataMember = "talk";
            this.talkBindingSource.DataSource = this.talkDataSet;
            // 
            // talkTableAdapter
            // 
            this.talkTableAdapter.ClearBeforeFill = true;
            // 
            // serverTableAdapter
            // 
            this.serverTableAdapter.ClearBeforeFill = true;
            // 
            // usersDataGridViewTextBoxColumn
            // 
            this.usersDataGridViewTextBoxColumn.DataPropertyName = "users";
            this.usersDataGridViewTextBoxColumn.HeaderText = "用户与时间";
            this.usersDataGridViewTextBoxColumn.Name = "usersDataGridViewTextBoxColumn";
            this.usersDataGridViewTextBoxColumn.Width = 300;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "text";
            this.textDataGridViewTextBoxColumn.FillWeight = 490F;
            this.textDataGridViewTextBoxColumn.HeaderText = "记录";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.Width = 700;
            // 
            // HForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 522);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HForm";
            this.Load += new System.EventHandler(this.HForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private talkDataSet talkDataSet;
        private System.Windows.Forms.BindingSource talkBindingSource;
        private talkDataSetTableAdapters.talkTableAdapter talkTableAdapter;
        private talkDataSet1 talkDataSet1;
        private System.Windows.Forms.BindingSource serverBindingSource;
        private talkDataSet1TableAdapters.ServerTableAdapter serverTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
    }
}