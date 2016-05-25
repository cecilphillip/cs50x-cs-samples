using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Demo
{
    public class MyClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new MyClass() { Name = "John", Age = 44});
            Console.ReadLine();
        }
    }
}
