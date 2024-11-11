using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_Update.Users.Base
{
    internal abstract class Account
    {

        public Account()
        {

        }

        public Account(string Name, string Password, string Email)
        {
            _name = Name;
            _password = Password;
            _email = Email;
        }


        public string _name {  get; set; }
        public string _email { get; set; }
        public string _password { get; set; }



    }
}
