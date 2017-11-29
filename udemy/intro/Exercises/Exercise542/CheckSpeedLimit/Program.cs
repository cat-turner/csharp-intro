using System;

namespace CheckSpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the speed limit [km/hr]?");
            float speedLimit = float.Parse(Console.ReadLine());
            Console.WriteLine("How fast are you going [km/hr]?");
            float carSpeed = float.Parse(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok.");
                Environment.Exit(0);
            }
            int pointRate = 5;
            int demeritPts = ((int)carSpeed - (int)speedLimit) / pointRate;
            Console.WriteLine("You got {0} demerit points.", demeritPts);
            if (demeritPts > 12)
            {
                Console.WriteLine("License Suspended");
            }

        }
    }
}
