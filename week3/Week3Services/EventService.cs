using System.Collections.Generic;

namespace Week3Services
{
    public class EventService
    {
        public virtual IEnumerable<Event> GetEvents()
        {
            return new List<Event>
            {
                new Event {Name = "C# Class", AdmissionFee = (decimal) 0.0},
                new Event { Name = "Event 1", EventType = "1"}
            };
        }
    }
}
