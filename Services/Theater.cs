using System;
using System.Collections.Generic;

namespace Services
{
    public class Theater
    {
        public string Name { get; set; }
        public string Location { get; set; }
        private IList<MovieSchedule> Schedules { get; set; }

        public Theater(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Schedules = new List<MovieSchedule>();
        }

        public void ScheduleMovie(Movie movie, DateTime startTime)
        {
            var schedule = new MovieSchedule(movie, startTime);
            this.Schedules.Add(schedule);
        }
    }
}