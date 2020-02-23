﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class DBHelper
    {
        private static DBHelper dBHelper = new DBHelper();
        public static DBHelper inst
        {
            get
            {
                return dBHelper;
            }
        }
        private const string connStr = "Data Source=.;Initial Catalog=MyKTV;User Id=sa;Pwd=123456";
        private SqlConnection conn;
        public SqlConnection Conn
        {
            get
            {
                if (conn == null) conn = new SqlConnection(connStr);
                return conn;
            }
        }

        public void Open()
        {
            if(Conn.State== ConnectionState.Closed)
            {
                Conn.Open();
            }
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }

        }

        public void Close()
        {
            if (Conn.State == ConnectionState.Open || Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
            }
        }
    }
}
