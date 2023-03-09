using System.Diagnostics;
namespace MultipleInheritance
{
    interface IExample
    {
        void Example();
        int Example2();
    }

    interface IExample2
    {
        string Example3(string st1, string st2);
    }

    class Program : IExample, IExample2
    {
        public void Example()
        {
            Debug.WriteLine("Interface one");
        }

        public int Example2()
        {
            return 1;
        }

        public string Example3(string st1, string st2)
        {
            return st1 + " " + st2;
        }
        public static void Main(String[] args)
        {
            Program obj = new Program();
            obj.Example();
            Debug.WriteLine(obj.Example2());
            Debug.WriteLine(obj.Example3("Hello", "World"));           
        }

        
    }
}
