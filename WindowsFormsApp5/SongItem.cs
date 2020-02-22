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
    public partial class SongItem : UserControl
    {
        private string songName;
        private int songIndex;
        public string SongName
        {
            get { return songName; }
            set
            {
                songName = value;
                label2.Text = value;
            }
        }

        public int SongIndex
        {
            get { return songIndex; }
            set
            {
                songIndex = value;
                label1.Text = value.ToString();
            }

        }
        public SongItem()
        {
            InitializeComponent();
        }
    }
}
