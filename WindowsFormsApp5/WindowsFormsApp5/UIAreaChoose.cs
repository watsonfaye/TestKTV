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
    public partial class UIAreaChoose : UserControl
    {
        public UIAreaChoose()
        {
            InitializeComponent();
        }

        public void CenterPanel()
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        private void UIAreaChoose_DockChanged(object sender, EventArgs e)
        {
            CenterPanel();
        }
        //区域选择点击事件
        private void Area_Choosed(object sender, EventArgs e)
        {
            Label lb = (Label)sender;

            switch (lb.Text)
            {
                case "大陆": FindSinger.singerArea = 1;break;
                case "香港": FindSinger.singerArea = 2;break;
                case "台湾": FindSinger.singerArea = 3;break;
                case "欧美": FindSinger.singerArea = 4;break;
                case "日韩": FindSinger.singerArea = 5;break;
            }
            UIControl.inst.ShowUI(UIType.SingerChoose);
        }

        internal void RefreshData()
        {
        }

        private void UIAreaChoose_Load(object sender, EventArgs e)
        {

        }
    }

   
}
