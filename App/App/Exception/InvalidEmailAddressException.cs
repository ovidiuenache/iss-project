namespace App.Exception
{
    /// <summary>
    /// InvalidEmailAddressException Class
    /// Author: Alexandru Emil Popa
    /// </summary>
    public class InvalidEmailAddressException : BaseException
    {
        public InvalidEmailAddressException(string message) : base(message) { }
    }
}
