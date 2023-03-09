using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MultipleInheritance
{
   class Example<T>
    {
        public static void PrintMessage<T>(T message)
        {
            Debug.WriteLine(message.ToString());
        }
        public static void PrintMessage<T>(T message, T prefix)
        {
            Debug.WriteLine(prefix.ToString() + message.ToString());
        }
        public static void PrintMessage<T>(T message, T prefix, T suffix)
        {
            Debug.WriteLine(prefix.ToString() + message.ToString() + suffix.ToString());
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Example<string>.PrintMessage("Hi");
            Example<int>.PrintMessage(2);
            Example<bool>.PrintMessage(true);

            Example<string>.PrintMessage("Hello ","World");
            Example<string>.PrintMessage("I ","Love ","Parents");
        }
    }
}
