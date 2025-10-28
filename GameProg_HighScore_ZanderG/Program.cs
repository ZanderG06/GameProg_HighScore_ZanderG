using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg_HighScore_ZanderG
{
    internal class Program
    {
        static Random random = new Random();
        static bool nameLength = false;
        static string path = "data.txt";
        static string name;

        static void Main(string[] args)
        {
            List<string> allFinalScore = new List<string>();
            
            int score = random.Next(1, 1001);
            Console.WriteLine($"Score: {score}");
            Thread.Sleep(1000);

            while (nameLength == false)
            {
                Console.WriteLine("Type your initials");
                name = Console.ReadLine();
                
                if (name.Length == 3)
                {
                    nameLength = true;
                }
            }

            string finalScore = $"{name}: {score}";

            allFinalScore.Add(finalScore);

            File.WriteAllLines(path, allFinalScore);

            Console.WriteLine("Press any key to end the game...");
            Console.ReadKey(true);
        }
    }
}
