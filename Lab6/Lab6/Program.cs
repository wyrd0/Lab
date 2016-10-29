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
            char[] vowel = {'a','e','i','o','u' };
            if (vowel.Contains(word[0]))
            {
                string plOut = (word + "way");
                Console.WriteLine(plOut);
            }
            //find index of first vowel
            else 
              {
                int wIndex = word.IndexOfAny(vowel);
                string ig = word.Substring(wIndex);
                string pig = ig + word.Substring(0, (wIndex));
                Console.WriteLine(pig + "ay");
            }
            
        }
           

            //int loc = word.IndexOf()

            //process if yes (+way)

            //process if no (move substr before 1st vowel to end, add 'ay')

        }
    }

