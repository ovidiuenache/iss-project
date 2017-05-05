namespace App.Exception
{
    public class InvalidEmailAddressException : BaseException
    {
        public InvalidEmailAddressException(string message) : base(message) { }
    }
}
