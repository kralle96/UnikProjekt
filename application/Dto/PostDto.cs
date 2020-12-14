using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class PostDto
    {
        // Properties
        public int PostNr { get; set; }
        public string By { get; set; }
        public string? Region { get; set; }
    }
}
