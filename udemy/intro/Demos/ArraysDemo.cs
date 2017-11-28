using System;

namespace Demos
{
    public class ArraysDemo
    {
        public static void declaringArrays()
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            int[] numbersShortDelcare = new int[3] { 1, 2, 3};

        }

        public static void Demo()
        {   // keep it short with var, don't declare int[] since we 
            // already use new
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            Console.WriteLine(numbers);
        }
    }
}