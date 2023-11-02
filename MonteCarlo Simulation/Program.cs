using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monte Carlo Simulation");
            Console.WriteLine();

            Console.WriteLine("Press any key to start...");
            Console.WriteLine("Press any key to quit...");
            Console.WriteLine();
            Console.ReadKey(true);

            int count;
            count = 0;

            int[] amounts = new int[12];

            Random rng = new Random();

            while (!Console.KeyAvailable)
            {
                int dice1 = rng.Next(1, 7);
                int dice2 = rng.Next(1, 7);
                Debug.Assert(dice1 >= 1);
                Debug.Assert(dice2 >= 1);
                Debug.Assert(dice1 <= 6);
                Debug.Assert(dice2 <= 6);

                int result = dice1 + dice2;
                Debug.Assert(result >= 2);
                Debug.Assert(result <= 12);

                amounts[result - 1]++;

                count++;
                if (count % 100000 == 0)
                {
                    Console.WriteLine("Dice Roll #" + count + ": " + result);
                    for (int i = 0; i <= 11; i++)
                    {
                        Console.WriteLine((i + 1) + ": " + amounts[i]);
                    }
                }
            }
            Console.ReadKey(true);


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
