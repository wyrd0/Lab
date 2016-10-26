 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            string state = "begin";
            bool gameOn = true;
            while (gameOn)
            {
                switch (state)
                {
                    case "begin": //establish setting
                        Console.WriteLine("The carnival atmosphere is thick with the smell of airborne sugar and sweat.  Your senses are overwhelmed with the frenetic vibration of crowd energy and the repeated boom of 'STEP RIGHT UP!'");
                        Console.WriteLine("");
                        Console.WriteLine("You're due at the Ferris Wheel in 10 minutes to meet your little brother, but you're still hoping to rescue your evening with at least one worthwhile experience. You cast about, trying to parse the blooming, buzzing confusion of this lame but oddly creepy middle school carnival.");
                        Console.WriteLine("");
                        //Console.WriteLine("Suddenly, you're caught offgaurd when a bulbous face appears just inches from your own.  Hot, sulpherous breath and words explode like a firecracker from the gin-blossomed face. 'AND WHAT'S YOUR NAME, CHILD?' demands the face.");
                        //Console.WriteLine("Before you even have time to take offense at being called a child, you blurt out:");
                        //string uName = Console.ReadLine();
                        //Console.WriteLine("The face disappears as quickly as it had appeared, carried away on the tide of the crowd.");
                        //Console.WriteLine("Feeling a little silly, you roll your eyes and continue walking");
                        
                        Console.Write("Would you like to continue? (y/n)  ");
                        string proceed = Console.ReadLine();
                        proceed = proceed.ToLower();
                        if (proceed == "y")
                        {
                            state = "games";
                        }
                        else
                        {
                            state = "ferrisWheel";
                        }
                       break;

                    case "games":  //present games, get choice
                                   // Console.Clear();
                        Console.WriteLine("You continue to walk.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("To your left, a voice booms, 'Win a prize!  Guess the number of marbles in the jar!!'");
                        Console.WriteLine("'Take your chance!!  Dunk an already wet and sad carny!!' cries a voice to your right.");
                        Console.WriteLine("'Your Destiny beckons. Ignore this call at your own risk,' hisses a low voice that seems to come from just inside the right side of your skull.");
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to play the Marbles game (M), the Dunk game (D), answer the Call of destiny (C) or just Leave (L)?");
                        
                        string uGame = Console.ReadLine();
                        if (uGame == "Marbles")
                        {
                            state = "marbles";
                        }
                        else if (uGame == "Dunk")
                        {
                            state = "dunk";
                        }
                        else if (uGame == "Destiny")
                        {
                            state = "destiny";
                        }
                        else if (uGame == "Leave")
                        {
                            state = "ferrisWheel";
                        }

                        break;
                    case "ferrisWheel":  //exit to ferris wheel
                        Console.Clear();
                        Console.WriteLine("You wander back toward the Ferris Wheel to meet your little brother. 'Nothing interesting ever happens around here,' you think.  Womp wa.");
                        gameOn = false;
                        break;
                    case "marbles":  //play guess the marbles game
                        Console.WriteLine("You eye the mason jar full of marbles.");
                        Console.WriteLine("How many marbles are in the jar?");
                        int marblesA = int.Parse(Console.ReadLine());
                        if (marblesA >= 100)
                        {
                            Console.WriteLine("The game conductor laughs, 'Silly child! Perhaps you should ride the Ferris Wheel instead.'");
                            state = "ferrisWheel";
                        }
                        else if (marblesA > 100 && marblesA < 500)
                        {
                            Console.WriteLine("'Close enough!' booms the game conductor and tosses a stuffed penguin at you.");
                            state = "ferrisWheel";
                        }
                        else if (marblesA >= 500)
                        {
                            Console.WriteLine("The game conductor laughs, 'Silly child! Perhaps you should ride the Ferris Wheel instead.'");
                            state = "ferrisWheel";
                        }
                        break;
                    case "dunk": //dunk game
                        Console.Clear();
                        Console.WriteLine("'Step right up!' yells the game conductor, handing you a dirty projectile.  'Dunk this sad fella in 3 tries and win a prize!!'");
                        Console.WriteLine("You take the ball reticently and take aim.");
                        Console.WriteLine("Your first try is a hit.  The poor, wet man falls once again into the tank.");
                        Console.WriteLine("You feel unsettled and dissatisfied... and a little dirty.");
                        state = "ferrisWheel";
                        break;
                     
                    case "destiny":  //enter gypsy's tent
                        Console.Clear();
                        Console.WriteLine("As you make your way to the Tarot Reader's tent, you glance at your watch.  Ain't nobody got time for that!");
                        state = "ferrisWheel";
                        break;
                    default:
                        Console.WriteLine("Maybe you'll just head back toward the ferris wheel and wait for your brother... meh.. I guess this evening was a wash, after all.");
                        gameOn = false;
                        break;
                }


            }
        } 
    }
}