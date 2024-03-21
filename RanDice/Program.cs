using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDice = int.Parse(args[0]);
            int randSeed = int.Parse(args[1]);
            int total;

            Random diceResult = new Random(randSeed);

            for (int i = 0; i < numDice; i++)
            {
                total =+ diceResult.Next(1,7);
            }

        }
    }
}
