using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Model
{
    public class Udlejningsinfo
    {
        // Properties

        public int Id { get; set; }
        public double MaanedligLeje { get; set; }
        public double MaanedligEl { get; set; }
        public double MaanedligVand { get; set; }
        public double MaanedligVarme { get; set; }
        public bool Internet { get; set; }
        public double Depositum { get; set; }
        public DateTime LedigFra { get; set; }
        public DateTime OvertagelseFra { get; set; }
        public string Status { get; set; }

        // Constructor til EF
        public Udlejningsinfo() { }

        //Constructor
        private Udlejningsinfo(int id, double maanedligLeje, double maanedligEl, double maanedligVand, double maanedligVarme, bool internet,
            DateTime ledigFra, DateTime overtagelseFra, string status)
        {
            Id = id;
            MaanedligLeje = maanedligLeje;
            MaanedligEl = maanedligEl;
            MaanedligVand = maanedligVand;
            MaanedligVarme = maanedligVarme;
            Internet = internet;
            LedigFra = ledigFra;
            OvertagelseFra = overtagelseFra;
            Status = status;
        }

        // Opretter et objekt af Udlejningsinfo
        public static Udlejningsinfo Create(int id, double maanedligLeje, double maanedligEl, double maanedligVand, double maanedligVarme, bool internet,
            DateTime ledigFra, DateTime overtagelseFra, string status)
        {
            return new Udlejningsinfo(id, maanedligLeje, maanedligEl, maanedligVand, maanedligVarme, internet, 
                ledigFra, overtagelseFra, status);
        }
    }
}
