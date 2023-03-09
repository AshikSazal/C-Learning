using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

namespace MultipleInheritance
{
    class Program
    {
        static int[] array = new int[3] { 1, 2, 3 };
        static List<int> numbers = new List<int>(){1,4,2,6,3};
        static Stack<int> stack = new Stack<int>(array);
        static Queue<int> queue = new Queue<int>(array);

        // Enum
        enum Weekday { Saturday=1, Sunday, Mondey, Tuesday, Wednesday, Thursday, Friday};
        static Weekday dayOfTheWeek = Weekday.Saturday;

        // Dictionary
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();

        static void PrintOut(int i)
        {
            Debug.WriteLine(i);
        }
        public static void Main(string[] arg)
        {
            Debug.WriteLine(array[0]);
            Debug.WriteLine(numbers[0]);
            numbers.ForEach(PrintOut);
            Debug.WriteLine(stack.Peek());
            Debug.WriteLine(queue.Peek());

            // Enum
            foreach(string s in Enum.GetNames(typeof(Weekday)))
            {
                Debug.WriteLine(s);
            }
            foreach (int i in Enum.GetValues(typeof(Weekday)))
            {
                Debug.WriteLine(i);
            }
            switch(dayOfTheWeek)
            {
                case Weekday.Saturday: break;
                case Weekday.Sunday: break;
                case Weekday.Mondey: break;
                case Weekday.Tuesday: break;
                case Weekday.Wednesday: break;
                case Weekday.Thursday: break;
                case Weekday.Friday: break;
            }

            // Dictionary
            dictionary.Add("key1", "value1");
            dictionary.Add("key2", "value2");
            dictionary.Add("key3", "value3");
            foreach(var val in dictionary)
            {
                Debug.WriteLine("Key : {0} and Value : {1}", val.Key, val.Value);
            }
            string value = "";
            if(dictionary.TryGetValue("key1", out value))
            {
                Debug.WriteLine("Key found");
            }

            // Hash Set
            HashSet<char> letters1 = new HashSet<char>() { 'a', 'b', 'c' };
            HashSet<char> letters2 = new HashSet<char>() { 'd', 'e', 'f' };
            letters1.Union(letters2);
            foreach (char s in letters1) Debug.WriteLine(s);

            // Sorted List
            SortedList<string, int> sortedList = new SortedList<string, int>() { { "key1", 1}, { "key2", 2 }, { "key3", 3 } };

            // Sorted Dictionary
            SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>() { { "key1", 1}, { "key2", 2 }, { "key3", 3 } };

            // Sorted Set
            SortedSet<int> sortedSet = new SortedSet<int>() { 4,2,5,6,1,3 };

            // Tuple
            Tuple<int> tuple = new Tuple<int>(1);
            Tuple<int, int, int> tuple3 = new Tuple<int, int, int>(1, 2, 3);
            Tuple<int, string, bool> mixedTuple = new Tuple<int, string, bool>(1, "Hello world", true);
            Debug.WriteLine("Value : " + mixedTuple.Item2);

            // Linked List
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddFirst("root");
            linkedList.AddAfter(linkedList.First, "element");
            linkedList.AddBefore(linkedList.First, "new root");
            linkedList.AddLast("last element");

        }
    }
}
