using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Main : Form
    {
        public Panel container;
        public Main()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED 
                return cp;
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Visible = false;
            UIControl.inst.setMain(this);
            container = panel2;
            panel3.Location = new Point((panel2.Width - panel3.Width) / 2, (panel2.Height - panel3.Height) / 2);
        }
        public void ShowMainMenu(bool b)//为true时显示主菜单 
        {
            panel3.Visible = b;
            if (b)
            {
                toolStripLabel1.Visible = false;
                toolStripLabel6.Text = "退出";
            }
            else
            {
                toolStripLabel1.Visible = true;
                toolStripLabel6.Text = "主菜单";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UIControl.inst.ShowUI(UIType.SexChoose);
        }
        //功能按钮点击事件
        private void Handler_Click(object sender, EventArgs e)
        {
            ToolStripLabel tsl = (ToolStripLabel)sender;
            switch (tsl.Text)
            {
                case "重唱":
                    break;
                case "切歌":
                    break;
                case "已点":
                    break;
                case "服务":
                    break;
                case "退出":
                    Application.Exit();
                    break;
                case "返回":
                    UIControl.inst.ReturnUp();
                    break;
                case "主菜单":
                    UIControl.inst.ReturnMain();
                    break;
            }
        }
        //拼音点歌
        private void label4_Click(object sender, EventArgs e)
        {
            UIControl.inst.ShowUI(UIType.Pinyin);
        }
        //类型点歌
        private void label5_Click(object sender, EventArgs e)
        {
            UIControl.inst.ShowUI(UIType.SongType);
        }
    }
}
