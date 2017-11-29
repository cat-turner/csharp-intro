using System;

namespace CheckInputNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value between 1 and 10");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 10)
            {
                System.Console.WriteLine("Valid");
            }
            else
            {
                System.Console.WriteLine("Invalid");
            }

        }
    }
}

