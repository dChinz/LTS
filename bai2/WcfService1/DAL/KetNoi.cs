using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KetNoi
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GK5VJ4R;Initial Catalog=QLNhansu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public void ThucHien(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Load(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
