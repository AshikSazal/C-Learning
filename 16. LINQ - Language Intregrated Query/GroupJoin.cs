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

    class Age
    {
        public int ageNumber;
        public string ageLabel;
    }

    class Program
    {

        public static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>()
            {
                new Person(){Name="Zach", Age=25},
                new Person(){Name="Ashley", Age=30},
                new Person(){Name="Bob", Age=30},
                new Person(){Name="Sarah", Age=25},
                new Person(){Name="Jim", Age=25},
                new Person(){Name="Vinny", Age=40}
            };

            List<Age> agesList = new List<Age>()
            {
                new Age(){ ageNumber = 25, ageLabel = "25 year Olds"},
                new Age(){ ageNumber = 30, ageLabel = "30 year Olds"},
                new Age(){ ageNumber = 40, ageLabel = "40 year Olds"},
            };

            var groupJoin = agesList.GroupJoin(peopleList, age => age.ageNumber, person => person.Age, (age, personGroup) => new { PersonGroup = personGroup, Number = age.ageLabel });

            foreach (var item in groupJoin)
            {
                Debug.WriteLine(item.Number);
                Debug.Indent();

                foreach(var person in item.PersonGroup)
                {
                    Debug.WriteLine(person.Name);
                }
                Debug.Unindent();
            }
        }
    }
}
