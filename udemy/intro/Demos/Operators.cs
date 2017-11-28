using System;

namespace Demos
{
    public class Operators
    {
        public void incrementExample()
        {
            int a = 1;
            int b = a++;
            System.Console.WriteLine("this is a: {0}", a);
            System.Console.WriteLine("this is b: {0}", b);
            // add increment before var to change value
            int c = 1;
            int d = ++c;
            System.Console.WriteLine("this is c: {0}", c);
            System.Console.WriteLine("this is d: {0}", d);

        }

        public void demo()
        {
            var a = 10;
            var b = 3;
            System.Console.WriteLine(a / b);
            // notice that the result is 3, because you pass ints

            var c = 3;
            System.Console.WriteLine(a + b * c);
            System.Console.WriteLine(a > b);
            System.Console.WriteLine(a == b);
            System.Console.WriteLine(!(a != b));
            /* a is not b = true, but true is
             not false, so result is false*/

        }
    }
}