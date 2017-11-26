using System;

namespace Demos
{
    public class TypeConversion
    {
        public void castingExample(){
            System.Console.WriteLine("example");
            // explicit casting
            float f = 1.0f;
            // tell compiler that you're aware of data loss
            int i = (int)f;
            System.Console.WriteLine(i);

            // converting non-compatible types
            string s = "1";
            int k = Convert.ToInt32(s);
            int j = int.Parse(s);
            System.Console.WriteLine("{0} {1}", k, j);

            string str = "true";
            bool bs = Convert.ToBoolean(str);
            Console.WriteLine(bs);

        }

        public void demoByteInt(){
            Console.WriteLine("Demo");
            byte b = 1;
            int i = b;
            System.Console.WriteLine(i);

            // cannot implicitly convert. Need to cast
            int v = 1000;
            byte y = (byte)v;
            Console.WriteLine(y); // now you see data loss

            //incompatible data types
            try
            {
                var number = "1234";
                byte nb = Convert.ToByte(number);
                Console.WriteLine(nb); // you'll see the overflow exception, number is too large for an unsigned byte
                
            }
            catch (System.OverflowException)
            {

                Console.WriteLine("The number could not be converted to a byte");
            }

        }
    }
}