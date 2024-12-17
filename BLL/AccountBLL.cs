using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class AccountBLL
    {
        Authentication AccountAccess = new Authentication();
        public string CheckLogin(Account account)
        {
            //Kiểm tra nghiệp vụ
            if (account.sUserName =="" )
            {
                return ("required_username");
            }

            if (account.sPassWord =="")
            {
                return ("required_password");
            }

            string infor = AccountAccess.CheckLogin(account);
            return infor;
            
        }
    }
}
