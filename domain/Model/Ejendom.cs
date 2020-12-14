using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Domain.MyDomainService;

namespace Domain.Model
{
    public class Ejendom
    {
        // Properties
       
        public int Id { get; set; }
        public int BoligAdministrationsSelskab { get; set; }
        public string OmrådeNavn { get; set; }
        public string Type { get; set; }
        public ICollection<Lejemaal> Lejemaal { get; set; }

        // Constructor til EF
        public Ejendom() { }

        // Constructor
        private Ejendom(int id, string områdeNavn, string type)
        {
            //dm.CheckUserMaaOpretteEjendom();
            Id = id;
            OmrådeNavn = områdeNavn;
            Type = type;
        }

        // Opretter et objekt af Ejendom
        public static Ejendom Create(int id, string områdeNavn, string type)
        {
            return new Ejendom(id, områdeNavn, type);
        }



        //private Ejendom(int ejendomId, string områdeNavn, string type, IMyDomainService dm)
        //{
        //    dm.CheckUserMaaOpretteEjendom();
        //    EjendomId = ejendomId;
        //    OmrådeNavn = områdeNavn;
        //    Type = type;
        //}

        //public static Ejendom Create(int ejendomId, string områdeNavn, string type, IMyDomainService)
        //{
        //    return new Ejendom(ejendomId, områdeNavn, type);
        //}

    }
}
