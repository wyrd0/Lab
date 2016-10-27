using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string proceed = "y";
            do
            {
                //get input (long 1-10)
                Console.WriteLine("Welcome to the Factorial Calculator!");
                Console.WriteLine("Enter an integer that is greater than 1 and less than 10:   ");
                string input = Console.ReadLine();
                long number;
                if (long.TryParse(input, out number))
                {
                    //Console.Write(number);
                }

                //calculate, display factorial
                long factorial = 1;
                for (long i = 2; i <= number; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("The factorial of " + input + " is " + factorial);

                //Proceed?
                Console.WriteLine("Continue? (y/n)");
                proceed = Console.ReadLine();
            } while (proceed == "y");
            //validate

        }
    }
}
