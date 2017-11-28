using System;

namespace Demos
{
    public class Strings
    {
        public static void CreatingStrings()
        {
            // string literal
            string firstName = "Mosh";
            string lastName = "Potatoes";

            // concat
            // ugly example:
            //string name = firstName + " " + lastName;
            // better example:
            string name = string.Format("{0} {1}", firstName, lastName);

            var numbers = new int[3] { 1, 2 , 3 };
            var combinedNumbers = string.Join(',', numbers);

            var multiline = " This is multiple lines \n WOW \n WOW";
            System.Console.WriteLine(multiline);

            // Verbatim Strings - use @ instead of \\ to interprete literally
            string uglyPath = "c:\\User\\batman\\docs";
            string betterPath = @"c:\User\batman\docs";
            System.Console.WriteLine(betterPath);

        }

        public static void Demo()
        {
            // Primitive types are all structures
            
            var firstName = "Mosh";
            // note that all primitive types map to a type in the .NET framework
            int number; // hover on int, you'll see System.Int32
            
            // no difference between these two
            String lastName = "Gaga"; //.NET framework type
            string lastNameToo = "Gaga";

            var myFullName = string.Format("My is {0} {1}.", "Slim", "Shady");
            System.Console.WriteLine(myFullName);

            var text = "Hi John\n Look into the following paths:\nc:\\User\\batman\\docs\nc:\\User\\batman\\ohgawdwhy";
            Console.WriteLine(text);

            var textEasierToRead =  @"Hi John
Look into the following paths:
            c:\\User\\batman\\docs
            c:\\User\\batman\\ohgawdwhy";
            Console.WriteLine(textEasierToRead);



        }
    }
}