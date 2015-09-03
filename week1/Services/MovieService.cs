using System;
using System.Collections.Generic;

namespace Services
{
    public class MovieService : IMovieService
    {
        //There are here just to hold our fake movie data
        private IList<Theater> Theaters;
        private IList<Movie> Movies;
        private IList<MovieSchedule> Schedules;

        public MovieService()
        {
            // Load fake data
            Theaters = DataSource.Theaters;
            Movies = DataSource.Movies;
            Schedules = new List<MovieSchedule>();
        }

        public virtual IEnumerable<Theater> GetAvailableTheaters()
        {
            return this.Theaters;
        }

        public virtual IEnumerable<MovieSchedule> GetAvailableSchules()
        {
            return this.Schedules;
        }

        public virtual IEnumerable<Movie> GetAvailableMovies()
        {
            return this.Movies;
        }

        public virtual void ScheduleMovie(Movie movie, DateTime date)
        {
            Schedules.Add(new MovieSchedule(movie, date));
        }
    }
}
