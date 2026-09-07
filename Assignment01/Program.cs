/*
*Student ID: 1690701360
* Name       : Assignment01
* Section    : 129B
* No.        : N / A
* Course     : GI113 Computer Programming (GI)
*/
using System;
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Lobotmy Corporation"; 

            var employeeName = "BONGBONG";    
            var employeeRank = 'V';
            string egoSuit = "twilight";
            string egoWeapon = "twilight";
            float employeeHealth = 109.35f;
            int employeeSanity = 100;
            int workSpeed = 94;
            double attackPower = 106.87;  
            bool isAlive = true;

            Console.WriteLine("___________________________________");
            Console.WriteLine($"| ===== {GameTitle} ===== |");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"| Employee Name: {employeeName}         |");
            Console.WriteLine($"| Employee Rank: {employeeRank}                |");
            Console.WriteLine($"| EGO Suit: {egoSuit}              |");
            Console.WriteLine($"| EGO Weapon: {egoWeapon}            |");
            Console.WriteLine($"| Health: {employeeHealth}                  |");
            Console.WriteLine($"| Sanity: {employeeSanity}                     |");
            Console.WriteLine($"| Work Speed: {workSpeed}                  |");
            Console.WriteLine($"| Attack Power: {attackPower}            |");
            Console.WriteLine($"| Alive: {isAlive}                     |");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            double employeeSanityAsDouble = employeeSanity;
            Console.WriteLine($"Sanity as double (implicit): {employeeSanityAsDouble}");

            int attackPowerTruncated = (int)attackPower;
            int attackPowerRounded = Convert.ToInt32(attackPower);
            Console.WriteLine($"Attack Power cast (truncates)  : {attackPowerTruncated}");
            Console.WriteLine($"Attack Power Convert (rounds)  : {attackPowerRounded}");
        }
    }
}
