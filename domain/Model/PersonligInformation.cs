using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class PersonligInformation
    {
        // Properties
        public int Id { get; private set; }
        public bool Husdyr { get; private set; }
        public bool Ryger { get; private set; }

        // Constructor til EF
        public PersonligInformation() { }

        // Constructor
        private PersonligInformation(int id, bool? husdyr, bool? ryger)
        {
            Id = id;
            //Husdyr = husdyr;
            //Ryger = ryger;
        }

        // Opretter et objekt af PersonligInformation
        public static PersonligInformation Create(int id, bool? husdyr, bool? ryger)
        {
            return new PersonligInformation(id, husdyr, ryger);
        }
    }
}
