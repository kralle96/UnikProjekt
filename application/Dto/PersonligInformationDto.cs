using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class PersonligInformationDto
    {
        public int PersonligInformationId { get; private set; }
        public bool Husdyr { get; private set; }
        public bool Ryger { get; private set; }
    }
}
