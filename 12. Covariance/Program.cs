using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MultipleInheritance
{
    public class ExampleClass { }
    public class DerivedExampleClass : ExampleClass { }

   class Program
   {
        public static void ExampleMethod(ExampleClass ex) { }

        public static void Main(string[] args) 
        {
            ExampleClass exampleClass = new ExampleClass();
            DerivedExampleClass derivedExampleClass = new DerivedExampleClass();
            // It could be called by Covariance
            ExampleMethod(exampleClass);
            ExampleMethod(derivedExampleClass);

        }
   }
}
