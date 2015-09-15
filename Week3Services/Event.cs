using System;

namespace Week3Services
{
    public class Event
    {
        public string Name { get; set; }
        public string EventType { get; set; }
        public decimal AdmissionFee { get; set; }
        public DateTime StarTime { get; set; }


        public override bool Equals(object obj)
        {
            if (obj is Event)
            {
                var objEvent = (Event) obj;
                return this.Name == objEvent.Name && 
                       this.EventType == objEvent.EventType;
            }
            return false;
        }
    }
}