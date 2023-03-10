using System.Diagnostics;
using System.Threading.Tasks;
using System.Net;

namespace MultipleInheritance
{
    class Program
    {
        static void Main()
        {
            // Download two websites parallel way
            Parallel.Invoke(
                () => new WebClient().DownloadFile("http://www.google.com","google.html"),
                () => new WebClient().DownloadFile("http://www.yahoo.com","yahoo.html")
                );
        }

    }
}
