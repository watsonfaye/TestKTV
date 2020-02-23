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
    public partial class UIPinyinChoose : UserControl
    {
        public Song[] songs;
        public int pageIndex = 0;//当前是第几页
        public int pageCount = 6;//一页显示几个
        public int maxPage = 0; //总共有几页
        public SongItem[] songItems;
        public UIPinyinChoose()
        {
            InitializeComponent();
        }

        internal void RefreshData()
        {
        }

        private void ShowData()
        {
            for (int i = pageIndex * pageCount, j = 0; i < pageIndex * pageCount + pageCount; i++, j++)
            {
                if (i < songs.Length)
                {
                    songItems[j].Visible = true;
                    songItems[j].SongName = songs[i].name;
                    songItems[j].SongIndex = pageIndex * pageCount + 1 + j;
                }
                else
                {
                    songItems[j].Visible = false;
                }
            }
            button1.Enabled = pageIndex != 0;
            button2.Enabled = pageIndex != maxPage;
        }

        private void PinyinRequestSong_Load(object sender, EventArgs e)
        {
            InitSongList();
        }

        private void InitSongList()
        {
            songItems = new SongItem[] { songItem1, songItem2, songItem3, songItem4, songItem5, songItem6 };
            for (int i = 0; i < songItems.Length; i++)
            {
                songItems[i].Visible = false;
            }
        }
        private Song[] GetSongs()
        {
            string s = textBox1.Text;
            if (s.Length <= 0) return null;
            string blurStr = "";
                
            foreach(char c in s)
            {
                blurStr += c + "%";
            }
            int count = DB.GetCount($"select count(*) from song_info where song_ab like '%{blurStr}'");
            Song[] arr = new Song[count];
            string sql = $"select * from song_info where song_ab like '%{blurStr}'";
            DBHelper.inst.Open();
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            SqlDataReader r = cmd.ExecuteReader();
            int index = 0;
            while (r.Read())
            {
                Song s1 = new Song();
                s1.name = r["song_name"].ToString();
                s1.url = r["song_url"].ToString();
                s1.id = (int)r["song_id"];
                s1.songtype_id = (int)r["songtype_id"];
                s1.count = (int)r["song_play_count"];
                s1.singer_id = (int)r["singer_id"];
                s1.ab = r["song_ab"].ToString();
                arr[index++] = s1;
            }
            DBHelper.inst.Close();
            return arr;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            songs = GetSongs();
            if (songs == null) return;
            maxPage = songs.Length / pageCount;
            ShowData();
        }

        private void flowLayoutPanel1_DockChanged(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            flowLayoutPanel1.Location = new Point((this.Width - flowLayoutPanel1.Width) / 2, (this.Height - flowLayoutPanel1.Height) / 2);
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
