using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Ansoegning
    {
        // Properties
        public int Id { get; private set; }
        public DateTime OprettetDato { get; private set; }
        public int? AntalLejere { get; private set; }

        // Constructor til EF
        public Ansoegning() { }

        // Constructor
        private Ansoegning(int id, DateTime oprettetDato, int? antalLejere)
        {
            Id = id;
            OprettetDato = oprettetDato;
            AntalLejere = antalLejere;
        }

        // Opretter et objekt af Ansoegning
        public static Ansoegning Create(int id, DateTime oprettetDato, int? antalLejere)
        {
            return new Ansoegning(id, oprettetDato, antalLejere);
        }
    }
}
