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
            int playerHp = 100;
            int arachnidHp = 500;
            int playerAtk = 350;
            int potBoost = 200;
            int arachnidAtk = 50;

            Console.WriteLine("|=====MONSTER HUNTER : HOW WILD=====|");
            Console.WriteLine($"the mission is to defeat the Arachnid ({arachnidHp} HP)");

            Console.WriteLine("Action 1 : Attack");
            Console.WriteLine("Action 2 : Drink ATK boost potion");
            Console.WriteLine("Action 3 : Flee");

            Console.WriteLine("Choose your action (1-3): ");
            bool isInputOk = int.TryParse(Console.ReadLine(), out int action);

            if (isInputOk == false || action < 1 || action > 3)
            {
                Console.WriteLine("\nYou stand still. The monster stomp you to death.\nGAME OVER");
            }
            else if (action == 1)
            {
                Console.WriteLine($"\nYou attacked the Arachnid for {playerAtk} damage.");
                int arachnidHpAfterAttack = arachnidHp - playerAtk;
                Console.WriteLine($"Arachnid take {playerAtk} damage, now they have {arachnidHpAfterAttack} HP left.");
            }
            else if (action == 2)
            {
                Console.WriteLine("\nYou drank an ATK boost potion.");
                int playerAtkAfterBoost = playerAtk + potBoost;
                Console.WriteLine($"Your attack increased by {potBoost} damage. You can now deal {playerAtkAfterBoost} damage.");
                Console.WriteLine($"The Arachnid attacks you for {arachnidAtk} damage, you now have {playerHp - arachnidAtk} HP left.");
                Console.WriteLine($"You attacked the Arachnid for {playerAtkAfterBoost} damage.");
                int arachnidHpAfterAttack = arachnidHp - playerAtkAfterBoost;
                if (arachnidHpAfterAttack <= 0)
                {
                    Console.WriteLine("The mission is completed, the Arachnid has been defeated.");
                }
                else
                {
                    Console.WriteLine("continue to next action...");
                }
            }
            else if (action == 3)
            {
                Console.WriteLine("\nYou run away and abandon the mission, the guild had mark you as traitor and put the bounty on you.");
            }
        }
    }
}
