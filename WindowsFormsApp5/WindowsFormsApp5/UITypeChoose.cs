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
                    FindSong.SongtypeID = 1;
                    break;
                case "金典老歌":
                    FindSong.SongtypeID = 2;
                    break;
                case "影视金曲":
                    FindSong.SongtypeID = 3;
                    break;
                case "游戏动漫":
                    FindSong.SongtypeID = 4;
                    break;
                case "戏曲":
                    FindSong.SongtypeID = 5;
                    break;
                case "儿歌":
                    FindSong.SongtypeID = 6;
                    break;
            }
            FindSong.findType = 1;
            UIControl.inst.ShowUI(UIType.SongChoose);
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
