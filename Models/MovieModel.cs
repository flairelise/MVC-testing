using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessDevProject.Models
{
    public class Movies
    {
        public string Movie_ID { get; set; }
        public string Movie_Name { get; set; }
        public string Director_Name { get; set; }
        public string Streamable { get; set; }
        public string Genre { get; set; }
        public string Release_Date { get; set; }
        public string Duration { get; set; }
        public string Rating { get; set; }
        public string Review { get; set; }


    }
    public class SearchModel
    {
        public string SearchInput { get; set; }
    }
}