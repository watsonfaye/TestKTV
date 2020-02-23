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
    public partial class MyItem : UserControl
    {
        public int id;
        private string text;
        private string url;
        public PictureBox pictureBox;

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                label1.Text = value;
            }
        }

        public string Url {
            get { return url; }
            set { 
                url = value;
                if(url!=null)
                pictureBox1.Image = Image.FromFile(value); 
            }
        
        }
        public MyItem()
        {
            InitializeComponent();
        }
        private void MyItem_Load(object sender, EventArgs e)
        {
            this.pictureBox = pictureBox1;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
