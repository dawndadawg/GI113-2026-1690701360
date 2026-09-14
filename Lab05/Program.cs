/*
 *Student ID: 1690701360
 * Name       : Lab05
 * Section    : 129B
 * No.        : N / A
 * Course     : GI113 Computer Programming (GI)
 */
using System;
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== >> Hunter Monster << ===");
            Console.WriteLine("Hero vs Monster -- Calculate Damage\n");

            Console.Write("Hero HP: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAttackOk = int.TryParse(Console.ReadLine(), out int heroAttack);
            Console.Write("Hero Defense: ");
            bool heroDefenseOk = int.TryParse(Console.ReadLine(), out int heroDefense);
            Console.Write("Monster HP: ");
            bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.Write("Monster Attack: ");
            bool monsterAttackOk = int.TryParse(Console.ReadLine(), out int monsterAttack);
            Console.Write("Monster Defense: ");
            bool monsterDefenseOk = int.TryParse(Console.ReadLine(), out int monsterDefense);
            bool allStatsValid = heroHpOk && heroAttackOk && heroDefenseOk && monsterHpOk && monsterAttackOk && monsterDefenseOk;
            Console.WriteLine($"All stats valid: {allStatsValid}\n");

            int monsterMaxHp = monsterHp;
            Console.WriteLine($"[Hero]    HP:{heroHp} ATK:{heroAttack} DEF:{heroDefense}");
            Console.WriteLine($"[Monster] HP:{monsterHp} ATK:{monsterAttack} DEF:{monsterDefense}\n");

            int potionHeal = 8;
            heroHp += potionHeal;
            Console.WriteLine($"Hero drinks a potion, healing {potionHeal}. Hero HP is now {heroHp}.\n");

            int normalDamage = Math.Max(0, heroAttack - monsterDefense);
            Console.WriteLine($"Normal Attack would deal: {normalDamage} damage");

            int powerDamage = Math.Max(0, heroAttack * 2 - monsterDefense);
            Console.WriteLine($"Power Attack would deal: {powerDamage} damage");

            int counterDamage = Math.Max(0, monsterAttack - heroDefense);
            Console.WriteLine($"If Monster counters afterward, it would deal: {counterDamage} damage\n");

            Random rng = new Random(14);
            int roll = rng.Next(1, 101);
            bool isCritical = roll <= 10;
            int criticalDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage;
            Console.WriteLine($"Critical hit roll: {roll} (critical: {isCritical})");
            Console.WriteLine($"If critical, Normal Attack would instead deal: {criticalDamage} damage");
        }
    }
}
