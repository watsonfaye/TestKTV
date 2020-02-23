using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class UISexChoose : UserControl
    {
        public UISexChoose()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }
        //把panel居中
        public void CenterPanel()
        {
            panel1.Location = new Point((this.Width-panel1.Width) / 2, (this.Height-panel1.Height) / 2);
        }
        //性别选择点击事件
        private void label2_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            switch (lb.Text)
            {
                case "组合":
                    FindSinger.singerSex = "组合";
                    break;
                case "男歌手":
                    FindSinger.singerSex = "男";
                    break;
                case "女歌手":
                    FindSinger.singerSex = "女";
                    break;
            }

            UIControl.inst.ShowUI(UIType.AreaChoose);
        }

       

        private void UISingerChoose_DockChanged(object sender, EventArgs e)
        {
            CenterPanel();
        }

        internal void RefreshData()
        {
        }
    }
}
