namespace App.Exception
{
    public class InvalidPasswordException : BaseException
    {
        public InvalidPasswordException(string message) : base(message) { }
    }
}
