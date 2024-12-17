using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhapDiemBLL
    {
        public static void UpdateDiem(string cc, string bt, string gk, string ck)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                "";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
