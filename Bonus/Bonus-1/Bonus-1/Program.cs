using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string proceed = "y";
            while (proceed == "y" || proceed == "Y")
            { //get user input
                Console.WriteLine("Welcome to the Letter Grade Converter!");
                Console.WriteLine("   ");
                Console.WriteLine("Enter a numerical grade:  ");
                double input = int.Parse(Console.ReadLine());
                //process input, 
                if (input >= 88 && input <= 100)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (input >= 80 && input <= 87)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (input >= 67 && input <= 79)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (input >= 60 && input <= 66)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else if (input >= 0 && input <= 60)
                {
                    Console.WriteLine("Letter Grade: F");
                }
                else
                    Console.WriteLine("Invalid entry");

                Console.WriteLine("Continue? (y/n)?");
                proceed = Console.ReadLine();
            }
        }
    }
}
    