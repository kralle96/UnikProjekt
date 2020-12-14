using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Model
{
    public class StatistikLejeperiodeLejersAlder
    {
        // Properties

        public int Id { get; set; }
        public int BoligAdminSelskab { get; set; }
        public DateTime DatoSoegt { get; set; }
        public int AlderFra { get; set; }
        public int AlderTil { get; set; }
        public int LejeperiodeGennemsnit { get; set; }

        // Constructor til EF
        public StatistikLejeperiodeLejersAlder() { }

        // Constructor
        public StatistikLejeperiodeLejersAlder(int id, DateTime datoSoegt, int alderFra, int alderTil, int lejeperiodeGennemsnit)
        {
            Id = id;
            DatoSoegt = datoSoegt;
            AlderFra = alderFra;
            AlderTil = alderTil;
            LejeperiodeGennemsnit = lejeperiodeGennemsnit;
        }

        // Opretter et objekt af StatistikLejeperiodeLejersAlder
        public static StatistikLejeperiodeLejersAlder Create(int id, DateTime datoSøgt, int alderFra, int alderTil, int lejeperiodeGennemsnit)
        {
            return new StatistikLejeperiodeLejersAlder(id, datoSøgt, alderFra, alderTil, lejeperiodeGennemsnit);
        }

    }
}
