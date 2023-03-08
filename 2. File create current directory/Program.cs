
namespace Example
{
    class Program1
    {
        static void Main(String[] args)
        {
            string path = Environment.CurrentDirectory + "\\Example.txt";
            System.Diagnostics.Debug.WriteLine(path);
            if(!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}