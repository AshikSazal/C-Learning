using System.Diagnostics;
using System.Threading;

namespace MultipleInheritance
{
    class Program
    {
        static void ExampleFunction()
        {
            for(int i=0;i<10;i++)
            {
                Debug.WriteLine("Hello World");
            }
        }

        public static void Main(string[] args)
        {
            Thread t = new Thread(ExampleFunction);
            t.Start();
        }
    }
}
