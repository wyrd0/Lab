using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.WriteLine("igpay atinlay anslatortray");
            Console.WriteLine("  ");
            //StringBuilder PL = new StringBuilder();
            Console.WriteLine("Please enter a word:  ");
            string word = Console.ReadLine();
            //PL = PL.Append(Console.ReadLine());
            
            //to lowercase
            word = word.ToLower();
            //Console.WriteLine(word);
            
            //starts w/ vowel?
            string vowel = "aeiou";
            if (vowel.Contains(word[0]))
            {
                string plOut = (word + "way");
                Console.WriteLine(plOut);
            }
             else word.IndexOf(word.);
            else
              {
                //find first vowel
                int wIndex = word.IndexOf("a")
                }
                word.IndexOf("a");



            //int loc = word.IndexOf()

            //process if yes (+way)

            //process if no (move substr before 1st vowel to end, add 'ay')

        }
    }
}
