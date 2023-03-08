using System.Diagnostics;
namespace MultipleInheritance
{
    // Without 'virtual' and 'override' keyword child class method will not call
    class BaseClass
    {
        public virtual void PrintMessage()
        {
            Debug.WriteLine("Base Class");
        }
    }
    class ChildClass : BaseClass
    {
        public override void PrintMessage()
        {
            Debug.WriteLine("Child Class");
            base.PrintMessage(); // This line will call base class method
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            BaseClass childClass = new ChildClass();
            childClass.PrintMessage();
        }
    }
}
