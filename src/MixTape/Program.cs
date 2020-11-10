using System;

namespace MixTape
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Menu();
        }

        public void Menu()
        {

            MadLibs madLibs = new MadLibs();
            Maze maze = new Maze();
            Wheel wheel = new Wheel();
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
            Console.WriteLine("");
            Console.WriteLine("     ESC. Exit to DOS");
            
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                madLibs.Menu();
                break;
                case ConsoleKey.D2:
                maze.Move();
                break;
                case ConsoleKey.D3:
                wheel.SessionSetup();
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
        }
    }
}
