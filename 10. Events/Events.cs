using System.Diagnostics;

namespace MultipleInheritance
{
    class Program
    {
        private static event EventHandler evt;
        private static event EventHandler evt2;
        public static void HandleEvent(object sender, EventArgs evtArgs)
        {
            Debug.WriteLine("Hello World");
        }

        // Finalizer
        ~Program()
        {
            // Unsubscribe the event
            evt -= HandleEvent;
        }
        static void Main(string[] args)
        {
            evt += HandleEvent;
            evt.Invoke(null, new EventArgs());

            // lambda function
            evt2 += (sender, evtArgs) => Debug.WriteLine("Lambda function");
            evt2.Invoke(null, new EventArgs());


        }
    }
}
