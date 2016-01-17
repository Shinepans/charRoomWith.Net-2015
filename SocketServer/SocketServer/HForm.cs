using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketServer
{
    public partial class HForm : Form
    {
        public HForm()
        {
            InitializeComponent();
        }

        private void HForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“talkDataSet1.Server”中。您可以根据需要移动或删除它。
            this.serverTableAdapter.Fill(this.talkDataSet1.Server);
            // TODO:  这行代码将数据加载到表“talkDataSet.talk”中。您可以根据需要移动或删除它。
            this.talkTableAdapter.Fill(this.talkDataSet.talk);
            SqlConnection myConn = new SqlConnection("server=潘尚\\sqlexpress;database=talk;uid=sa;pwd=123");
            SqlCommand cmd = new SqlCommand("select * from Server", myConn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Server");
            dataGridView1.DataSource = ds.Tables["Server"];
        }
    }
}
