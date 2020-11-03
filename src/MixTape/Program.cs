﻿using System;

namespace MixTape
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //Console.WriteLine("Hello World!");
            program.Menu();
            
            //vacation.ML();
        }

        public void Menu()
        {

            ML_Vacation vacation = new ML_Vacation();
            Maze maze = new Maze();
            Console.Clear();

            //http://patorjk.com/software/taag/#p=display&f=ANSI%20Shadow&t=MIX%20TAPE
            Console.WriteLine("");
            Console.WriteLine("███╗   ███╗██╗██╗  ██╗    ████████╗ █████╗ ██████╗ ███████╗");
            Console.WriteLine("████╗ ████║██║╚██╗██╔╝    ╚══██╔══╝██╔══██╗██╔══██╗██╔════╝");
            Console.WriteLine("██╔████╔██║██║ ╚███╔╝        ██║   ███████║██████╔╝█████╗  ");
            Console.WriteLine("██║╚██╔╝██║██║ ██╔██╗        ██║   ██╔══██║██╔═══╝ ██╔══╝  ");
            Console.WriteLine("██║ ╚═╝ ██║██║██╔╝ ██╗       ██║   ██║  ██║██║     ███████╗");
            Console.WriteLine("╚═╝     ╚═╝╚═╝╚═╝  ╚═╝       ╚═╝   ╚═╝  ╚═╝╚═╝     ╚══════╝");
            Console.WriteLine("");
            Console.WriteLine($"~ By: Herbivorous Ape ~");
            Console.WriteLine("                                    _________");
            //http://patorjk.com/software/taag/#p=display&f=Calvin%20S&t=MAIN%20MENU
            Console.WriteLine(" ╔╦╗╔═╗╦╔╗╔  ╔╦╗╔═╗╔╗╔╦ ╦          |   ___   |");
            Console.WriteLine(" ║║║╠═╣║║║║  ║║║║╣ ║║║║ ║          |  o___o  |");
            Console.WriteLine(" ╩ ╩╩ ╩╩╝╚╝  ╩ ╩╚═╝╝╚╝╚═╝          |__/___\\__|");
            Console.WriteLine("");
            Console.WriteLine("     1. MadLibs!");
            Console.WriteLine("     2. Escape the Maze");
            Console.WriteLine("     3. Wheel of Misfortune");
            Console.WriteLine("     ESC. Exit to DOS");
            //Menu
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                vacation.ML();
                break;
                case ConsoleKey.D2:
                maze.Move();
                break;
                case ConsoleKey.D3:
                Console.WriteLine("Wheel of Misfortune");
                break;
                case ConsoleKey.Escape:
                Console.WriteLine("");
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;
                default:
                Menu();
                break;
                
            }
            //Accept Esc to escape, 1, 2, 3, etc. for menu options
        }

    }
}
