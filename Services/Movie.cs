using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Services
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate  { get; set; }
        public int DurationInMinutes { get; set; }
        public IList<Actor> Actors { get; set; }
    }
}
