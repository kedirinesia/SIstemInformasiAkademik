using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemInformasiAkademik
{
    internal class Connection
    {
        public static SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection("Data Source=PULUNG\\SQLEXPRESS;Initial Catalog=AkademikTest;Integrated Security=True;Encrypt=False");
            return conn;
        }
        public static SqlConnection conn = new SqlConnection("Data Source=PULUNG\\SQLEXPRESS;Initial Catalog=AkademikTest;Integrated Security=True;Encrypt=False");
        public static SqlCommand cmd = new SqlCommand("",conn);

        public static Object getQuery(string query)
        {
            DataTable dt = new DataTable();
            conn.Open();
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();


            return dt;
        }

        public static void Exquery(string query)
        {
            conn.Open();
            cmd.CommandText = query;    
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
