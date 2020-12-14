using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace domain.Model
{
    public class Selskab
    {
        // Properties
        public int Id { get; set; }
        public string Navn { get; set; }
        public ICollection<Lejemaal> Lejemaal { get; set; }

        // Constructor til EF
        public Selskab() { }

        // Constructor
        private Selskab(int id, string navn)
        {
            Id = id;
            Navn = navn;
        }

        // Opretter et objekt af Selskab
        public static Selskab Create(int id, string navn)
        {
            return new Selskab(id, navn);
        }
    }
}
