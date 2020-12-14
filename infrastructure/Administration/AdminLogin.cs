using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Administration
{
    class AdminLogin
    {
        public int AdminBrugerId { get; private set; }
        public string Brugernavn { get; private set; }
        public string Password { get; private set; }
    }
}
