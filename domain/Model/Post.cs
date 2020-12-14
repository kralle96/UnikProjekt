using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace domain.Model
{
    public class Post
    {
        // Properties

        public int Id { get; set; }
        public int PostNr { get; set; }
        public string By { get; set; }
        public string Region { get; set; }
        public ICollection<Lejemaal> Lejemaal { get; set; }

        // Constructor til EF
        public Post() { }

        // Constructor
        private Post(int id, int postNr, string by, string? region)
        {
            Id = id;
            PostNr = postNr;
            By = by;
            Region = region;
        }

        // Opretter et objekt af Post
        public static Post Create(int id, int postNr, string by, string? region)
        {
            return new Post(id, postNr, by, region);
        }
    }
}
