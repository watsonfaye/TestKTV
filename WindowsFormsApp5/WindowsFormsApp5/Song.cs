using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Song
    {
        public int id;
        public string name;//歌名
        public string ab;//拼音
        public int songtype_id;//歌曲类型ID
        public int singer_id;//歌手ID
        public string url;//歌的地址
        public int count;//歌的播放次数
    }
}
