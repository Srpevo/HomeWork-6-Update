namespace HomeWork_6_Update.Users.Exceptions
{
    internal class IncorrectEmailEntryException : Exception
    {
        public IncorrectEmailEntryException() { }

        public IncorrectEmailEntryException(string message) : base(message) { }

    }
}
