using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Task03_Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            double helpPrise = 0;
            string period = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            int mounts = int.Parse(Console.ReadLine());
            double sum = 0;
            if (period == "one" && type == "Small")
            {
                helpPrise = 9.98;
            }
            if (period == "one" && type == "Middle")
            {
                helpPrise = 18.99;
            }
            if (period == "one" && type == "Large")
            {
                helpPrise = 25.98;
            }
            if (period == "one" && type == "ExtraLarge")
            {
                helpPrise = 35.99;
            }

            if (period == "two" && type == "Small")
            {
                helpPrise = 8.58;
            }
            if (period == "two" && type == "Middle")
            {
                helpPrise = 17.09;
            }
            if (period == "two" && type == "Large")
            {
                helpPrise = 23.59;
            }
            if (period == "two" && type == "ExtraLarge")
            {
                helpPrise = 31.79;
            }

            if (helpPrise <= 10)
            {
                sum = (helpPrise + 5.5) * mounts;
            }
            if (helpPrise > 10 && helpPrise <= 30)
            {
                sum = (helpPrise + 4.35) * mounts;
            }
            if (helpPrise > 30)
            {
                sum = (helpPrise + 3.85) * mounts;
            }
            if (period == "two")
            {
                sum = sum - (sum * 0.0375);
            }





            Console.WriteLine($"{sum:F2} lv.");
        }
    }
}
