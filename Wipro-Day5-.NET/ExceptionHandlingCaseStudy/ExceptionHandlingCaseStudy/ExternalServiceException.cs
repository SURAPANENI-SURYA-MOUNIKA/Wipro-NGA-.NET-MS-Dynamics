using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingCaseStudy.CustomException
{
    // This exception is thrown when external services fail
    // (example: payment gateway is down)
    public class ExternalServiceException : Exception
    {
        public ExternalServiceException(string message)
            : base(message)
        {
        }
    }
}
