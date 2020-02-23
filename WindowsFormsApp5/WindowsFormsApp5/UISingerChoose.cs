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
        int maxPage = 0; //总共有几页
        public MyItem[] myItems;
        public UISingerChoose()
        {
            InitializeComponent();
        }
        public void CenterPanel()
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }
        private void UISingerChoose_DockChanged(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void UISingerChoose_Load(object sender, EventArgs e)
        {
           
            myItems = new MyItem[] { myItem1, myItem2, myItem3, myItem4, myItem5 };
            
            foreach(MyItem item in myItems)
            {
                item.pictureBox.Click += OnSingerClick;
            }
            
        }

        private void ShowDatas()
        {
            for (int i = pageIndex * pageCount, j = 0; i < pageIndex * pageCount + pageCount; i++, j++)
            {
                if (i < singers.Length)
                {
                    myItems[j].Visible = true;
                    myItems[j].Text = singers[i].name;
                    myItems[j].Url = singers[i].photo_url;
                    myItems[j].id = singers[i].id;
                }
                else
                {
                    myItems[j].Visible = false;
                }
            }
            button2.Enabled = pageIndex != maxPage;
            button1.Enabled = pageIndex != 0;
        }

        private void ShowData()
        {
            singers = FindSinger.GetSingers();
            maxPage = singers.Length / pageCount;
        }

        private void OnSingerClick(object sender, EventArgs e)
        {
            PictureBox fp = (PictureBox)sender;
            MyItem item = (MyItem)fp.Parent;
            FindSong.singerID = item.id;
            UIControl.inst.ShowUI(UIType.SongChoose);
        }

        internal void RefreshData()
        {
            ShowData();
            ShowDatas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageIndex++;
            ShowDatas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageIndex--;
            ShowDatas();
        }
    }
}
