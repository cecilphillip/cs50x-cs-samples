using System;
using System.Collections.Generic;

namespace Services
{
    // Here is some fake data
    public static class DataSource
    {
        public static IList<Theater> Theaters
        {
            get
            {
                return new List<Theater>
                {
                    new Theater("AMC", "Miami, FL"),
                    new Theater("Regal", "Fort Lauderdale, FL"),
                    new Theater("Cinemark", "Davie, FL")
                };
            }
        }

        public static IList<Movie> Movies
        {
            get
            {
                return new List<Movie>
                {
                    new Movie {Title = "Batman Begins", Description = "Another batman movie", DurationInMinutes = 120, Genre = "Action", ReleaseDate = new DateTime(2005,6, 15)},
                    new Movie {Title = "The Avengers", Description = "Another Comic Book Movie", DurationInMinutes =  160, Genre = "Action", ReleaseDate = new DateTime(2012, 5,4)},
                    new Movie {Title = "The Expendables 3", Genre = "Action", Description = "Yep, they made another one", ReleaseDate = new DateTime(2014,8,15)},
                    new Movie {Title = "Aliens", Genre = "Thriller", Description = "Alien movie", DurationInMinutes = 168, ReleaseDate = new DateTime(1979,5,25) },
                    new Movie {Title = "Dracula", Genre = "Horror", Description = "Vampire Movie",ReleaseDate = new DateTime(1992,11,15)}
                };
            }
        }       
    }
}