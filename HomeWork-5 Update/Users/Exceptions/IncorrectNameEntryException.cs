namespace HomeWork_6_Update.Users.Exceptions
{
    internal class IncorrectNameEntryException : Exception
    {
        public IncorrectNameEntryException() { }

        public IncorrectNameEntryException(string message) : base(message)
        {

        }
    }
}
