using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhoaBLL
    {
        public static void ThemKhoa(sKhoa khoa)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                "INSERT INTO tbl_Khoa (PK_sMaKhoa,sTenKhoa)" +
                "VALUES(@MaKhoa, @TenKhoa)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaKhoa", khoa.PK_sMaKhoa);
            cmd.Parameters.AddWithValue("@TenKhoa", khoa.sTenKhoa);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void XoaKhoa(sKhoa khoa)
        {
            SqlConnection conn =SqlConnectionData.Connect();
            conn.Open();
            string query =
                             "UPDATE tbl_Khoa SET deleted_at = GETDATE() WHERE PK_sMaKhoa = @MaKhoa";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaKhoa", khoa.PK_sMaKhoa);
            cmd.ExecuteNonQuery ();
            conn.Close();
        }
    }
}
