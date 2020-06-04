using System;
using System.Threading;

namespace 世_界
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ごめん┙");
            Thread.Sleep(1000);
            for (var i = 0; i < 80; i++)
            {
                Console.WriteLine("┙");
                Thread.Sleep(100);
            }

            Console.WriteLine("さよなら");
            Thread.Sleep(10000);
        }
    }
}