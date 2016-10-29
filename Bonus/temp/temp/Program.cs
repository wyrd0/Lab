using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int input = 0;
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("You sleected 1");
            }
            else if (input == 2)
            {
                Console.WriteLine("You selected 2");
            }*/


            int input = 0;
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: Console.WriteLine("You selected 1");
                    break;
                case 2: Console.WriteLine("You selected 2");
                    break;
                default: Console.WriteLine("you selected badness");
                    break;
            }

        }


    }
}
