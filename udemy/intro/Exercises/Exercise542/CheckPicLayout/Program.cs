using System;

namespace CheckPicLayout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, give me your pic's width:");
            float picWidth = float.Parse(Console.ReadLine());
            Console.WriteLine("now give me your pic's length:");
            float picLength = float.Parse(Console.ReadLine());
            Picture picInput =  new Picture(picWidth, picLength);
            Console.WriteLine("Your picture layout is {0}",picInput.layout);

        }
    }
}
