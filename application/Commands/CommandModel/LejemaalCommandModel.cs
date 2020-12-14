using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Dto;

namespace application.Commands.CommandModel
{
    public class LejemaalCommandModel
    {
        // Opretter et lejemaal
        public class CreateLejemaal
        {
            public LejemaalDto Lejemaal { get; set; }
        }

        // Opdatere et lejemaal
        public class UpdateLejemaal
        {
            public LejemaalDto Lejemaal { get; set; }
        }

        // Sletter et lejemaal
        public class DeleteLejemaal
        {
            public LejemaalDto Lejemaal { get; set; }
        }
    }
}
