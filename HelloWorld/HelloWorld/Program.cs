using System;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("abc");
            int n1 = 5;
            int n2 = 2;
            Console.WriteLine("sum = " + (n1 + n2));
            var t1 = "Hello";

            //single line comment

            /*
             * multi line
             * comment
             */

            double d1 = 5.7;
            double d2 = 54.2;
            Console.WriteLine("double sum is " + (d1 + d2));

            Console.WriteLine("Enter a whole number: ");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + n4);
            if (n4 > 10)
            {
                Console.WriteLine("Your nubmer is greater than 10");
            }
            else
            {
                Console.WriteLine("Your number is less than or equal to 10");
            }

            string choice = "y";
            while (choice.Contains("y"))
            {
                Console.WriteLine("In the loop...");
                Console.WriteLine("Continue?");
                choice = Console.ReadLine();
            }
        }
    }
}
