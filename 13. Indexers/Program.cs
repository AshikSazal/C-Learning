using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MultipleInheritance
{
   class ExampleClassWithIndexer
   {
        private string[] dataArray = new string[100];
        public object this[int index]
        {
            get
            {
                if(index <  0 || index >= dataArray.Length)
                {
                    Debug.WriteLine("Invalid Index");
                    return new object();
                }
                else
                {
                    return dataArray[index];
                }
            }
            set
            {
                if (index < 0 || index >= dataArray.Length)
                {
                    Debug.WriteLine("Invalid Index");
                }
                else
                {
                    dataArray[index] = value.ToString();
                }
            }
        }
        
   }
    class Program
    {
        public static void Main(string[] args)
        {
            ExampleClassWithIndexer exampleClassWithIndexer = new ExampleClassWithIndexer();
            exampleClassWithIndexer[0] = "Hi";
            exampleClassWithIndexer[1] = 2;
            exampleClassWithIndexer[2] = true;
            exampleClassWithIndexer[3] = 1.0f;

            for(int  i = 0; i < 4; i++)
            {
                Debug.WriteLine(exampleClassWithIndexer[i]);
            }
        }
    }
}
