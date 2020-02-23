using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    //查找歌曲
    public class FindSong
    {
        public static int SongtypeID; //歌曲类型ID
        public static int singerID;  //歌手ID
        public static int findType;  //0就是按歌手找，1就是按类型找 2 字数找
        internal static Song[] GetSongs()
        {
            string sqlCondition="";
            switch (findType)
            {
                case 0: sqlCondition = $"singer_id={singerID}"; break;
                case 1: sqlCondition = $"songtype_id={SongtypeID}"; break;
                case 2: sqlCondition = "";break;

            }
            int count = DB.GetCount($"select count(*) from song_info where {sqlCondition}");
            Song[] arr = new Song[count];
            string sql = $"select * from song_info where {sqlCondition}";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int index = 0;
            while (dr.Read())
            {
                Song s = new Song();
                s.name = dr["song_name"].ToString();
                s.url = dr["song_url"].ToString();
                s.id = (int)dr["song_id"];
                s.songtype_id = (int)dr["songtype_id"];
                s.count=(int)dr["song_play_count"];
                s.singer_id= (int)dr["singer_id"];
                s.ab = dr["song_ab"].ToString();
                arr[index++] = s;
            }
            DBHelper.inst.Close();
            return arr;
        }
    }
}
