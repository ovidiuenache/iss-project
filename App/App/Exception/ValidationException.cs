namespace App.Exception
{
    /// <summary>
    /// ValidationException Class
    /// Author: Alexandru Emil Popa
    /// </summary>
    public class ValidationException : BaseException
    {
        public ValidationException(string message) : base(message) { }
    }
}
