using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Administration
{
    class AdministrationContext : DbContext
    {
        public DbSet<BoligAdminSelskab> BoligAdminSelskab { get; private set; }
        public DbSet<AdminLogin> AdminLogin { get; private set; }

    }
}
