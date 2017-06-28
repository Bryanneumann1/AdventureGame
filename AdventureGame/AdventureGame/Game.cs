using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{


    public class Game
    {
        string characterName;

        public Game()
        {
            
        }
        public void DisplayRules()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Adventure Game!!");
            Console.ResetColor();
            Console.WriteLine("In this game you will be going on a hunting adventure and you will make the choices that will decide your fate!");
            Console.WriteLine("What would you like your characters name to be?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            characterName = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Ok " + characterName + " lets start our hunting adventure!");
           
            Woods BeginHunt = new Woods();
            BeginHunt.BeginGame();
        }
        
    }
}


