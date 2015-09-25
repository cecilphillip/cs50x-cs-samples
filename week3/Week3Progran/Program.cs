using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Week3Progran
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Event>();
            list.Add(new Event() { Name = "Event 1", Location = "Here" });
            list.Add(new Event() { Name = "Some other Event", Location = "Some other place" });
            list.Add(new Event() { Name = "Class", Location = "Lost" });

            var result = list.Select(e => e.Name.First());

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
            Console.Read();

        }
    }

    class Event
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
