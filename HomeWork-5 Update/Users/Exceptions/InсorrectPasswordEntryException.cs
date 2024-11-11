using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_Update.Users.Exceptions
{
    internal class IncorrectPasswordEntryException : Exception
    {
        public IncorrectPasswordEntryException()
        {

        }

        public IncorrectPasswordEntryException(string message) : base(message)
        {

        }
    }

}
