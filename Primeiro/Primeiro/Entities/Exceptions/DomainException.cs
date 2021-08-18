using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message)
        {

        }
    }
}
