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
                        Console.WriteLine("You're due at the Ferris Wheel in 10 minutes to meet your little brother, but you're still hoping to rescue your evening with at least one worthwhile experience. You cast about, trying to parse the blooming, buzzing confusion of this lame but oddly carnivalesque middle school carnival.");
                        Console.WriteLine("");
                        Console.WriteLine("Suddenly, you're caught offgaurd when a bulbous face appears just inches from your own.  Hot, sulpherous breath and words explode like a firecracker from the gin-blossomed face. 'AND WHAT'S YOUR NAME, CHILD?' demands the face.");
                        Console.WriteLine("Before you even have time to take offense at being called a child, you blurt out:");
                        string uName = Console.ReadLine();
                        Console.WriteLine("The face disappears as quickly as it had appeared, carried away on the tide of the crowd.");
                        Console.WriteLine("Feeling a little silly, you roll your eyes and continue walking");
                        state = "games";
                        break;

                    case "games":  //present games, get choice
                        Console.WriteLine("'Win a prize!  Guess the number of marbles in the jar!!' blasts at you from your left.");
                        Console.WriteLine("'Take your chance!!  Dunk an already wet and sad carny!!' cries a voice to your right.");
                        Console.WriteLine("'Answer the call of Destiny,__. Ignore this call at your own risk,' hisses a low voice that seems to come from just inside the right side of your skull.");
                        Console.WriteLine("");
                        Console.WriteLine("Do you want to play the Marbles game?");
                        Console.WriteLine("Do you want to play the Dunk game?");
                        Console.WriteLine("Do you want to answer the call of Destiny?");
                        Console.WriteLine("Do you just want to Leave?");
                        Console.WriteLine("Please respond with 'Marbles', 'Dunk', 'Destiny' or 'Leave':  ");
                        string uGame = Console.ReadLine();
                        if (uGame = "Marbles")
                        {
                            state = "marbles";
                        }
                        else if (uGame = "Dunk")
                        {

                        }

                        break;
                    case "ferrisWheel":  //exit to ferris wheel
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
                    case "4a": //
                     
                    case "destiny":  //enter gypsy's tent

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