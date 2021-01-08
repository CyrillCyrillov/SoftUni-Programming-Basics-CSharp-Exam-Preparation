using System;
using System.Diagnostics.CodeAnalysis;

namespace Task01_Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chikenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegitarianMenu = int.Parse(Console.ReadLine());
            double sum = (((chikenMenu * 10.35) + (fishMenu * 12.4) + (vegitarianMenu * 8.15)) * 1.2) + 2.5;            
            
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
