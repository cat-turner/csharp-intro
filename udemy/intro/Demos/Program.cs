using System;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demos from udemy intro class");

            // Section 3.17 - Variables and Constants
            VariablesConstants variablesConstants = new VariablesConstants();
            variablesConstants.variables();

            // Section 3.18 - Type Conversion
            TypeConversion typeConverter = new TypeConversion();
            typeConverter.castingExample();
            typeConverter.demoByteInt();
        }
    }
}
