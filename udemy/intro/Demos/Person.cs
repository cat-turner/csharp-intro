/* Lecture on Classes */
namespace Demos
{
    public class Person
    {
        public string Name = "Billy";

        public void Introduce()
        {
            System.Console.WriteLine("hi, my name is " + this.Name);
        }

        /* Standard Practice is to put classes in their own file */
        public class PersonDemo
        {
            public string FirstName;
            public string LastName;

            public void Introduce()
            {
                System.Console.WriteLine("My name is " + FirstName + " " + LastName);
            }
        }


    }
}