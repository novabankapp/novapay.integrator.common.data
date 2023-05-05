using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPay.Integrator.Common.Services.Exceptions
{
    public class ValidationErrorException : Exception
    {
        public ValidationErrorException(string msg) : base(msg) { }

        public ValidationErrorException(string msg, Exception inner) : base(msg, inner) { }
    }
}
