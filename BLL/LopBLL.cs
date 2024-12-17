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
    public class LopBLL
    {
        public static void Themlop(sLop lop)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                "INSERT INTO tbl_Lop(PK_sMalop, sTenLop, sKhoa, sGiangVien)" +
                    "VALUES (@Malop, @TenLop ," +
                        "(SELECT PK_sMaKhoa FROM tbl_Khoa WHERE sTenKhoa =@MaKhoa)," +
                        "(SELECT PK_sMaGiangVien FROM tbl_GiangVien WHERE sTenGiangVien =@GiangVien))";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaLop", lop.PK_sMaLop);
            cmd.Parameters.AddWithValue("@TenLop", lop.sTenLop);
            cmd.Parameters.AddWithValue("@MaKhoa", lop.sKhoa);
            cmd.Parameters.AddWithValue("@GiangVien", lop.sGiangVien);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void XoaLop(sLop lop)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_Lop SET deleted_at = GETDATE() WHERE PK_sMaLop = @MaLop", conn);
            cmd.Parameters.AddWithValue("@MaLop", lop.PK_sMaLop);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
