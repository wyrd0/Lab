using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string uContinue = ("y");
            //if (uContinue == "y")
            while (uContinue == "y")
            {

               // capture user input
                Console.WriteLine("Enter Length:    ");
                string uLength = Console.ReadLine();
                double length = Convert.ToDouble(uLength);

                Console.WriteLine("Enter Width:   ");
                string uWidth = Console.ReadLine();
                double width = Convert.ToDouble(uWidth);

                //process
                double area = (length * width);
                double perimeter = ((2 * length) + (2 * width));


                //output
                Console.WriteLine("Area = " + area);
                Console.WriteLine("Perimeter = " + perimeter);

                Console.WriteLine("Continue? (y/n)");
                uContinue = Console.ReadLine();
            }
                       
         }
    }
}
