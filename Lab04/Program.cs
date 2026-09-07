/*
 *Student ID: 1690701360
 * Name       : Lab03
 * Section    : 129B
 * No.        : N / A
 * Course     : GI113 Computer Programming (GI)
 */
using System;
namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("|      NEW ADVENTURE      |"); //title ใช้ writeline เพื่อต่อบรรทัดใหม่
            Console.WriteLine("+-------------------------+");

            Console.Write("Name your hero: ");
            string playerName = Console.ReadLine(); //ใช้ write เพื่อต่อบรรทัดเดิม

            Console.WriteLine($"\n\"Welcome, {playerName}. Your journey has begun...\" ");

            Console.Write("Choose your desire difficulty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty will be set to {difficulty}");

            Console.WriteLine("\n+---------------------+");
            Console.WriteLine("|      ITEM SHOP      |");
            Console.WriteLine("+---------------------+");

            Console.Write("\nHow many potions: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"\nValid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("\n+---------------------------+");
            Console.WriteLine("|      RATE THIS LEVEL      |");
            Console.WriteLine("+---------------------------+");

            Console.Write("Rate this level (0.0-5.0): ");
            bool isValid1 = double.TryParse(Console.ReadLine(), out double rating);
            Console.WriteLine($"Valid input: {isValid1}");
            Console.WriteLine($"Rating: {rating}");

            Console.WriteLine("\n+-------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+-------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");
        }
    }
}
