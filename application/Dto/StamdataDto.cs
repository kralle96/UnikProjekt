using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class StamdataDto
    {
        // Properties
        public int StamdataId { get; private set; }
        public string Fornavn { get; private set; }
        public string Efternavn { get; private set; }
        public int Postnr { get; private set; }
        public string Adresse { get; private set; }
        public int Telefonnr { get; private set; }
        public string Email { get; private set; }
        public string? Køn { get; private set; }
        public DateTime Fødselsdato { get; private set; }
    }
}
