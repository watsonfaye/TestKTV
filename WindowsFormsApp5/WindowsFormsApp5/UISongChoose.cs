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
    public partial class UISongChoose : UserControl
    {
        public Song[] songs;
        public int pageIndex = 0;//当前是第几页
        public int pageCount = 10;//一页显示几个
        public int maxPage = 0; //总共有几页
        public SongItem[] songItems;
        public UISongChoose()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
                return parms;
            }
        }
        public void RefreshData()
        {
            ShowSongList();
        }
        private void UISongChoose_Load(object sender, EventArgs e)
        {
            InitSongList();
        }

        private void ShowSongList()
        {
            songs = FindSong.GetSongs();
            maxPage = songs.Length / pageCount;
            ShowData();
        }

       
        private void InitSongList()
        {
            songItems = new SongItem[] { songItem1, songItem2, songItem3, songItem4, songItem5, songItem6, songItem7, songItem8, songItem9 ,songItem10};
        }

        private void ShowData()
        {
            for (int i = pageIndex*pageCount,j=0; i < pageIndex * pageCount+ pageCount; i++,j++)
            {
                if (i< songs.Length)
                {
                    songItems[j].Visible = true;
                    songItems[j].SongName = songs[i].name;
                    songItems[j].SongIndex = pageIndex * pageCount+1+j;
                }
                else
                {
                    songItems[j].Visible = false;
                }
            }
            button1.Enabled = pageIndex != 0;
            button2.Enabled = pageIndex != maxPage;
        }

        public void CenterPanel()
        {
            flowLayoutPanel1.Location = new Point((this.Width - flowLayoutPanel1.Width) / 2, (this.Height - flowLayoutPanel1.Height) / 2);
        }
        private void UISongChoose_DockChanged(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageIndex++;
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageIndex--;
            ShowData();
        }

    }
}
