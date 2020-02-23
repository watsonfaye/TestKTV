using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    /// <summary>
    /// 按类型查找歌曲类
    /// </summary>
    public class FindType
    {
        public static string Songtype;
        internal static Song[] GetSongs()
        {
            int count = DB.GetCount($"select count(*) from song_info s join song_type st on s.songtype_id = st.songtype_id where songtype_name='{Songtype}';");
            Song[] arr = new Song[count];
            string sql = $"select * from song_info s join song_type st on s.songtype_id = st.songtype_id where songtype_name='{Songtype}'";
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
                s.count = (int)dr["song_play_count"];
                s.singer_id = (int)dr["singer_id"];
                s.ab = dr["song_ab"].ToString();
                arr[index++] = s;
            }
            DBHelper.inst.Close();
            return arr;
        }

    }
}
