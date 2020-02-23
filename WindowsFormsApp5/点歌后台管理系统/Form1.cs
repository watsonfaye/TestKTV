using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 点歌后台管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
        }

        private void 歌手管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSinger fs = new FormSinger();
            fs.StartPosition = FormStartPosition.CenterScreen;
            fs.Show();
        }

        private void 歌曲管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSong formSong = new FormSong();
            formSong.StartPosition = FormStartPosition.CenterScreen;
            formSong.Show();
        }
    }
}
