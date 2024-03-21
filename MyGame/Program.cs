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
                Console.Write($"Nome do inimigo 1: ");
                string name = Console.ReadLine();

                Enemy newEnemy = new Enemy(name);
                enemyArray[i] = newEnemy;
            }

            foreach (Enemy enemyInst in enemyArray)
            {
                Console.WriteLine($"{enemyInst.GetName()} {enemyInst.GetHealth()} {enemyInst.GetShield()}");
            }

        }
    }
}
