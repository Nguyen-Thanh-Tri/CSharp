using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string sNameAccount { get; set; }
        public string sUserName { get; set; }
        public string sPassWord { get; set; }
        public int   FK_iRole { get; set; }
    }
}
