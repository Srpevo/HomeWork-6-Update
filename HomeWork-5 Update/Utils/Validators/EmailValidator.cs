using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_Update.Utils.Validators
{
    internal static class EmailValidator
    {
        public static bool IsValidEmail(string Email)
        {
            int at_counter = Email.Count(x => x == '@');
            int dot_counter = Email.Count(x => x == '.');

            return at_counter == 1 && dot_counter == 1; 
        }
    }
}
