using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    /// <summary>
    /// 查找歌手类
    /// </summary>
    public class FindSinger
    {
        public static string singerSex; //歌手性别  男，女，组合
        public static int singerArea; //歌手区域
        //获取歌手列表
        public static Singer[] GetSingers()
        {
            int count = DB.GetCount($"select count(*) from singer_info where singertype_id={singerArea} and singer_sex='{singerSex}'");
            Singer[] arr = new Singer[count];
            string sql = $"select * from singer_info where singertype_id={singerArea} and singer_sex='{singerSex}'";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int index = 0;
            while (dr.Read())
            {
                Singer s = new Singer();
                s.name = dr["singer_name"].ToString();
                s.photo_url = dr["singer_photo_url"].ToString();
                s.id = (int)dr["singer_id"];
                s.sex = dr["singer_sex"].ToString();
                s.singertype_id = (int)dr["singertype_id"];
                arr[index++] = s;
            }
            DBHelper.inst.Close();
            return arr;
        }

    }
}
