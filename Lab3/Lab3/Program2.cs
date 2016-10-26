using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // get input 
            Console.WriteLine("Enter an integer:  ");
            int num = Convert.ToInt32(Console.ReadLine());

            //generate first column 
            Console.WriteLine("Number".PadLeft(5).PadRight(10) + "Squared".PadRight(10) + "Cubed");
            Console.WriteLine("=======".PadLeft(5).PadRight(10) + "=======".PadRight(10) + "========");
            //Console.WriteLine(string.Format("{ 0; -10} {1;-10} {2;-10}"), "=======", "=======", "=======");

            for (int i = 1; i <= num; i++)
            {
                double square = Math.Pow(i, 2);
                double cube = Math.Pow(i, 3);
                //Console.WriteLine("    " + i + "          " + square + "          " + cube);
                //Console.WriteLine(sI.PadLeft(5).PadRight(20) +  square + "       " + cube);
                Console.WriteLine(string.Format("{ 0,10} {1,-10} {2,-10}"), i, square, cube);
            }

            //print table
        }
    }
}
