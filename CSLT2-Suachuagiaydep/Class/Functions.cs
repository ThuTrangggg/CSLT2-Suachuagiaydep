using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace CSLT2_Suachuagiaydep
{
    internal class Functions
    {
        public static SqlConnection Conn;
        public static string connString;
        public static void connect()
        {
            Conn = new SqlConnection();
            connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\BTL_CSLT2\\CSLT2-Suachuagiaydep\\QuanLyGiayDep.mdf;Integrated Security=True;Connect Timeout=30";
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
        public static bool checkkey(string sql) //kiem tra trung ma CL 
        {
            SqlDataAdapter a = new SqlDataAdapter(sql, Functions.Conn);
            a.SelectCommand = new SqlCommand();
            a.SelectCommand.Connection = Functions.Conn;
            a.SelectCommand.CommandText = sql;
            DataTable bang = new DataTable();
            a.Fill(bang);
            if (bang.Rows.Count > 0)
                return true;
            else
                return false;

        }
        public static void runsql(string sql)
        {
            SqlCommand cmd = new SqlCommand(); //khai bao doi tuong cmd
            cmd.Connection = Functions.Conn; // khoi tao doi tuong
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception loi)
            {
                MessageBox.Show(loi.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void fillcombo(string sql, ComboBox cb, string ma, string hienthi)
        {
            SqlDataAdapter a = new SqlDataAdapter(sql,Functions.Conn);
            DataTable table = new DataTable();
            a.Fill(table);
            cb.DataSource = table;
            cb.ValueMember = ma;
            cb.DisplayMember = hienthi;
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Functions.Conn);
            SqlDataReader a;
            a = cmd.ExecuteReader();
            while (a.Read())
            {
                ma = a.GetValue(0).ToString();
            }
            a.Close();
            return ma;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }


    }
}