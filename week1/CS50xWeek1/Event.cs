using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50xWeek1
{
    public class Event
    {        
        public string Name;
        public DateTime Time;
        public string Location;
        public int MaxOccupancy;
        public decimal Price;

        public Event(string Name)
        {
            this.Name = Name;
        }


        public void Cancel()
        {
            NotifyPersons();
        }

        public void NotifyPersons()
        {
            

        }


    }
}
