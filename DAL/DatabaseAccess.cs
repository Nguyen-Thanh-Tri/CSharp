using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.CompilerServices;
namespace DAL
{
    public class SqlConnectionData
    {
        //Tạo kết nối vs Database
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-RCFJJCH;Initial Catalog=QLSV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);//khởi tạo connect
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLoginDTO(Account account)
        {
            string user = null;
            //Connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_login", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", account.sUserName);
            command.Parameters.AddWithValue("@password", account.sPassWord);
            //thêm role sau
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            } else
            {
                return ("Tài khoản hoặc mật khẩu không chính xác");
            }
            return user;
        }
    }

    public static class GetData
    {
        public static DataTable SINHVIEN()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT ROW_NUMBER() OVER (ORDER BY PK_sMaSv) AS STT, PK_sMaSv AS [Mã sinh viên], sHovaTen AS [Họ và Tên], CASE WHEN sGioiTinh = '1' THEN 'Nam' ELSE N'Nữ' END AS [Giới tính], sLop AS [Lớp], sKhoa as [Khoa], sSoDienThoai AS [Số điện thoại], sDiaChi AS [Địa chỉ] FROM tbl_SinhVien WHERE deleted_at IS NULL", conn);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable GIANGVIEN()
        {
            SqlConnection conn =SqlConnectionData.Connect();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT ROW_NUMBER() OVER (ORDER BY PK_sMaGiangVien) AS STT, PK_sMaGiangVien AS [Mã giảng viên], sTenGiangVien AS [Tên Giảng Viên] FROM tbl_GiangVien", conn);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable MONHOC()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT ROW_NUMBER() OVER (ORDER BY PK_sMaMonHoc) AS STT, PK_sMaMonHoc AS [Mã môn học], sTenMonHoc AS [Tên môn học], sMaGiangVien AS [Mã giảng viên], sTenGiangVien AS [Tên giảng viên] FROM tbl_MonHoc WHERE deleted_at IS NULL", conn);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }
        public static DataTable cbbGIANGVIEN()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT PK_sMaGiangVien, sTenGiangVien FROM tbl_GiangVien", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable KHOA()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT PK_sMaKhoa, sTenKhoa FROM tbl_Khoa WHERE deleted_at IS NULL", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable cbbLop()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT tbl_GiangVien.sTenGiangVien, tbl_Khoa.sTenKhoa FROM tbl_GiangVien CROSS JOIN tbl_Khoa", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable LOP()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT PK_sMaLop, sTenLop, sKhoa, sGiangvien FROM tbl_Lop WHERE deleted_at IS NULL", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable cbbSV()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT PK_sMaSv, sHovaTen, sLop FROM tbl_SinhVien", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }
        
        public static DataTable cbbSV1()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT PK_sMaMonHoc, sTenMonHoc, sMaGiangVien, sTenGiangVien, PK_sMaHocKy FROM tbl_MonHoc CROSS JOIN tbl_HocKy WHERE tbl_MonHoc.deleted_at IS NULL", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable DANGKYMONHOC()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY sMaSV) AS [STT],sMaSV AS [Mã sinh viên], sHovaTen AS [Họ và Tên], sLop AS [Lớp], sMaGiangVien AS [Giảng viên], sMaHocKy AS [Học kỳ], sMaMH AS [Môn học], sTenMH AS [Tên môn học] FROM tbl_Diem WHERE deleted_at IS NULL", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable NHAPDIEM(sNhapDiem diem)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY sMaSV) AS [STT],sMaSV AS [Mã sinh viên], sHovaTen AS [Họ và Tên], sLop AS [Lớp], sDiemCC AS [Điểm chuyên cần], sDiemBT AS [Điểm bài tập], sDiemGK AS [Điểm giữa kỳ], sDiemCK AS [ĐIểm cuối kỳ], sDiemTB AS [Điểm trung bình] FROM tbl_Diem WHERE deleted_at IS NULL AND sTenMH=@TenMH AND sMaHocKy=@MaHK", conn);
            cmd.Parameters.AddWithValue("@TenMH", diem.sTenMH);
            cmd.Parameters.AddWithValue("@MaHK", diem.sMaHocKy);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable cbbDiem1()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT sMaMH, sTenMH FROM tbl_Diem ORDER BY sMaMH, sTenMH", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable cbbDiem2(string monhoc)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT sMaHocKy FROM tbl_Diem WHERE sTenMH = N'" + monhoc+"'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable DSSV1(SinhVien sv)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT ROW_NUMBER() OVER (ORDER BY PK_sMaSv) AS STT, PK_sMaSv AS [Mã sinh viên], sHovaTen AS [Họ và Tên], CASE WHEN sGioiTinh = '1' THEN 'Nam' ELSE N'Nữ' END AS [Giới tính], sLop AS [Lớp], sKhoa as [Khoa] FROM tbl_SinhVien WHERE deleted_at IS NULL AND sLop=@Lop", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@Lop", sv.sLop);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }
        public static DataTable DSSV2()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT sTenMH FROM tbl_Diem ORDER BY sTenMH", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }
        public static DataTable DSSV3()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT sLop, sKhoa FROM tbl_SinhVien ORDER BY sKhoa", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }

        public static DataTable DSSVDiem(sNhapDiem diem)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY sMaSV) AS STT, sMaSV AS [Mã sinh viên], sHovaTen  AS [Họ và Tên], sLop AS [Lớp], sDiemCC AS [Điểm chuyên cần], sDiemBT AS [Điểm bài tập], sDiemGK AS [Điểm giữa kỳ], sDiemCK AS [Điểm cuối kỳ], sDiemTB  AS [Điểm trung bình], sMaHocKy  AS [Học kỳ], sTenMH  AS [Học phần] FROM tbl_Diem WHERE sTenMH=@TenMH", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@TenMH", diem.sTenMH);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }   
        public static DataTable DSSVKhoa(SinhVien sv)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY PK_sMaSv) AS STT, PK_sMaSv AS [Mã sinh viên], sHovaTen AS [Họ và Tên], CASE WHEN sGioiTinh = '1' THEN 'Nam' ELSE N'Nữ' END AS [Giới tính], sLop AS [Lớp], sKhoa as [Khoa] FROM tbl_SinhVien WHERE deleted_at IS NULL AND sKhoa=@Khoa", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@Khoa", sv.sKhoa);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }
    }
}
