using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class HjemmeboendeBoern
    {
        // Properties
        public int Id { get; private set; }
        public DateTime? Foedselsdato { get; private set; }

        // Constructor til EF
        public HjemmeboendeBoern() { }

        // Constructor
        private HjemmeboendeBoern(int id, DateTime? foedselsdato)
        {
            Id = id;
            Foedselsdato = foedselsdato;
        }

        // Opretter et objekt af HjemmeboendeBørn
        public static HjemmeboendeBoern Create(int id, DateTime? foedselsdato)
        {
            return new HjemmeboendeBoern(id, foedselsdato);
        }
    }
}
