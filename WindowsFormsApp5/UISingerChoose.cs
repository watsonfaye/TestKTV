using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class UISingerChoose : UserControl
    {
        public Singer[] singers;
        public int pageIndex = 0;//当前是第几页
        public int pageCount = 5;//一页显示几个
        public UISingerChoose()
        {
            InitializeComponent();
        }
        public void CenterPanel()
        {
            flowLayoutPanel1.Location = new Point((this.Width - flowLayoutPanel1.Width) / 2, (this.Height - flowLayoutPanel1.Height) / 2);
        }
        private void UISingerChoose_DockChanged(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void UISingerChoose_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            singers = FindSinger.GetSingers();
            ShowSingers();
        }
        //把数组里的歌手显示出来
        private void ShowSingers()
        {
            for (int i = pageIndex*pageCount; i < pageIndex*pageCount+5; i++)
            {
                if (i < singers.Length && singers[i]!=null)
                {
                    FlowLayoutPanel fp = new FlowLayoutPanel();
                    
                    fp.Size = new Size(150, 250);
                    fp.FlowDirection = FlowDirection.TopDown;
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(150, 150);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Image = Image.FromFile(singers[i].photo_url);
                    pb.Click += OnSingerClick;
                    pb.Name = singers[i].id.ToString();
                    Label lb = new Label();
                    lb.AutoSize = false;
                    lb.Size = new Size(150,50);
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.ForeColor = Color.White;
                    lb.Font = new Font("微软雅黑",15);
                    lb.Text = singers[i].name;
                    fp.Controls.Add(pb);
                    fp.Controls.Add(lb);
                    flowLayoutPanel1.Controls.Add(fp);
                }
            }
        }

        private void OnSingerClick(object sender, EventArgs e)
        {
            PictureBox fp = (PictureBox)sender;
            FindSong.singerID = int.Parse(fp.Name);
            UIControl.inst.ShowUI(UIType.SongChoose);
        }
    }
}
