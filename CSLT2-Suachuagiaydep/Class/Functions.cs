using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CSLT2_Suachuagiaydep
{
    internal class Functions
    {
        public static SqlConnection Conn;
        public static string connString;
        public static void connect()
        {
            Conn = new SqlConnection();
            connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\QuanLyGiayDep.mdf;Integrated Security=True;Connect Timeout=30";
            Conn.ConnectionString = connString;
            Conn.Open();
        }
        public static void disconnect()
        {
            if(Conn.State == ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter a = new SqlDataAdapter(sql,Functions.Conn);
            DataTable table = new DataTable();
            a.Fill(table);
            return table;
        }

    }
}