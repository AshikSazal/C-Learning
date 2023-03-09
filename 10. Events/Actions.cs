using System.Diagnostics;

namespace MultipleInheritance
{
    class Program
    {
        private static Action<int,int> action;

        static void HandleAction(int a, int b)
        {
            Debug.WriteLine("Sum : "+(a+b).ToString());
        }
        static void Main(string[] args) 
        {
            action += HandleAction;
            action.Invoke(3, 5);
        }
    }
}
