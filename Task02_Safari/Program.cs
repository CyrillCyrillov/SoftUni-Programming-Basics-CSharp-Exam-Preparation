using System;

namespace Task02_Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double bujed = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double sum = fuel * 2.1 + 100;
            if (day == "Sunday")
            {
                sum *= 0.8;
            }
            if (day == "Saturday")
            {
                sum *= 0.9;
            }
            if (sum > bujed)
            {
                Console.WriteLine($"Not enough money! Money needed: {(sum - bujed):F2} lv.");
            }
            else
            {
                Console.WriteLine($"Safari time! Money left: {(bujed - sum):F2} lv.");
            }
        }
    }
}
