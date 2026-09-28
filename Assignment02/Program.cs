/*
*Student ID: 1690701360
* Name       : Assignment02
* Section    : 129B
* No.        : 14
* Course     : GI113 Computer Programming (GI)
*/
using System;
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string OreName = "Hell Stone";
            const double SmeltingRate = 0.20;
            const double SalvageRate = 0.40;
            const int MaxBatch = 300;

            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("|   --------     -----    -------      -----    -------   |");
            Console.WriteLine("|  |        |  /       '  |      '   /       '  |      |  |");
            Console.WriteLine("|  |    ----   |  ---  |  |  ___  |  |  ___  |  |   ---   |");
            Console.WriteLine("|  |    |      | /   ' |  | |   ' |  | /   ' |  |  |      |");
            Console.WriteLine("|  |    ----   | |   | |  | |   | |  | |    --  |   ---   |");
            Console.WriteLine("|  |        |  | |   | |  | |___'/   | |   ___  |      |  |");
            Console.WriteLine("|  |    ----   | |   | |  |      '   | |   |  | |   ---   |");
            Console.WriteLine("|  |    |      | '   / |  | |---- '  |  '___- | |  |      |");
            Console.WriteLine("|  |    |      '  ---  /  | |   '  '  '      /  |   ---   |");
            Console.WriteLine("|   ----        '-----    |__|   '__'  '-----    -------| |");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("___________________________________________________________");

            Console.WriteLine("'look who's here! welcome to the best forge there is in the town! what yah here for today?'\n");
            Console.WriteLine($"- Ore: {OreName} | Smelting rate: {SmeltingRate}/Break down rate: {SalvageRate} -");
            Console.WriteLine($"- Maximum amount per smelt/break down: {MaxBatch} -\n");

            Console.WriteLine("=> PRESS (S) to smelt the ore (ore -> ingot)");
            Console.Write("=> Press (B) to break down the ingot (ingot -> ore)\nchoice:");
            bool menuOk = char.TryParse(Console.ReadLine(), out char menuChoice);
            Console.Write("amount:");
            bool amountOk = double.TryParse(Console.ReadLine(), out double amount);

            if (amountOk == true && amount > 0 && amount <= MaxBatch)
            {
                if (menuChoice == 'S' || menuChoice == 's')
                {
                    Console.WriteLine("'smelt the ore? alright mate!'");
                    Console.WriteLine($"- you smelt {amount} ores for {amount*SmeltingRate} ingots! -");
                }
                else if (menuChoice == 'B' || menuChoice == 'b')
                {
                    Console.WriteLine("'break down the ingot? yah bet!'");
                    Console.WriteLine($"- you break down {amount} ingots for {amount/SalvageRate} ores! -");
                }
                else
                {
                    Console.WriteLine("'what? we don't do that here yah know?'");
                }
            }
            else
            {
                Console.WriteLine("'Oi, I ain't got all day mate. scram if yah are here for a joke!'");
            }
        }
    }
}
