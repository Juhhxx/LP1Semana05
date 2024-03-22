using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int enemyCount = int.Parse(args[0]);
            Enemy[] enemyArray = new Enemy[enemyCount];

            for (int i = 0; i < enemyCount; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();

                Enemy newEnemy = new Enemy(name);
                enemyArray[i] = newEnemy;
            }

            // enemyArray[0].TakeDamage(50);
            // enemyArray[1].PickupPowerUp(PowerUp.Shield,100);

            foreach (Enemy enemyInst in enemyArray)
            {
                Console.WriteLine($"{enemyInst.GetName()} {enemyInst.GetHealth()} {enemyInst.GetShield()}");
            }

            // Console.WriteLine(enemyArray[0].GetPowerPickUp());

        }
    }
}
