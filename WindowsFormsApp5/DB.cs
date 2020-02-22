using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class DB
    {
        public static int GetCount(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
            int r=(int)cmd.ExecuteScalar();
            DBHelper.inst.Close();
            return r;
        }

        public static int ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, DBHelper.inst.Conn);
            DBHelper.inst.Open();
            int r = (int)cmd.ExecuteNonQuery();
            DBHelper.inst.Close();
            return r;
        }
    }
}
