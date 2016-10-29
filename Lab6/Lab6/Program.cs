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
            Console.WriteLine("Pig Latin Translator");
            Console.WriteLine("(igpay atinlay anslatortray)");
            Console.WriteLine("  ");

            //set up proceed loop 
            string proceed = "y";
            while (proceed == "y")
            {
                //Get user input
                Console.WriteLine("Please enter a word:  ");
                string word = Console.ReadLine();
                word = word.ToLower();

                //if word starts with a vowel (+way)
                char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
                if (vowel.Contains(word[0]))
                {
                    string way = (word + "way");
                    Console.WriteLine(way);
                }
                //if word starts with a consonant (move substring before 1st vowel to end, add 'ay')
                else
                {
                    int wIndex = word.IndexOfAny(vowel);        //find index of first vowel
                    string ig = word.Substring(wIndex);
                    string pig = ig + word.Substring(0, (wIndex));
                    Console.WriteLine(pig + "ay");
                }
                Console.WriteLine("Translate another word? (y/n)");
                proceed = Console.ReadLine();
                proceed = proceed.ToLower();
                if (proceed == "yes")
                {
                    proceed = "y";
                }
                
            }
            Console.WriteLine("oodbyegay!");
        }

        //NOTES:  words with only 'y' as a vowel (e.g., shy, my) throw exception.  fix.
        // Next, (Extend) Keep case.
    }
}

