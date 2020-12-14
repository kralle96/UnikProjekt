using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Lejemaal
{
    public class LejemaalContext : DbContext
    {
        
        public DbSet<Domain.Model.Lejemaal> Lejemaal { get; set; }
        public DbSet<Domain.Model.Udlejningsinfo> Udlejningsinfo { get; set; }
        public DbSet<Domain.Model.Post> Post { get; set; }
        public DbSet<Domain.Model.Selskab> Selskab { get; set; }
        public DbSet<Domain.Model.Inventar> Inventar { get; set; }
        public DbSet<Domain.Model.Ejendom> Ejendom { get; set; }
        public DbSet<Domain.Model.StatistikLejeperiodeLejersAlder> StatistikLejeperiodeLejersAlder { get; set; }
        public LejemaalContext(DbContextOptions options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //1-n relationer
            modelBuilder.Entity<Domain.Model.Selskab>()
                .HasMany(l => l.Lejemaal)
                .WithOne(c => c.Selskab);

            modelBuilder.Entity<Domain.Model.Ejendom>()
                .HasMany(l => l.Lejemaal)
                .WithOne(e => e.Ejendom);

            modelBuilder.Entity<Domain.Model.Lejemaal>()
                .HasOne(p => p.PostNr)
                .WithMany(l => l.Lejemaal);

            ////n-m relationer
            //modelBuilder.Entity<InventarLejemaal>()
            //    .HasKey(il => il.InventarLejemaalId);
            //modelBuilder.Entity<InventarLejemaal>() //we pray
            //    .HasOne(i => i.Inventar)
            //    .WithMany(il => il.InventarLejemaal)
            //    .HasForeignKey(i => i.InventarLejemaalId);
            //modelBuilder.Entity<InventarLejemaal>()
            //    .HasOne(l => l.Lejemaal)
            //    .WithMany(il => il.InventarLejemaal)
            //    .HasForeignKey(i => i.InventarLejemaalId);
        }
    }
}