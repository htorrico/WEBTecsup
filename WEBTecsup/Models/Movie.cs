using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBTecsup.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Titlle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Gender { get; set; }
        public decimal Price { get; set; }

    }
}