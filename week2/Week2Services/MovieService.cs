using System;
using System.Collections.Generic;

namespace Week2Services
{
    public class MovieService : IMovieService
    {             
        private IList<Movie> Movies;
        private IList<MovieSchedule> Schedules;

        public MovieService()
        {            
            Movies = DataSource.Movies;
           Schedules = new List<MovieSchedule>();
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
            if(movie == null) throw  new MovieSchedulingException();

            Schedules.Add(new MovieSchedule(movie, date));
        }
    }
}
