using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class TreeStand
    {
        public void Location()
        {

        }
        public void ChooseSpot()
        {
            Console.Write("Would you like to set up a tree stand or set up a ground blind? \n");
            string stand = Console.ReadLine();

            switch (stand)
            {
                case "ground blind":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You accidentally set up your "+stand+" on a underground bee's nest and got attacked! Better luck next time. ");
                    Console.ResetColor();
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case "tree stand":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You picked a great spot to set up your " + stand + "! It looks like this spot has a lot of deer activity!");
                    Console.ResetColor();
                    Deer ChooseDeer = new Deer();
                    ChooseDeer.Pickdeer();
                    break;
                default:
                    Console.WriteLine("Please choose either a (Tree stand) or (Ground blind)");
                    ChooseSpot();
                    break;
            }


        }


    }
}
