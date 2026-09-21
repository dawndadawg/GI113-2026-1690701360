/*
*Student ID: 1690701360
* Name       : Lab06
* Section    : 129B
* No.        : N / A
* Course     : GI113 Computer Programming (GI)
*/
using System;
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random rng = new Random();
            //int level = rng.Next(1,21);

            Console.WriteLine($"Your level (1-99): ");
            bool ok = int.TryParse(Console.ReadLine(), out int level);
            bool hasKey = false;

            if (!ok || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid level.");
            }
            else if (level >= 10 && hasKey)
            {
                Console.WriteLine("the door opens.\nthe boss awaits.");
            }
            else if (level >= 5)
            {
                if (hasKey)
                {
                    Console.WriteLine("the door opens.");
                }
                else
                {
                    Console.WriteLine("locked. find a key.");
                }
            }
            else
            {
                Console.WriteLine("nothing happened.");
            }
        }
    }
}
