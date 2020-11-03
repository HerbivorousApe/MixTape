using System;


namespace MixTape
{
    class MadLibs
    {

        public void Heading()
        {
            Console.WriteLine("");
            Console.WriteLine("███╗   ███╗ █████╗ ██████╗ ██╗     ██╗██████╗ ███████╗██╗");
            Console.WriteLine("████╗ ████║██╔══██╗██╔══██╗██║     ██║██╔══██╗██╔════╝██║");
            Console.WriteLine("██╔████╔██║███████║██║  ██║██║     ██║██████╔╝███████╗██║");
            Console.WriteLine("██║╚██╔╝██║██╔══██║██║  ██║██║     ██║██╔══██╗╚════██║╚═╝");
            Console.WriteLine("██║ ╚═╝ ██║██║  ██║██████╔╝███████╗██║██████╔╝███████║██╗");
            Console.WriteLine("╚═╝     ╚═╝╚═╝  ╚═╝╚═════╝ ╚══════╝╚═╝╚═════╝ ╚══════╝╚═╝");
            Console.WriteLine("");
        }

        public void Title(string title = "~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~")
        {
            Console.Clear();

            Heading();
            Console.WriteLine($"~ {title} ~");
            Console.WriteLine("");
        }


        public void Menu()
        {
            Program program = new Program();
            ML_Vacation vacation = new ML_Vacation();
            ML_Dentist dentist = new ML_Dentist();
            ML_News news = new ML_News();

            Console.Clear();
            Heading();

            Console.WriteLine("     1. Vacations");
            Console.WriteLine("     2. A Visit to the Dentist");
            Console.WriteLine("     3. Weird News");
            Console.WriteLine("");
            Console.WriteLine("     M. Return to Main Menu");
            Console.WriteLine("     ESC. Exit to DOS");
            //Menu
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                vacation.ML();
                break;
                case ConsoleKey.D2:
                dentist.ML();
                break;
                case ConsoleKey.D3:
                news.ML();
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
                Menu();
                break;
                
            }
        }

        public void End()
        {
            Console.WriteLine("");
            Console.WriteLine(" Press M to return to the menu, or ESC to exit.");
            End2();
        }

        public void End2() {
            Program program = new Program();
            switch(Console.ReadKey(true).Key)
            {
                //case ConsoleKey.S:
                //Console.WriteLine("Save not available. Please Choose another option.");
                //End2();
                //break;
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
                End2();
                break;  
                }
            
        }
    }
}
