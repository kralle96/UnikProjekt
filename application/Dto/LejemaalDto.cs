using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Dto
{
    //Dto til at vidergive data mellem lagene
    public class LejemaalDto
    {
        // Properties
        public int LejemaalsId { get; set; }
        public string Adresse { get; set; }
        public bool? Husdyr { get; set; }
        public bool? Ryger { get; set; }
        public int Vaerelser { get; set; }
        public int Stoerrelse { get; set; }
        public string? Energimaerke { get; set; }
        public string Type { get; set; }
    }
}
