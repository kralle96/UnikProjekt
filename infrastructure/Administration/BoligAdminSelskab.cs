﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Administration
{
    class BoligAdminSelskab
    {
        public int BoligAdminId { get; private set; }
        public string Navn { get; private set; }
        public AdminLogin AdminLogin { get; private set; }
    }
}