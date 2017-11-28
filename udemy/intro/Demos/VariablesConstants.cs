using System;

namespace Demos
{
    public class VariablesConstants
    {
        // keep internal data private
        private byte number = 2;
        private int count = 1;
        private float totalPrice = 20.95f;
        private char character = 'A';
        private string firstName = "Mosh";
        private bool isWorking = false;
        public const float Pi = 3.14f;

        // use public mechanisms to request current state of data
        public void variables()
        {
            System.Console.WriteLine("3.17 - Demo: Variables and Constants");
            Console.WriteLine(this.number);
            Console.WriteLine(this.count);
            Console.WriteLine(this.totalPrice);
            System.Console.WriteLine(this.character);
            System.Console.WriteLine(this.firstName);
            System.Console.WriteLine(isWorking);
            System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            System.Console.WriteLine(Pi);
        }
    }
}