using System.Diagnostics;

namespace MultipleInheritance
{
    class Program
    {
        delegate void Print();

        static void HelloWorld()
        {
            Debug.WriteLine("Hello World");
        }

        static void ByeWorld()
        {
            Debug.WriteLine("Bye World");
        }

        static void Main(string[] args)
        {
            Print print = null;
            print += HelloWorld;
            print += ByeWorld;
            print();

            Print print2 = HelloWorld;
            print2();
        }
    }
}
