using System;

namespace Week2Services
{
    public class MovieSchedulingException : Exception
    {
        public MovieSchedulingException():base()
        {
        }

        public MovieSchedulingException(string message) : base(message)
        {
        }

        public MovieSchedulingException(string message, Exception innerException): base(message, innerException)
        {
            
        }
    }
}