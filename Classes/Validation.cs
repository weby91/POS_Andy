using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Andy.Classes
{
    class Validation
    {
        public static string validate_Login(string un, string pw)
        {
            string result = "";

            un = un.ToLower();
            pw = pw.ToLower();

            if (un == "" || pw == "")
                result = "Username atau password tidak boleh kosong";
            else            
                result = Core.Login(un, pw);

            return result;
        }
    }
}
