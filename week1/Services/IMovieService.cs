using System.Collections.Generic;

namespace Services
{
    public interface IMovieService
    {
        IEnumerable<Theater> GetAvailableTheaters();
        IEnumerable<MovieSchedule> GetAvailableSchules();
        IEnumerable<Movie> GetAvailableMovies();
    }
}