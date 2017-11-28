using System;
using Demos.Math;

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

            // Section 3.20 - Operators
            Operators operatorExamples = new Operators();
            operatorExamples.incrementExample();
            operatorExamples.demo();

            // Section 4 - Non-primative 

            // Section 4.26 - Classes
            Person classExample = new Person();
            classExample.Introduce();
            Person.PersonDemo student = new Person.PersonDemo();
            student.FirstName = "John";
            student.LastName = "Soda";
            student.Introduce();
            var result = Calculator.Add(1,2);
            Console.WriteLine("Result is {0}", result);

            
        }
    }
}
