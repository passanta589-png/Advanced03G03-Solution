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

            #region 02
            SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
          {
            { 500, "Ahmed" },
            { 200, "Sara" },
            { 800, "Ali" },
            { 350, "Mona" }
          };
            foreach (KeyValuePair<int, string> entry in leaderboard)
            {
                Console.WriteLine($"Score: {entry.Key} -> Player: {entry.Value}");
            }
            var firstEntry = leaderboard.First();
            Console.WriteLine($"First Key: {firstEntry.Key}");
            Console.WriteLine($"First Value: {firstEntry.Value}");
            bool hasScore500 = leaderboard.ContainsKey(500);
            Console.WriteLine($"\nIs Score 500 exists? {hasScore500}");
            if (leaderboard.TryGetValue(999, out string? player999))
            {
                Console.WriteLine($"Player with score 999: {player999}");
            }
            else
            {
                Console.WriteLine("Player with score 999 not found safely!");
            }
            leaderboard.Remove(200);

            Console.WriteLine("\n=== Updated Leaderboard After Removing Score 200 ===");
            foreach (var entry in leaderboard)
            {
                Console.WriteLine($"Score: {entry.Key} -> Player: {entry.Value}");
            }
            #endregion

            #region 03
            Dictionary<string, int> students = new Dictionary<string, int>()
            {
                { "Ahmed", 01012345678 },
                { "basmala", 01123456789 },
                { "passant", 01234567890 },
                { "Omar", 01545678901 }
            };
            students["Nehal"] = 01028885105;
            Console.WriteLine(students.TryAdd("Nehal", 01028885105));
            if (students.ContainsKey("Nehal"))
            {
                Console.WriteLine(students["Nehal"]);
            }
            if (students.TryGetValue("Nehal", out int phoneNumber))
            {
                Console.WriteLine(phoneNumber);
            }
            Console.WriteLine(students.GetValueOrDefault("Nehal", 0));

            bool isAdded = students.TryAdd("passant", 0112675452); 
            Console.WriteLine($"Is .TryAdd() successful? {isAdded}");
            string targetName = "Youssef";
            string studentNumber = students.TryGetValue(targetName, out int number) ? number.ToString() : "Not Found";
            Console.WriteLine($"Student '{targetName}': {studentNumber}");

            Console.WriteLine("Keys: " + string.Join(", ", students.Keys));
            Console.WriteLine("Values: " + string.Join(", ", students.Values));
            #endregion


        }
    }
}
