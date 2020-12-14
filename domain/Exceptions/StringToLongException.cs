using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Exceptions
{
    class StringToLongException : Exception
    {
        public StringToLongException(string message) : base(message)
        {

        }
    }
}
