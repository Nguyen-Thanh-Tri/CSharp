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
    public class Admin
    {
        public static void CreateAccount(string a, string b)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query =
                "IF NOT EXISTS (SELECT 1 FROM tbl_taikhoan WHERE sUserName = @user) "+
                "BEGIN " +
                    "INSERT INTO tbl_taikhoan(sUserName, sPassWord, FK_iRole) "+
                    "VALUES(@user, @pass, 2) "+
                "END";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", a);
            cmd.Parameters.AddWithValue("@pass", b);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
