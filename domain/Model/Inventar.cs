using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Model
{
    public class Inventar
    {
        //Properties
        public int Id { get; set; }
        public string InventarType { get; set; }
        public ICollection<Lejemaal> InventarILejemaal { get; set; }

        // Constructor til EF
        public Inventar() { }

        // Constructor
        private Inventar(int id, string inventarType)
        {
            Id = id;
            InventarType = inventarType;
        }

        // Opretter et inventar objekt
        public static Inventar Create(int id, string inventarType)
        {
            return new Inventar(id, inventarType);
        }
    }
}
