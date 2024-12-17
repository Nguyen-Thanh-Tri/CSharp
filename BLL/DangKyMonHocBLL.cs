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
    public class DangKyMonHocBLL
    {
        //public static void DangKy(sDangKyMonHoc mon)
        //{
        //    SqlConnection conn = SqlConnectionData.Connect();
        //    conn.Open();
        //    string query = 
        //        "INSERT INTO tbl_DangKyMonHoc(sMaSV, sHovaTen, sLop, sMaMonHoc, sTenMonHoc, sMaHocKy)"+
        //        "VALUES (@MaSV, @Ten, @Lop, @MaMH, @TenMH, @MaHK)";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    cmd.Parameters.AddWithValue("@MaSV", mon.sMaSV);
        //    cmd.Parameters.AddWithValue("@Ten", mon.sHovaTen);
        //    cmd.Parameters.AddWithValue("@Lop", mon.sLop);
        //    cmd.Parameters.AddWithValue("@MaMH", mon.sMaMonHoc);
        //    cmd.Parameters.AddWithValue("@TenMH", mon.sTenMonHoc);
        //    cmd.Parameters.AddWithValue("@MaHK", mon.sMaHocKy);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}
        public static void DangKy(sNhapDiem diem)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                "INSERT INTO tbl_Diem(sMaSV, sHovaTen, sLop, sMaGiangVien ,sMaHocKy, sMaMH, sTenMh)" +
                "VALUES (@MaSV, @Ten, @Lop, @MaGV, @MaHK, @MaMH, @TenMH)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSV", diem.sMaSV);
            cmd.Parameters.AddWithValue("@Ten", diem.sHovaTen);
            cmd.Parameters.AddWithValue("@Lop", diem.sLop);
            cmd.Parameters.AddWithValue("@MaGV", diem.sMaGiangVien);
            cmd.Parameters.AddWithValue("@MaHK", diem.sMaHocKy);
            cmd.Parameters.AddWithValue("@MaMH", diem.sMaMH);
            cmd.Parameters.AddWithValue("@TenMH", diem.sTenMH);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Xoa(sNhapDiem diem)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                "UPDATE tbl_Diem SET deleted_at = GETDATE() WHERE sMaSV = @MaSV AND sMaMH = @MaMH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSV", diem.sMaSV);
            cmd.Parameters.AddWithValue("@MaMH", diem.sMaMH);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
