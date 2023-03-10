using System.Diagnostics;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class Person
    {
        public string Name;
        public int Age;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person(){Name="John", Age=30},
                new Person(){Name="Sarah", Age=25},
                new Person(){Name="James", Age=32},
                new Person(){Name="Joseph", Age=24},
            };

            int oldesPersonAge = people.Select(x => x.Age).Max();
            Debug.WriteLine(oldesPersonAge);
        }
    }
}
