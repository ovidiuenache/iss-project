namespace App.Exception
{
    /// <summary>
    /// InvalidPasswordException Class
    /// Author: Alexandru Emil Popa
    /// </summary>
    public class InvalidPasswordException : BaseException
    {
        public InvalidPasswordException(string message) : base(message) { }
    }
}
