using System;
using Demos.Math;


namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demos from udemy intro class");

            // Primitive Types - int, char, float, bool, etc
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

            // Section 4 - Non-primative Types

            // Section 4.26 - Classes
            Person classExample = new Person();
            classExample.Introduce();
            Person.PersonDemo student = new Person.PersonDemo();
            student.FirstName = "John";
            student.LastName = "Soda";
            student.Introduce();
            // Call the public static method
            var result = Calculator.Add(1,2);
            Console.WriteLine("Result is {0}", result);

            // Section 4.28 - Structs
            CoOrds coordsExample = new CoOrds(10, 10);
            System.Console.WriteLine("Coordinates:");
            System.Console.WriteLine("X:{0}, Y:{1}", coordsExample.x, coordsExample.y);

            // Section 4.30 - Arrays
            Arrays.Demo();

            // Section 4.31 - Strings
            Strings.CreatingStrings();
            Strings.Demo();

            // Section 4.33 - Enums
            var shippingData = Enums.ShippingMethod.Express;
            System.Console.WriteLine((int)shippingData);
            var methodId = 3;
            System.Console.WriteLine((Enums.ShippingMethod)methodId);
            // explicitly convert enum to string
            Console.WriteLine(shippingData.ToString());
            
            // conver/parse the string to an enumeration
            var methodName = "Express";
            // type object - metadata about other types
            // note that Parse returns an object, so you need to 
            //cast it to Emums.Shipping Method to store in variable
            var shippingMethod = (Enums.ShippingMethod)Enum.Parse(typeof(Enums.ShippingMethod), methodName);

            // Section 4.36 - Reference Types and Value Types
            ReferenceValueTypes.Demo();

            /* What I have learned till this point:
            -there are 2 categories of types in C#: classes and structures
            -structures: primitive types, custom structures
            -classes: strings, arrays, custom classes
            -See previous sections for examples*/


        }
    }
}
