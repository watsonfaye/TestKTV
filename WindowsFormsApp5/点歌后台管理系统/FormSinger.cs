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
    public partial class FormSinger : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        public FormSinger()
        {
            InitializeComponent();
        }

        private void FormSinger_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            ds = new DataSet();
            InitComboBoxArea();
            RefreshData();
        }
        //初始化区域下拉框的数据
        private void InitComboBoxArea()
        {
            string sql = "select * from singer_type";
            adapter = new SqlDataAdapter(sql, DBHelper.inst.Conn);
            adapter.Fill(ds, "singer_area");
            comboBox1.DisplayMember = "singertype_name";
            comboBox1.ValueMember = "singertype_id";
            comboBox1.DataSource = ds.Tables["singer_area"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            // 指定打开文本文件（后缀名为txt）
            openDlg.Filter = "图片文件|*.*";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                lbPath.Text = openDlg.FileName;
                pictureBox1.Image = Image.FromFile(openDlg.FileName);
            }
        }
        //新增
        private void button2_Click(object sender, EventArgs e)
        {
            
            string sql = $"insert  singer_info values('{textBox1.Text}', {comboBox1.SelectedValue}, '{GetSex()}', '{lbPath.Text}')";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
           int r= cmd.ExecuteNonQuery();
            DBHelper.inst.Close();

            MessageBox.Show(r>0?"新增成功":"新增失败");
            if (r > 0) RefreshData();
        }
        //刷新方法
        private void RefreshData()
        {
            if (ds.Tables["singer_info"] != null) ds.Tables["singer_info"].Clear();
            string sql = "select singer_id, singer_name,singer_sex, singer_photo_url,singertype_name from singer_info s join singer_type st on s.singertype_id = st.singertype_id";
            adapter = new SqlDataAdapter(sql,DBHelper.inst.Conn);
            adapter.Fill(ds, "singer_info");
            dataGridView1.DataSource = ds.Tables["singer_info"];
        }

        //修改
        private void button3_Click(object sender, EventArgs e)
        {
            string sql = $"update singer_info set singer_name='{textBox1.Text}',singertype_id={comboBox1.SelectedValue},singer_sex='{GetSex()}',singer_photo_url='{lbPath.Text}' where singer_id={lbId.Text}";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
            int r=cmd.ExecuteNonQuery();
            DBHelper.inst.Close();
            MessageBox.Show(r > 0 ? "修改成功" : "修改失败");
            if (r > 0) RefreshData();
        }
        //清空
        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
           lbPath.Text= textBox1.Text = string.Empty;
        }
        private string GetSex()
        {
            string sex = radioButton1.Checked ? radioButton1.Text : "";
            if (sex.Equals(string.Empty)) sex = radioButton2.Checked ? radioButton2.Text : "";
            if (sex.Equals(string.Empty)) sex = radioButton3.Checked ? radioButton3.Text : "";
            return sex;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (dataGridView1.SelectedRows[0].Cells[0].Value == null) return;
            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Equals(string.Empty)) return;
            DataGridViewRow dr =  dataGridView1.SelectedRows[0];
            lbId.Text = dr.Cells[0].Value.ToString();
            textBox1.Text = dr.Cells[1].Value.ToString();
            switch (dr.Cells[2].Value.ToString())
            {
                case "男":radioButton1.Checked = true;break;
                case "女":radioButton2.Checked = true;break;
                case "组合":radioButton3.Checked = true;break;
            }
            comboBox1.Text = dr.Cells[3].Value.ToString();
            lbPath.Text = dr.Cells[4].Value.ToString();
            pictureBox1.Image = Image.FromFile(lbPath.Text);
        }
        //删除
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            string sql = $"delete from singer_info where singer_id={id}";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
            int r = cmd.ExecuteNonQuery();
            DBHelper.inst.Close();
            MessageBox.Show(r > 0 ? "删除成功" : "删除失败");
            if (r > 0) RefreshData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPath_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
