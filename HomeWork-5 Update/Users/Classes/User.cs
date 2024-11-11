using HomeWork_6_Update.Users.Exceptions;
using HomeWork_6_Update.Users.Base;
using HomeWork_6_Update.Utils.Validators;

namespace HomeWork_6_Update.Users.Classes
{
    internal class User : Account
    {
        public User() : base()
        {
            
        }

        public User(string Name, string Password, string Email) : base(Name, Password, Email)
        {

        }

        private bool ContainsOnlyOnce(string Email, char Target)
        {
            int Counter = Email.Count(x => x == Target);
            return Counter == 1;
        }

        public string name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new IncorrectNameEntryException("Name cannot be empty or whitespace.");
                }
            }
        }

        public string email
        {
            get => _email;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (!(value.Contains("@") && value.Contains(".")))
                    {
                        throw new IncorrectEmailEntryException("mail must contain these (@, .) signs");
                    }
                    if (EmailValidator.IsValidEmail(value) && EmailValidator.IsValidEmail(value))
                    {
                        _email = value;
                    }
                    else
                    {
                        throw new IncorrectEmailEntryException("An email address cannot contain these characters more than once (@, .)");
                    }
                }
                else
                {
                    throw new IncorrectEmailEntryException("Email cannot be empty or whitespace.");
                }
            }
        }

        public string password
        {
            get => _password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value.Length >= 10)
                    {
                        _password = value;
                    }
                    else
                    {
                        throw new IncorrectPasswordEntryException("password length must be greater than or equal to 10");
                    }
                }
                else
                {
                    throw new IncorrectPasswordEntryException("Password cannot be empty or whitespace.");
                }
            }
        }
    }
}
