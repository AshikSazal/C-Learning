using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace MultipleInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Select
            List<int> collection = new List<int>() { 1,2,3};
            IEnumerable<int> collectionOfIntsMultyplyBy2 = collection.Select(s => s * 2);
            foreach(int i in collectionOfIntsMultyplyBy2)
            {
                Debug.WriteLine(i.ToString() + "");
            }

            // Select Many
            Debug.WriteLine("Select Many");
            List<List<int>> list = new List<List<int>>()
            {
                new List<int>() { 1, 2,3 },
                new List<int>() {4,5, 6 },
                new List<int>() {7,8,9 }
            };
            IEnumerable<int> result = list.SelectMany(s => s);
            Debug.WriteLine(result.Count().ToString());
            foreach (int i in result)
            {
                Debug.WriteLine(i.ToString() + "");
            }
        }
    }
}
