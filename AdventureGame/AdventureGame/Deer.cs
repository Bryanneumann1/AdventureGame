using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Deer
    {


        public void Option()
        {

        }
        public void Pickdeer()
        {
            
            Console.Write("You see a deer in the distance, it's a buck! Its hard to tell how big of a deer it is \n" +
                "because its in some thick brush. Do you decide to shoot or wait for a better shot? Please type \n" +
                "(shoot) or (wait)\n");
           
            string option = Console.ReadLine();

            switch (option)
            {
                case "shoot":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You take your shot! The smoke slowly dicipates and you realize that your bullet \n" +
                        "hit a tree. You watch the deer run off into the forest and you start to cry because you missed \n" +
                        "your opportunity. Better luck next time");
                    Console.ResetColor();
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case "wait":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You patiently wait for a better shot, the deer finally clears the thick brush and you realize \n" +
                        "this is the biggest buck you've ever seen. You take a deep breath and squeeze the trigger when the perfect shot \n" +
                        "presents itself. Well done, you just bagged the biggest trophy in your life!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please choose either (shoot) or (wait).");
                    Pickdeer();
                    break;

            }

        }
    }
}
