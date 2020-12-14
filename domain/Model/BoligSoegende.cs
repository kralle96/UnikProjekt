using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Model
{
    public class BoligSoegende
    {
        // Properties
        public int Id { get; private set; }

        // Constructor til EF
        public BoligSoegende() { }

        // Constructor
        private BoligSoegende(int id)
        {
            Id = id;
        }

        // Opretter et objekt af BoligSøgende
        public static BoligSoegende Create(int id)
        {
            return new BoligSoegende(id);
        }
    }

}
