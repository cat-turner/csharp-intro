using System;

namespace GetMaxOfTwoVals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two numbers. I'll tell you which one is bigger");
            Console.WriteLine("First Number:");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Second Number:");
            float secondNumber = float.Parse(Console.ReadLine());
            float maxNumber;
            if (firstNumber < secondNumber)
            {
                maxNumber = secondNumber;
            }
            else
            {
                maxNumber = firstNumber;
            }
            Console.WriteLine(string.Format("Ah, {0} is the max", maxNumber));
        }
    }
}
