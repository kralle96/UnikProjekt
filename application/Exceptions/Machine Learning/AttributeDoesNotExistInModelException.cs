﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    class AttributeDoesNotExistInModelException : Exception
    {
        public AttributeDoesNotExistInModelException(string message) : base(message) { }

    }
}
