using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace MultipleInheritance
{
    class Person
    {
        public string Name;
        public int Age;
    }

    class Program
    {
        static List<Person> people = new List<Person>()
        {
            new Person(){Name="Zach", Age=25},
            new Person(){Name="Robert", Age=30},
            new Person(){Name="Albert", Age=90},
            new Person(){Name="John", Age=5}
        };
        public static void Main(string[] args)
        {

            IOrderedEnumerable<Person> ascendingNames = people.OrderBy(x => x.Name);
            foreach (Person person in ascendingNames)
            {
                Debug.WriteLine(person.Name);
            }
        }
    }
}
