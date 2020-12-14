using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Stamdata
    {
        // Properties
        public int Id { get; private set; }
        public string Fornavn { get; private set; }
        public string Efternavn { get; private set; }
        public int Postnr { get; private set; }
        public string Adresse { get; private set; }
        public int Telefonnr { get; private set; }
        public string Email { get; private set; }
        public string? Køn { get; private set; }
        public DateTime Fødselsdato { get; private set; }

        // Constructor til EF
        public Stamdata() { }

        // Constructor
        private Stamdata(int id, string  fornavn, string efternavn, int postnr, string adresse, int telefonnr, string email, string? køn, DateTime fødselsdato)
        {
            Id = id;
            Fornavn = fornavn;
            Efternavn = efternavn;
            Postnr = postnr;
            Adresse = adresse;
            Telefonnr = telefonnr;
            Email = email;
            Køn = køn;
            Fødselsdato = fødselsdato;
        }

        // Opretter et objekt af Stamdata
        public static Stamdata Create(int id, string fornavn, string efternavn, int postnr, string adresse, int telefonnr, string email, string? køn, DateTime fødselsdato)
        {
            return new Stamdata(id, fornavn, efternavn, postnr, adresse, telefonnr, email, køn, fødselsdato);
        }
    }
}
