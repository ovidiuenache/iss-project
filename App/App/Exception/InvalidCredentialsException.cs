namespace App.Exception
{
    public class InvalidCredentialsException : BaseException
    {
        public InvalidCredentialsException(string message) : base(message) { }
    }
}
