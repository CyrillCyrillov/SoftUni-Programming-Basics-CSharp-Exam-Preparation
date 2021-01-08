using System;

namespace Task04_Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double bujed = double.Parse(Console.ReadLine());
            int cont = 0;
            int items = 0;
            double sum = 0;
            string nextItem = " ";
            double nextPrice = 0;

            while (bujed > sum)
            {
                nextItem = Console.ReadLine();

                if (nextItem == "Stop")
                {
                    Console.WriteLine($"You bought {items} products for {sum:F2} leva.");
                    break;
                }
                cont += 1;
                items += 1;
                nextPrice = double.Parse(Console.ReadLine());
                if (cont == 3)
                {
                    sum += nextPrice / 2;
                    cont = 0;
                }
                else
                {
                    sum += nextPrice;
                }
            }
            if (nextItem != "Stop")
            {
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {(sum - bujed):F2} leva!");
            }
        }
    }
}
