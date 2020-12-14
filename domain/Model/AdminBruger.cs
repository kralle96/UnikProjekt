using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Model
{
    public class AdminBruger
    {
        // Properties
        public int Id { get; private set; }
        public string Brugernavn { get; private set; }
        public string Password { get; private set; }

        //Constructor til EF
        public AdminBruger() { }

        //Constructor
        private AdminBruger(int id, string brugernavn, string password)
        {
            Id = id;
            Brugernavn = brugernavn;
            Password = password;
        }

        // Opretter et objekt af Adminbruger
        public static AdminBruger Create(int adminBrugerId, string brugernavn, string password)
        {
            return new AdminBruger(adminBrugerId, brugernavn, password);
        }
    }
}
