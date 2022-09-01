using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUke4Marija
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public Employee(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }
    }
}
