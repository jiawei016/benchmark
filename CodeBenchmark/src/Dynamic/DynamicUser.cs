using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBenchmark.src.Dynamic
{
    public class DynamicUser
    {
        public DynamicUser(string name, string city, int age)
        {
            Name = name;
            City = city;
            Age = age;
        }

        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public string UpdateName(string newName)
        {
            Name = newName;
            return newName;
        }
    }
}
