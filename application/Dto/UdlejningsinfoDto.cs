using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Dto
{
    public class UdlejningsinfoDto
    {
        // Properties
        public int UdlejningsinfoId { get; set; }
        public double MaanedligLeje { get; set; }
        public double MaanedligEl { get; set; }
        public double MaanedligVand { get; set; }
        public double MaanedligVarme { get; set; }
        public bool Internet { get; set; }
        public DateTime LedigFra { get; set; }
        public DateTime OvertagelseFra { get; set; }
        public string Status { get; set; }
    }
}
