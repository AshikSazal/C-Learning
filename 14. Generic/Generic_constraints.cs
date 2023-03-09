using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MultipleInheritance
{
    class Example2 { }
    interface IExample3 { }
    class Example<T, U> where T : Example2, IExample3
                        where U : Example2
    {
        public static void Main(string[] args)
        {

        }
    }
}
