using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace domain.Model
{
    public class InventarLejemaal
    {

        public int Id { get; set; }
        public Inventar Inventar { get; set; }
        public Lejemaal Lejemaal { get; set; }
    }
}
