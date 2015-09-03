using System;

namespace Services
{
    public class MovieSchedule
    {
        public Movie Movie { get; protected set; }
        public DateTime StarTime { get; protected set; }

        public MovieSchedule(Movie movie, DateTime startTime)
        {
            this.Movie = movie;
            this.StarTime = startTime;
        }
    }
}