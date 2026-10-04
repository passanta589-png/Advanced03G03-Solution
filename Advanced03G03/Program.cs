using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Advanced03G03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            List<int> Number = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            Helper.PrintCollection("Numbers", Number);
            Console.WriteLine(Number.Count);
            Console.WriteLine(Number[0]);
            Console.WriteLine(Number[^1]);
            Number.Sort();
            Helper.PrintCollection("Sorted Numbers", Number); 

            int firstAbove90 = Number.Find(x => x > 90);
            Console.WriteLine($"First number above 90: {firstAbove90}");
            List<int> failingGrades = Number.FindAll(x => x < 75);
            Helper.PrintCollection("Failing Grades", failingGrades);
            Number.RemoveAll(x=> x<75);
            Helper.PrintCollection("Grades after removing failing grades", Number);
            Number.Any(x => x == 100);
            Console.WriteLine($"contains 100: {Number.Any(x => x == 100)}");

            List<string> strings =Number.ConvertAll(x=> $" {x} string");
            Helper.PrintCollection("Converted Strings", strings);

            #endregion


        }
    }
}
