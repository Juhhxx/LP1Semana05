using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main()
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();

            Thread.Sleep(600);

            crono2.Start();

            Thread.Sleep(200);

            crono1.Stop();
            crono2.Stop();

            float timeCrono1 = crono1.ElapsedMilliseconds/1000f;
            float timeCrono2 = crono2.ElapsedMilliseconds/1000f;

            Console.WriteLine($"{timeCrono1:f3}");
            Console.WriteLine($"{timeCrono2:f3}");

        }
    }
}
