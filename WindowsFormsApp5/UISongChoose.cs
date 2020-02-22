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
        public UISongChoose()
        {
            InitializeComponent();
        }

        private void UISongChoose_Load(object sender, EventArgs e)
        {
            InitSongList();
            ShowSongList();
        }

        private void ShowSongList()
        {
            Song[] arr = FindSong.GetSongs();
            for (int i = 0; i < 10; i++)
            {
                if (i < arr.Length)
                {
                    songs[i].Visible = true;
                    songs[i].SongName=
                }
            }
        }

        SongItem[] songs;
        private void InitSongList()
        {
            songs = new SongItem[] { songItem1, songItem2, songItem3, songItem4, songItem5, songItem6, songItem7, songItem8, songItem9 };
            foreach(SongItem item in songs)
            {
                item.Visible = false;
            }
        }

        public void CenterPanel()
        {
            flowLayoutPanel1.Location = new Point((this.Width - flowLayoutPanel1.Width) / 2, (this.Height - flowLayoutPanel1.Height) / 2);
        }
        private void UISongChoose_DockChanged(object sender, EventArgs e)
        {
            CenterPanel();
        }
    }
}
