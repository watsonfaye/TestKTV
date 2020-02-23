using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] names = {"aaa","bbb","ccc","ddd","eee", "fff", "ggg", "hhh", "iii" };
        string[] photonames = { "9", "162", "332", "364", "951", "993", "1265", "23688", "25241" };
        string prePath = "C:\\Users\\Administrator\\Desktop\\KTVResource\\singers\\";
        string lastPath = ".jpg";
        int pageCount = 4; //一页显示几个
        int currentPage = 0;//当前是第几页
        int maxPage = 0; //总共有几页
        MyItem[] myItems;
        private void Form1_Load(object sender, EventArgs e)
        {
            myItems =new MyItem[] { myItem1, myItem2, myItem3, myItem4 };
            foreach (MyItem item in myItems) item.Visible = false;
            maxPage = names.Length / pageCount;

            ShowDatas();
            
            
        }

        private void ShowDatas()
        {
            for (int i = currentPage * pageCount,j=0; i < currentPage * pageCount+ pageCount; i++,j++)
            {
                if (i < names.Length) 
                {
                    myItems[j].Visible = true;
                    myItems[j].Text = names[i];
                    myItems[j].Url = prePath + photonames[i] + lastPath;
                }
                else
                {
                    myItems[j].Visible = false;
                }
            }
                button2.Enabled = currentPage != maxPage;
                button1.Enabled = currentPage != 0;
        }
        //向右翻
        private void button2_Click(object sender, EventArgs e)
        {
            
            currentPage++;
            ShowDatas();
        }
        //向左翻
        private void button1_Click(object sender, EventArgs e)
        {
            
            currentPage--;
            ShowDatas();
        }
    }
}
