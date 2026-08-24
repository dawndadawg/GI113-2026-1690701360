/*
 * Student ID : 1690701360
 * Name       : Lab02
 * Section    : 129B
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
using System;
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Part A Lab02
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp; //คำนวนเปอร์เซนต์เลือด
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            //Part B Lab02
            string bossName1 = "Silver";
            char rank1 = 'B';
            int level1 = 55;
            int maxHp1 = 150;
            int currentHp1 = 105;
            float attackPower1 = 12.5f;
            double critMultiplier1 = 1.55;
            bool isBoss1 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"HP: {currentHp1}/{maxHp1}");
            Console.WriteLine($"Attack Power: {attackPower1}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier1}");
            Console.WriteLine($"Is Boss: {isBoss1}");
            Console.WriteLine();

            string bossName2 = "Gold";
            char rank2 = 'A';
            int level2 = 68;
            int maxHp2 = 200;
            int currentHp2 = 145;
            float attackPower2 = 32.5f;
            double critMultiplier2 = 1.65;
            bool isBoss2 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"HP: {currentHp2}/{maxHp2}");
            Console.WriteLine($"Attack Power: {attackPower2}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier2}");
            Console.WriteLine($"Is Boss: {isBoss2}");
            Console.WriteLine();

            string bossName3 = "Diamond";
            char rank3 = 'S';
            int level3 = 87;
            int maxHp3 = 300;
            int currentHp3 = 265;
            float attackPower3 = 52.5f;
            double critMultiplier3 = 1.75;
            bool isBoss3 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName3}");
            Console.WriteLine($"Rank: {rank3}");
            Console.WriteLine($"HP: {currentHp3}/{maxHp3}");
            Console.WriteLine($"Attack Power: {attackPower3}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier3}");
            Console.WriteLine($"Is Boss: {isBoss3}");
            Console.WriteLine();

            string bossName4 = "The Prism";
            char rank4 = '?';
            int level4 = 999;
            int maxHp4 = 999;
            int currentHp4 = 998;
            float attackPower4 = 99.9f;
            double critMultiplier4 = 9.99;
            bool isBoss4 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName4}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"HP: {currentHp4}/{maxHp4}");
            Console.WriteLine($"Attack Power: {attackPower4}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier4}");
            Console.WriteLine($"Is Boss: {isBoss4}");
            Console.WriteLine();
        }
    }
}
