using System;


namespace MixTape
{
    class MadLibs
    {

        public void Title(string title = "~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~")
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("███╗   ███╗ █████╗ ██████╗ ██╗     ██╗██████╗ ███████╗██╗");
            Console.WriteLine("████╗ ████║██╔══██╗██╔══██╗██║     ██║██╔══██╗██╔════╝██║");
            Console.WriteLine("██╔████╔██║███████║██║  ██║██║     ██║██████╔╝███████╗██║");
            Console.WriteLine("██║╚██╔╝██║██╔══██║██║  ██║██║     ██║██╔══██╗╚════██║╚═╝");
            Console.WriteLine("██║ ╚═╝ ██║██║  ██║██████╔╝███████╗██║██████╔╝███████║██╗");
            Console.WriteLine("╚═╝     ╚═╝╚═╝  ╚═╝╚═════╝ ╚══════╝╚═╝╚═════╝ ╚══════╝╚═╝");
            Console.WriteLine("");
            Console.WriteLine($"~ {title} ~");
            Console.WriteLine("");
        }

        public void End()
        {
            //prompt any key to return to menu - esc to escape - S to save
            Console.WriteLine("");
            Console.WriteLine("Press S to Save, M to return to the menu, or ESC to exit.");

            //string userInput = Console.ReadLine().ToUpper();
            Program program = new Program();
            //Console.WriteLine("Hello World!");
            

            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.S:
                Console.WriteLine("Save not available. Please Choose another option.");
                End();
                break;
                case ConsoleKey.M:
                Console.WriteLine("Returning to Menu");
                program.Menu();
                break;
                case ConsoleKey.Escape:
                Console.WriteLine("");
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;
                default:
                End();
                break;
                
            }





        }

    }
}
