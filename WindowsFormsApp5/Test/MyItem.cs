using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class MyItem : UserControl
    {
        private string text;
        private string url;
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
    }
}
