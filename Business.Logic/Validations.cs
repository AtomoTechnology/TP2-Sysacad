using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class Validations
    {
        public  static  Boolean ValidateInput(string txt)
        {
            if (txt.Equals("") || txt == null)
                return false;
            else
                return true;
        }

        public static Boolean ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean ValidateDni(string legajo)
        {
            if (legajo is null || legajo.Length < 5)

                return false;
            else
                return true;
        }   

        
    }
}
