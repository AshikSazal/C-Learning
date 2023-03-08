using System.Text;

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

            FileStream fs = File.Open(path, FileMode.Append);
            byte[] info = new UTF8Encoding(true).GetBytes("Hello world");
            fs.Write(info, 0, info.Length);
            fs.Close();

            StreamReader sr = new StreamReader(path);
            string fileText = sr.ReadToEnd();
            System.Diagnostics.Debug.WriteLine(fileText);
        }
    }
}
