using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Dto
{
    public class StatistikLejeperiodeLejersAlderDto
    {
        // Properties
        public int StatistikLejerperiodeLejersAlderId { get; set; }
        public DateTime DatoSøgt { get; set; }
        public int AlderFra { get; set; }
        public int AlderTil { get; set; }
        public int LejeperiodeGennemsnit { get; set; }
    }
}
