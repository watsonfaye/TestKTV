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

namespace 点歌后台管理系统
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"select count(*) from admin_info where admin_name='{textBox1.Text}' and admin_pwd='{textBox2.Text}'";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
            int r=(int)cmd.ExecuteScalar();
            DBHelper.inst.Close();
            if (r > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
