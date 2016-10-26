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
            for (int i = 1; i <= num; i++)
            {
                double square = Math.Pow(i, 2);
                double cube = Math.Pow(i, 3);
                Console.WriteLine(i + "     " + square + "       " + cube);
            }

            //print table
        }
    }
}
