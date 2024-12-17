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
    public class NhapDiemBLL
    {
        public static void UpdateDiem(sNhapDiem diem)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                "IF EXISTS (SELECT 1 FROM tbl_Diem WHERE sTenMH=@TenMH AND sMaHocKy=@MaHK AND sMaSV=@MaSV)"+
                    "UPDATE tbl_Diem "+
                    "SET sDiemCC=@DiemCC, sDiemBT=@DiemBT, sDiemGK=@DiemGK, sDiemCK=@DiemCK, sDiemTB=@DiemTB "+
                    "WHERE sTenMH=@TenMH AND sMaHocKy=@MaHK AND sMaSV=@MaSV";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TenMH", diem.sTenMH);
            cmd.Parameters.AddWithValue("@MaHK", diem.sMaHocKy);
            cmd.Parameters.AddWithValue("@MaSV", string.IsNullOrEmpty(diem.sMaSV) ? (object)DBNull.Value : diem.sMaSV);
            cmd.Parameters.AddWithValue("@DiemCC", diem.sDiemCC.HasValue ? (object)diem.sDiemCC : DBNull.Value);
            cmd.Parameters.AddWithValue("@DiemBT", diem.sDiemBT.HasValue ? (object)diem.sDiemBT : DBNull.Value);
            cmd.Parameters.AddWithValue("@DiemGK", diem.sDiemGK.HasValue ? (object)diem.sDiemGK : DBNull.Value);
            cmd.Parameters.AddWithValue("@DiemCK", diem.sDiemCK.HasValue ? (object)diem.sDiemCK : DBNull.Value);
            cmd.Parameters.AddWithValue("@DiemTB", diem.sDiemTB.HasValue ? (object)diem.sDiemTB : DBNull.Value);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
