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
    public partial class UITypeChoose : UserControl
    {
        public UITypeChoose()
        {
            InitializeComponent();
        }

        internal void RefreshData()
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            switch (lb.Text)
            {
                case "热门流行":
                    FindType.Songtype = "热门流行";
                    break;
                case "金典老歌":
                    FindType.Songtype = "金典老歌";
                    break;
                case "影视金曲":
                    FindType.Songtype = "影视金曲";
                    break;
                case "游戏动漫":
                    FindType.Songtype = "游戏动漫";
                    break;
                case "戏曲":
                    FindType.Songtype = "戏曲";
                    break;
                case "儿歌":
                    FindType.Songtype = "儿歌";
                    break;
            }
            UIControl.inst.ShowUI(UIType.SongTypeChoose);
        }

        private void UITypeChoose_Load(object sender, EventArgs e)
        {

        }

        private void UITypeChoose_DockChanged(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }
    }
}
