namespace App.Exception
{
    /// <summary>
    /// InvalidCredentialsException Class
    /// Author: Alexandru Emil Popa
    /// </summary>
    public class InvalidCredentialsException : BaseException
    {
        public InvalidCredentialsException(string message) : base(message) { }
    }
}
