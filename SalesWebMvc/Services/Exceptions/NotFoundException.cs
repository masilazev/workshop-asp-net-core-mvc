using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class ApplicationdException : ApplicationException
    {
        public ApplicationdException(string message) : base(message)
        {

        }
    }
}
