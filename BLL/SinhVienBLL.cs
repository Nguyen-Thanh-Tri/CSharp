using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class SinhVienBLL
    {
        public static void ThemSV(SinhVien sinhvien) {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query = 
                "INSERT INTO tbl_SinhVien (PK_sMaSv, sHovaTen, sGioiTinh, sNgaySinh, sLop, sKhoa, sSoDienThoai, sDiaChi, created_at) " +
                "VALUES (@MaSv, @HovaTen, @GioiTinh, @NgaySinh, @Lop, @Khoa, @SoDienThoai, @Diachi, GETDATE())";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSv", sinhvien.PK_sMaSv);
            cmd.Parameters.AddWithValue("@HovaTen", sinhvien.sHovaTen);
            cmd.Parameters.AddWithValue("@GioiTinh", sinhvien.sGioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", sinhvien.sNgaySinh);
            cmd.Parameters.AddWithValue("@Lop", sinhvien.sLop);
            cmd.Parameters.AddWithValue("@Khoa", sinhvien.sKhoa);
            cmd.Parameters.AddWithValue("@SoDienThoai", sinhvien.sSoDienThoai);
            cmd.Parameters.AddWithValue("@Diachi", sinhvien.sDiaChi);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void SuaSV(SinhVien sinhvien)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                " UPDATE tbl_SinhVien SET sHovaTen = @HovaTen, sGioiTinh = @GioiTinh," +
                "sLop = @Lop, sKhoa = @Khoa, sSoDienThoai = @SoDienThoai, sDiaChi = @DiaChi," +
                "updated_at = GETDATE() WHERE PK_sMaSv =@MaSv";
            SqlCommand cmd = new SqlCommand( query, conn);
            cmd.Parameters.AddWithValue("@MaSv", sinhvien.PK_sMaSv);
            cmd.Parameters.AddWithValue("@HovaTen", sinhvien.sHovaTen);
            cmd.Parameters.AddWithValue("@GioiTinh", sinhvien.sGioiTinh);
            cmd.Parameters.AddWithValue("@Lop", sinhvien.sLop);
            cmd.Parameters.AddWithValue("@Khoa", sinhvien.sKhoa);
            cmd.Parameters.AddWithValue("@SoDienThoai", sinhvien.sSoDienThoai);
            cmd.Parameters.AddWithValue("@Diachi", sinhvien.sDiaChi);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void XoaSV(SinhVien sinhvien)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                "UPDATE tbl_SinhVien SET deleted_at = GETDATE() WHERE PK_sMaSv = @MaSv";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSv", sinhvien.PK_sMaSv);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
