namespace App.Exception
{
    /// <summary>
    /// BaseException Class
    /// Author: Alexandru Emil Popa
    /// </summary>
    public abstract class BaseException : System.Exception
    {
        private string message;

        public BaseException(string message) : base(message) { }

        public string getMessage()
        {
            return message;
        }
    }
}
