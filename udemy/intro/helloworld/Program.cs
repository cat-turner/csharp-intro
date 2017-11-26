using System;


namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var name = Environment.MachineName;
            Console.WriteLine("Hello {0}",name);
        }
    }
}
