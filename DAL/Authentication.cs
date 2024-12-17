using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Authentication:DatabaseAccess
    {
        public string CheckLogin(Account account)
        {
            string infor = CheckLoginDTO(account);
            return infor;
        }
    }
}
