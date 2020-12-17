using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using domain.Exceptions;

namespace domain.Model
{
    public class Lejemaal
    {
        // Properties
        public int Id { get; set; }
        public string Adresse { get; set; }
        public string Type { get; set; }
        public int Vaerelser { get; set; }
        public int Stoerrelse { get; set; }
        public string Energimaerke { get; set; }
        public bool? Husdyr { get; set; }
        public bool? Ryger { get; set; }

        public virtual Udlejningsinfo Udlejningsinfo { get; set; }
        public virtual Post PostNr { get; set; }
        public virtual Selskab Selskab { get; set; }
        public virtual Ejendom Ejendom { get; set; }
        public virtual ICollection<Inventar> InventarILejemaal { get; set; }
        
        // Constructor til EF
        public Lejemaal() { }

        // Constructor
        private Lejemaal(int id, string adresse, bool? husdyr, bool? ryger, int vaerelser, int stoerrelse, string? energimaerke, string type)
        {
            if (!ValidateAdresse(adresse)) 
                return;
            Id = id;
            Adresse = adresse;
            Husdyr = husdyr;
            Ryger = ryger;
            Vaerelser = vaerelser;
            Stoerrelse = stoerrelse;
            Energimaerke = energimaerke;
            Type = type;
        }

        // Opretter et objekt af Lejemål
        public static Lejemaal Create(int id, string adresse, bool? husdyr, bool? ryger, int vaerelser, int stoerrelse, string? energimaerke, string type)
        {
            return new Lejemaal(id, adresse, husdyr, ryger, vaerelser, stoerrelse, energimaerke, type);
        }

        // Inputvalidering af adresse
        public bool ValidateAdresse(string adresse)
        {
            bool test = true;
            char[] specialChars = new[] { '/', '*', '-', '+' };
            int adresseMaxLength = 20;
            int adresseMinLength = 1;
            int adresseLength = adresse.Length;
            if (adresseLength >= adresseMaxLength)
                test = false;
            if (adresseLength <= adresseMinLength)
                test = false;
            for (int i = 0; i < specialChars.Length; i++)
                if (adresse.Contains(specialChars[i]))
                    test = false;
            return test;
        }
    }
}
