using System;
using System.Collections.Generic;

namespace Week2Services
{
    public interface IMovieService
    {
        void ScheduleMovie(Movie movie, DateTime date);
        IEnumerable<Movie> GetAvailableMovies();
        IEnumerable<MovieSchedule> GetAvailableSchules();
    }
}