using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto
{
    class AnsoegningDto
    {
        // Properties
        public int AnsoegningId { get; private set; }
        public DateTime OprettetDato { get; private set; }
        public int? AntalLejere { get; private set; }
    }
}
