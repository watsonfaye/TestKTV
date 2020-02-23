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
    public partial class FormSong : Form
    {
        public FormSong()
        {
            InitializeComponent();
        }
        DataSet ds;
        SqlDataAdapter adapter;
        private void FormSong_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            ds = new DataSet();
            InitiaSongType();
            Initia_Singer();
            RefreshData();
        }
        //初始化歌手
        private void Initia_Singer()
        {
            string sql = "select singer_id,singer_name from singer_info";
            adapter = new SqlDataAdapter(sql, DBHelper.inst.Conn);
            adapter.Fill(ds, "singer_info");
            comboBox2.DisplayMember = "singer_name";
            comboBox2.ValueMember = "singer_id";
            comboBox2.DataSource = ds.Tables["singer_info"];
        }

        //初始化歌曲类型
        private void InitiaSongType()
        {
            string sql = "select * from song_type";
            adapter = new SqlDataAdapter(sql,DBHelper.inst.Conn);
            adapter.Fill(ds, "Song_type");
            comboBox1.DisplayMember = "songtype_name";
            comboBox1.ValueMember = "songtype_id";
            comboBox1.DataSource = ds.Tables["Song_type"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            // 指定打开文本文件（后缀名为txt）
            openDlg.Filter = "音乐文件|*.*";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                lbPath.Text = openDlg.FileName;
                axWindowsMediaPlayer1.URL = lbPath.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"insert  song_info values('{textBox1.Text}', '{textBox2.Text}', '{comboBox1.SelectedValue}', '{comboBox2.SelectedValue}','{lbPath.Text}',0)";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
            int r = cmd.ExecuteNonQuery();
            DBHelper.inst.Close();

            MessageBox.Show(r > 0 ? "新增成功" : "新增失败");
            if (r > 0) RefreshData();
        }

        private void RefreshData()
        {
            if (ds.Tables["song_info"] != null) ds.Tables["song_info"].Clear();
            string sql = "select song_id,singer_name,song_name,song_ab,song_url, songtype_name,song_play_count from song_info s join song_type b on s.songtype_id = b.songtype_id join singer_info si on si.singer_id=s.singer_id";
            //string sql = "select song_id,song_name,song_ab,song_url, songtype_name,song_play_count from song_info s join song_type b on s.songtype_id = b.songtype_id";
            adapter = new SqlDataAdapter(sql, DBHelper.inst.Conn);
            adapter.Fill(ds, "song_info");
            dataGridView1.DataSource = ds.Tables["song_info"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = $"update song_info set song_name='{textBox1.Text}',song_ab='{textBox2.Text}',songtype_id={comboBox1.SelectedValue},singer_id={comboBox2.SelectedValue},song_url='{lbPath.Text}' where song_id={lbId.Text}";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
            int r = cmd.ExecuteNonQuery();
            DBHelper.inst.Close();
            MessageBox.Show(r > 0 ? "修改成功" : "修改失败");
            if (r > 0) RefreshData();
        }
        private void Clear()
        {
            textBox1.Text = textBox2.Text = string.Empty;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (dataGridView1.SelectedRows[0].Cells[0].Value==null) return;
            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Equals(string.Empty)) return;
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            lbId.Text = dr.Cells[0].Value.ToString();
            textBox1.Text = dr.Cells[1].Value.ToString();
            textBox2.Text = dr.Cells[2].Value.ToString();
            comboBox1.Text = dr.Cells[3].Value.ToString();
            comboBox2.Text = dr.Cells[4].Value.ToString();
            lbPath.Text = dr.Cells[5].Value.ToString();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            string sql = $"delete from song_info where song_id={id}";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
            int r = cmd.ExecuteNonQuery();
            DBHelper.inst.Close();
            MessageBox.Show(r > 0 ? "删除成功" : "删除失败");
            if (r > 0) RefreshData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
