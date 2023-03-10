using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace MultipleInheritance
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public static void Main(string[] args)
        {
            // Usage
            Person person = new Person();
            person.Name = "John"; // Set the value of Name
            person.Age = 30; // Set the value of Age

            Debug.WriteLine("Name: " + person.Name); // Get the value of Name
            Debug.WriteLine("Age: " + person.Age); // Get the value of Age
        }
    }
}
