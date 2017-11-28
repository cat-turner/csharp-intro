using System;

namespace Demos
{
    public class Arrays
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

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            // note that the second and third elements will be false

            var names = new string[3] {"Jack", "John", "Mary"};
        }
    }
}