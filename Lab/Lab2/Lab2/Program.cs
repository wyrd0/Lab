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

            string state = "1";
            bool gameOn = true;
            while (gameOn)
            {
                switch (state)
                {
                    case "begin": //establish carnival setting, intro 3 games
                        Console.WriteLine("The air around you is thick with sucrose particles, crowd energy and the repeated sound of 'STEP RIGHT UP!'");
                        Console.WriteLine("'Get your prize!  Guess the number of marbles in this jar!!' comes a voice from your left.");
                        Console.WriteLine("'Your chance to dunk an already wet and sad carny!!' cries someone to your right.");
                        Console.WriteLine("'Learn deep truths about yourself and your destiny,' intimates a more salient voice that seems to come from just inside your skull.");
                        break;

                    case "games":  //choose game; get name

                        break;
                    case "ferrisWheel":  //exit to ferris wheel
                        gameOn = false;
                        break;
                    case "guess":  //play guess the marbles game

                        break;
                    case "4a": //
                     
                    case "tarot":  //enter gypsy's tent
                    default:
                        break;
                }


            }
        } 
    }
}