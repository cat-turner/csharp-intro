using System;

/*SUPER IMPORTANT IN MEMORY ALLOCATION
    Structs - Value Types 
    (primitive types, custrom structs)
        - Allocated on stack
        - Memory allocation done automatically
        - Immediately removed when out of scope
    Classes - Refrence Types
    (arrays, strings, custom classes)
        - You need to allocate memory
        - Memory allocated on heap
        - GC takes care of this
*/

// http://net-informations.com/faq/net/stack-heap.htm
// https://stackoverflow.com/questions/79923/what-and-where-are-the-stack-and-heap
// stack - static memory allocation
// heap - dynamic memory allocation
// both are on ram
// stack is faster because accessing memory is easier - just move pointer to
// block where data is stored (memory address)

namespace Demos
{
    public class ReferenceValueTypes
    {
        public static void Demo()
        {
            /* This Example to shows how copying value types
             and refrence types are different*/

            // Value Types - making change to one doesn't affect the other
            // Values are copied - this takes place in stack
            var a = 10;
            var b = a;
            b++;
            System.Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            // a is not modified because ints are value types
            // and setting b = a only makes a copy and stores data in 
            // target location in memory

            // Reference Types
            var array1 = new int[3]{ 1, 2, 3}; 
            // the var array1 points/references to object on heap
            // data of the array is on the heap
            var array2 = array1;
            // the runtime creates another variable on stack,
            // that points to the same block of memory
            System.Console.WriteLine(
                string.Format("Before: array1[1]: {0}, array2[1]: {1}", array1[1], array2[1]));
            array2[1] = 1000;
            System.Console.WriteLine(
                string.Format("After: array1[1]: {0}, array2[1]: {1}", array1[1], array2[1])); // > woah.gif

            // Example 2 - using static methods and class methods

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() {Age = 20};
            System.Console.WriteLine(string.Format("Before: {0}", person.Age));
            MakeOld(person);
            System.Console.WriteLine(string.Format("After: {0}", person.Age));




        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }


    }
}