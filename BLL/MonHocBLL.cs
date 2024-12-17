using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonHocBLL
    {
        public static void ThemMH(MonHoc monhoc)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                "INSERT INTO tbl_MonHoc (PK_sMaMonHoc, sTenMonHoc, sMaGiangVien, sTenGiangVien)"+
                "VALUES (@MaMH, @TenMH, @MaGV, @TenGV)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaMH", monhoc.PK_sMaMonHoc);
            cmd.Parameters.AddWithValue("@TenMH", monhoc.sTenMonHoc);
            cmd.Parameters.AddWithValue("@MaGV", monhoc.SMaGiangVien);
            cmd.Parameters.AddWithValue("@TenGV", monhoc.sTenGiangVien);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void SuaMH(MonHoc monhoc)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open ();
            string query =
                "UPDATE tbl_MonHoc SET sTenMonHoc = @TenMH, sMaGiangVien = @MaGV, sTenGiangVien = @TenGV WHERE PK_sMaMonHoc = @MaMH";
            SqlCommand cmd = new SqlCommand (query, conn);
            cmd.Parameters.AddWithValue("@MaMH", monhoc.PK_sMaMonHoc);
            cmd.Parameters.AddWithValue("@TenMH", monhoc.sTenMonHoc);
            cmd.Parameters.AddWithValue("@MaGV", monhoc.SMaGiangVien);
            cmd.Parameters.AddWithValue("@TenGV", monhoc.sTenGiangVien);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void XoaMH(MonHoc monhoc)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open ();
            string query =
                "UPDATE tbl_MonHoc SET deleted_at = GETDATE() WHERE PK_SMaMonHoc = @MaMH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaMH", monhoc.PK_sMaMonHoc);
            cmd.ExecuteNonQuery();
            conn.Close(); 
        }
    }
}
