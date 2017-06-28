using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Woods
    {

        public Woods()
        {

        }

        
        public void BeginGame()
        {
            Console.WriteLine("Would you like to get out of the truck and head into the woods to start hunting? Please enter (yes) or (no)");
            string starthunt = Console.ReadLine();
            {
                if (starthunt == "yes")
                {
                    Console.WriteLine("Alright, Lets find a good place to hunt");
                    TreeStand ChooseStand = new TreeStand();
                    ChooseStand.ChooseSpot();
                }
                else if (starthunt == "no")
                {
                    Console.WriteLine("Sorry, You fell asleep and didnt wake up until it was dark, your hunt is over!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter yes or no");
                    BeginGame();
                }

            }
        }
    }
}