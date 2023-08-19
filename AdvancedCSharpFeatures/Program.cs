using System;
using System.Threading.Tasks;

namespace AdvancedCSharpFeatures
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var (name, age) = GetUser();
            Console.WriteLine($"Name: {name}, Age: {age}");

            var userRole = GetRole(age);
            Console.WriteLine($"Role: {userRole}");

            var result = await PerformAsyncTask();
            Console.WriteLine($"Async result: {result}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static (string Name, int Age) GetUser()
        {
            return ("John Doe", 25);
        }

        static string GetRole(int age)
        {
            return age switch
            {
                < 18 => "Minor",
                < 60 => "Adult",
                _ => "Senior"
            };
        }

        static async Task<int> PerformAsyncTask()
        {
            await Task.Delay(1000);
            return 42;
        }

        static void SafeAccess()
        {
            string text = null;
            // Using null-conditional operator
            int? length = text?.Length;
            Console.WriteLine($"Length: {length ?? 0}");
        }
    }
}
