using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);
            Debug.WriteLine("Does 2 match pattern " + regex.IsMatch("2"));
            Debug.WriteLine("Does a match pattern " + regex.IsMatch("a"));

            string st = "(the)";
            Regex regex1 = new Regex(st);
            string text = "the quick brown fox jumped over the lazy dog";
            Match match = regex1.Match(text);
            MatchCollection matches = regex1.Matches(text);
            Debug.WriteLine(match);
            foreach(Match mat in matches)
            {
                Debug.WriteLine(mat.Value);
            }
        }
    }
}
