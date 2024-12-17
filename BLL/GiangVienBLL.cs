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
    public class GiangVienBLL
    {
        public static void ThemGV(GiangVien giangvien)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                "INSERT INTO tbl_GiangVien (PK_sMaGiangVien, sTenGiangVien)"+
                "VALUES(@MaGV, @TenGV)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaGV", giangvien.PK_sMaGiangVien);
            cmd.Parameters.AddWithValue("@TenGV", giangvien.sTenGiangVien);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
