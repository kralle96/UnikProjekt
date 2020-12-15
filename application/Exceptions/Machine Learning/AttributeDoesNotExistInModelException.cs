using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Exceptions
{
    //Exception til klasser der vedrører machine learning i Services
    class AttributeDoesNotExistInModelException : Exception
    {
        public AttributeDoesNotExistInModelException(string message) : base(message) { }

    }
}
