using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Services;

namespace CS50xWeek1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new SomeOtherCourse());
            

            var service = new MovieService();

            //List Theaters
            var theaters = service.GetAvailableTheaters();
            Console.WriteLine("Theaters\n====================");
            foreach (var theater in theaters)
            {
                var json = JsonConvert.SerializeObject(theater, Formatting.Indented);
                Console.WriteLine(json);
                Console.WriteLine();
            }


            //List Movies
            var movies = service.GetAvailableMovies();
            Console.WriteLine("Movies\n====================");
            foreach (var movie in movies)
            {
                var json = JsonConvert.SerializeObject(movie, Formatting.Indented);
                Console.WriteLine(json);
                Console.WriteLine();
            }

            //Get the first movie
            var movieToSchedule = movies.First();
            var scheduleDate = DateTime.Now.AddDays(2);
           
            // schedule movie
            service.ScheduleMovie(movieToSchedule, scheduleDate);

            //List Schedules
            var schedules = service.GetAvailableSchules();
            Console.WriteLine("Schedules\n====================");
            foreach (var schedule in schedules)
            {
                var json = JsonConvert.SerializeObject(schedule, Formatting.Indented);
                Console.WriteLine(json);
                Console.WriteLine();
            }

            //Get another move. The second one to be exact
            movieToSchedule = movies.Skip(1).Take(1).Single();
             scheduleDate = DateTime.Now.AddDays(4);

            // schedule movie
            service.ScheduleMovie(movieToSchedule, scheduleDate);

            //List Schedules
            schedules = service.GetAvailableSchules();
            Console.WriteLine("Schedules\n====================");
            foreach (var schedule in schedules)
            {
                var json = JsonConvert.SerializeObject(schedule, Formatting.Indented);
                Console.WriteLine(json);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

       
    }


    public class Course
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            Console.WriteLine("something");
            return base.ToString();
        }
    }

    class SomeOtherCourse : Course
    {
        public string Grade { get; set; }

        public override string ToString()
        {
            var output = base.ToString();
            Console.WriteLine("something else");
            return output;
        }
    }

}
