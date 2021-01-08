using System;

namespace Task06_Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int i = 1; i <= days; i++)
            {
                double sum = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        sum += 2.5;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        sum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                Console.WriteLine($"Day: {i} - {sum:F2} leva");
                totalSum += sum;
            }

            Console.WriteLine($"Total: {totalSum:F2} leva");
        }
    }
}
