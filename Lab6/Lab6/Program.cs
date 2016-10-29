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

            //set up proceed loop 
            string proceed = "y";

            while (proceed == "y")
            {
            //Get user input
            Console.WriteLine("Pig Latin Translator");
                Console.WriteLine("(igpay atinlay anslatortray)");
                Console.WriteLine("  ");
            //StringBuilder PL = new StringBuilder();
            Console.WriteLine("Please enter a word:  ");
            string word = Console.ReadLine();
            //PL = PL.Append(Console.ReadLine());

            //to lowercase
            word = word.ToLower();
                //Console.WriteLine(word);

                //starts w/ vowel?  process if yes (+way)
                char[] vowel = {'a','e','i','o','u' };
            if (vowel.Contains(word[0]))
            {
                string way = (word + "way");
                Console.WriteLine(way);
            }
                //process if no(move substring before 1st vowel to end, add 'ay')
            else 
              {
                int wIndex = word.IndexOfAny(vowel);        //find index of first vowel
                string ig = word.Substring(wIndex);
                string pig = ig + word.Substring(0, (wIndex));
                Console.WriteLine(pig + "ay");
            }
            Console.WriteLine("Translate another word? (y/n)");
            proceed = Console.ReadLine();
            }
            Console.WriteLine("oodbyegay!");
        }

        //NOTES:  words with only 'y' as a vowel (e.g., shy, my) throw exception.  fix.
        
    }
    }

