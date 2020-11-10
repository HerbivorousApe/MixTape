using System;

namespace MixTape
{
    public class Maze
    {
        int xLocation = 4;
        int yLocation = 4;
        bool north = true;
        bool south = true;
        bool east = true;
        bool west = true;

        public void MazeTitle()
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("███████╗███████╗ ██████╗ █████╗ ██████╗ ███████╗    ████████╗██╗  ██╗███████╗    ███╗   ███╗ █████╗ ███████╗███████╗");
            Console.WriteLine("██╔════╝██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ████╗ ████║██╔══██╗╚══███╔╝██╔════╝");
            Console.WriteLine("█████╗  ███████╗██║     ███████║██████╔╝█████╗         ██║   ███████║█████╗      ██╔████╔██║███████║  ███╔╝ █████╗  ");
            Console.WriteLine("██╔══╝  ╚════██║██║     ██╔══██║██╔═══╝ ██╔══╝         ██║   ██╔══██║██╔══╝      ██║╚██╔╝██║██╔══██║ ███╔╝  ██╔══╝  ");
            Console.WriteLine("███████╗███████║╚██████╗██║  ██║██║     ███████╗       ██║   ██║  ██║███████╗    ██║ ╚═╝ ██║██║  ██║███████╗███████╗");
            Console.WriteLine("╚══════╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝     ╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝");
            Console.WriteLine("");
        }

        public void returnCoords()
        {
            Console.WriteLine($"Coordinates: ({xLocation}, {yLocation}) - Use the arrow keys to navigate.");
        }

        public void Move()
        {
            MazeTitle();
            returnCoords();
            Console.WriteLine("");
            availableDirection();
            


            Console.WriteLine("");
            Console.WriteLine($" Available Direction(s):");
            if (north) {Console.ForegroundColor = ConsoleColor.Green;}
            Console.WriteLine($"       North");
            Console.ForegroundColor = ConsoleColor.Gray;

            if (west) {Console.ForegroundColor = ConsoleColor.Green;}
            Console.Write($"  West");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($"   +");

            if (east) {Console.ForegroundColor = ConsoleColor.Green;}
            Console.WriteLine($"   East");
            Console.ForegroundColor = ConsoleColor.Gray;

            if (south) {Console.ForegroundColor = ConsoleColor.Green;}
            Console.WriteLine($"       South");
            Console.ForegroundColor = ConsoleColor.Gray;

            if (xLocation == 0 && yLocation == 1) {Map();}

            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                if (north)
                {
                    Console.WriteLine("You head North.");
                    yLocation++;
                }
                else
                {
                    Console.WriteLine("You can't go North.");
                }
                Move();
                break;

                case ConsoleKey.DownArrow:
                if (south)
                {
                    Console.WriteLine("You head South.");
                    yLocation--;
                }
                else
                {
                    Console.WriteLine("You can't go South.");
                }
                Move();
                break;

                case ConsoleKey.RightArrow:
                if (east)
                {
                    Console.WriteLine("You head East.");
                    xLocation++;
                }
                else
                {
                    Console.WriteLine("You can't go East.");
                }
                Move();
                break;

                case ConsoleKey.LeftArrow:
                if (west)
                {
                    Console.WriteLine("You head West.");
                    xLocation--;
                }
                else
                {
                    Console.WriteLine("You can't go West.");
                }
                Move();
                break;

                case ConsoleKey.Escape:
                Console.WriteLine("");
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;

                default:
                Move();
                break;
            }
            
        }

        public void availableDirection()
        {
            north = false;
            south = false;
            east = false;
            west = false;
           Console.ForegroundColor = ConsoleColor.Blue;
           if (xLocation == 0 && yLocation == 0) {north = true; east = true;
           Console.WriteLine("You are in the Southwest corner of the Maple Room. You see a podium to the North.");}
           if (xLocation == 0 && yLocation == 1) {north = true; south = true; east = true;
            Console.WriteLine("You are against the West wall of the Maple Room. You see a map on the podium:");}
           if (xLocation == 0 && yLocation == 2) {south = true; east = true;
           Console.WriteLine("You are in the Northwest corner of the Maple Room. You see a podium to the South.");}
           if (xLocation == 0 && yLocation == 6) {east = true;
           Console.WriteLine("You are at the Western end of the Dusty Hallway. East is the only direction you can go.");}

           if (xLocation == 1 && yLocation == 0) {north = true; west = true;
           Console.WriteLine("You are in the Southeast corner of the Maple Room.");}
           if (xLocation == 1 && yLocation == 1) {north = true; south = true; east = true; west = true;
           Console.WriteLine("You are in the East side of the Maple Room. You see a podium to the West and a Hallway to the East.");}
           if (xLocation == 1 && yLocation == 2) {south = true; west = true;
           Console.WriteLine("You are in the Northeast corner of the Maple Room.");}
           if (xLocation == 1 && yLocation == 6) {east = true; west = true;
           Console.WriteLine("You are in the Dusty Hallway spanning West to East.");}
           
           if (xLocation == 2 && yLocation == 1) {east = true; west = true;
           Console.WriteLine("You are in the Damp Hallway. To the West is the Maple Room. The Damp Hallway continues to the East.");}
           if (xLocation == 2 && yLocation == 6) {east = true; west = true;
           Console.WriteLine("You are in the Dusty Hallway spanning West to East.");}

           if (xLocation == 3 && yLocation == 1) {east = true; west = true;
           Console.WriteLine("You are in the Damp Hallway spanning West to East.");}
           if (xLocation == 3 && yLocation == 3) {north = true; east = true;
           Console.WriteLine("You are in the Southwest corner of the Yellow Room.");}
           if (xLocation == 3 && yLocation == 4) {north = true; south = true; east = true;
           Console.WriteLine("You are against the West wall of the Yellow Room.");}
           if (xLocation == 3 && yLocation == 5) {south = true; east = true;
           Console.WriteLine("You are in the Northwest corner of the Yellow Room.");}
           if (xLocation == 3 && yLocation == 6) {east = true; west = true;
           Console.WriteLine("You are in the Dusty Hallway spanning West to East.");}

           if (xLocation == 4 && yLocation == 1) {east = true; west = true;
           Console.WriteLine("You are in the Damp Hallway. To the East is the Ivy Room. The Damp Hallway continues to the West.");}
           if (xLocation == 4 && yLocation == 3) {north = true; east = true; west = true;
           Console.WriteLine("You are against the South wall of the Yellow Room.");}
           if (xLocation == 4 && yLocation == 4) {north = true; south = true; east = true; west = true;
           Console.WriteLine("You are in the Center of the Yellow Room.");}
           if (xLocation == 4 && yLocation == 5) {north = true; south = true; east = true; west = true;
           Console.WriteLine("You are in the North part of the Yellow Room. There is an exit to the North.");}
           if (xLocation == 4 && yLocation == 6) {south = true; east = true; west = true;
           Console.WriteLine("You are in the Dusty Hallway spanning West to East. To the South you see the Yellow Room.");}

           if (xLocation == 5 && yLocation == 0) {north = true; east = true;
           Console.WriteLine("You are in the Southwest corner of the Ivy Room.");}
           if (xLocation == 5 && yLocation == 1) {north = true; south = true; east = true; west = true;
           Console.WriteLine("You are on the West side of the Ivy Room. The Damp Hallway is to the West.");}
           if (xLocation == 5 && yLocation == 2) {south = true; east = true;
           Console.WriteLine("You are in the Northwest corner of the Ivy Room.");}
           if (xLocation == 5 && yLocation == 3) {north = true; west = true;
           Console.WriteLine("You are in the Southeast corner of the Yellow Room.");}
           if (xLocation == 5 && yLocation == 4) {north = true; south = true; west = true;
           Console.WriteLine("You are on the East side Yellow Room.");}
           if (xLocation == 5 && yLocation == 5) {south = true; west = true;
           Console.WriteLine("You are in the Northeast corner of the Yellow Room.");}
           if (xLocation == 5 && yLocation == 6) {east = true; west = true;
           Console.WriteLine("You are in the Dusty Hallway spanning West to East.");}
           if (xLocation == 5 && yLocation == 8) {north = true; east = true;
           Console.WriteLine("You are in the Southwest corner of the Green Room.");}
           if (xLocation == 5 && yLocation == 9) {south = true; east = true;
           Console.WriteLine("You are in the Northwest corner of the Green Room.");}

           if (xLocation == 6 && yLocation == 0) {north = true; east = true; west = true;
           Console.WriteLine("You are on the South side of the Ivy Room.");}
           if (xLocation == 6 && yLocation == 1) {north = true; south = true; east = true; west = true;
           Console.WriteLine("You are in the center of the Ivy Room.");}
           if (xLocation == 6 && yLocation == 2) {north = true; south = true; east = true; west = true;
           Console.WriteLine("You are in the North part of the Ivy Room. There is an exit to the North.");}
           if (xLocation == 6 && yLocation == 3) {north = true; south = true;
           Console.WriteLine("You are in the Purple Hallway the Ivy Room is to the South and the hall continues to the North.");}
           if (xLocation == 6 && yLocation == 4) {north = true; south = true; east = true;
           Console.WriteLine("You are in the Purple Hallway spanning North to South. There is a crawl space to the East.");}
           if (xLocation == 6 && yLocation == 5) {north = true; south = true;
           Console.WriteLine("You are in the Purple Hallway spanning North to South.");}
           if (xLocation == 6 && yLocation == 6) {north = true; south = true; west = true;
           Console.WriteLine("You are at the East end of the Dusty Hallway. A Purple Hallway spans North to South.");}
           if (xLocation == 6 && yLocation == 7) {north = true; south = true;
           Console.WriteLine("You are in the Purple Hallway. The Green Room is to the North. The hallway continues South.");}
           if (xLocation == 6 && yLocation == 8) {north = true; south = true; west = true;
           Console.WriteLine("You are in the Southeast corner of the Green Room.");}
           if (xLocation == 6 && yLocation == 9) {south = true; west = true;
           Console.WriteLine("You are in the Northeast corner of the Green Room.");}

           if (xLocation == 7 && yLocation == 0) {north = true; west = true;
           Console.WriteLine("You are in the Southeast corner of the Ivy Room.");}
           if (xLocation == 7 && yLocation == 1) {north = true; south = true; west = true;
           Console.WriteLine("You are on the East side of the Ivy Room.");}
           if (xLocation == 7 && yLocation == 2) {south = true; west = true;
           Console.WriteLine("You are in the Northeast corner of the Ivy Room.");}
           if (xLocation == 7 && yLocation == 4) {east = true; west = true;
           Console.WriteLine("You are in a crawl space. The Purple Hallway is to the West. The Dark Room is to the East.");}

           if (xLocation == 8 && yLocation == 3) {north = true; east = true;
           Console.WriteLine("You are in the Southwest corner of the Dark Room.");}
           if (xLocation == 8 && yLocation == 4) {north = true; south = true; east = true; west = true;
           Console.WriteLine("You are on the West side of the Dark Room. There is a crawl space to the West.");}
           if (xLocation == 8 && yLocation == 5) {south = true; east = true;
           Console.WriteLine("You are in the Northwest corner of the Dark Room.");}

           if (xLocation == 9 && yLocation == 3) {north = true; west = true;
           Console.WriteLine("You are in the Southeast corner of the Dark Room.");}
           if (xLocation == 9 && yLocation == 4) {north = true; south = true; west = true;
           Console.WriteLine("You are East side of the Dark Room.");}
           if (xLocation == 9 && yLocation == 5) {north = true; south = true; west = true;
           Console.WriteLine("You are in the Northeast corner of the Dark Room. You see the Dark Hallway to the North.");}
           if (xLocation == 9 && yLocation == 6) {north = true; south = true;
           Console.WriteLine("You are in the Dark Hallway. The Dark Room is to the South. The Dark Hallway continues North.");}
           if (xLocation == 9 && yLocation == 7) {north = true; south = true;
           Console.WriteLine("You are in the Dark Hallway spanning North to South.");}
           if (xLocation == 9 && yLocation == 8) {north = true; south = true;
           Console.WriteLine("You are in the Dark Hallway spanning North to South. You see a faint light to the North.");}
           if (xLocation == 9 && yLocation == 9) {north = true; south = true;
           Console.WriteLine("You are in the Dark Hallway. To your North you see an opening leading outside. The hallway continues South.");}
            Console.ForegroundColor = ConsoleColor.Gray;
           if (yLocation == 10)
            {
                MazeTitle();
                YouWin();
                End();
            }


        }

        public void YouWin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("   ██╗   ██╗ ██████╗ ██╗   ██╗    ███████╗███████╗ █████╗  ██████╗██████╗ ███████╗██████╗ ██╗");
            Console.WriteLine("   ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██╔════╝██╔════╝██╔══██╗██╔════╝██╔══██╗██╔════╝██╔══██╗██║");
            Console.WriteLine("    ╚████╔╝ ██║   ██║██║   ██║    █████╗  ███████╗███████║██║     ██████╔╝█████╗  ██║  ██║██║");
            Console.WriteLine("     ╚██╔╝  ██║   ██║██║   ██║    ██╔══╝  ╚════██║██╔══██║██║     ██╔═══╝ ██╔══╝  ██║  ██║╚═╝");
            Console.WriteLine("      ██║   ╚██████╔╝╚██████╔╝    ███████╗███████║██║  ██║╚██████╗██║     ███████╗██████╔╝██╗");
            Console.WriteLine("      ╚═╝    ╚═════╝  ╚═════╝     ╚══════╝╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝     ╚══════╝╚═════╝ ╚═╝");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void End()
        {
            Console.WriteLine("");
            Console.WriteLine("Press M to return to the menu, or ESC to exit.");

            Program program = new Program();

            switch(Console.ReadKey(true).Key)
            {
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
                availableDirection();
                break;  
            }
        }
        public void Map()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");
            Console.WriteLine("                                      []  <--Exit");
            Console.WriteLine("                              ████    ██"); //9
            Console.WriteLine("                              ████    ██");
            Console.WriteLine("                                ██    ██"); //7
            Console.WriteLine("                    ██████████████    ██");
            Console.WriteLine("                          ████████  ████"); //5
            Console.WriteLine("                          ██████████████");
            Console.WriteLine("                          ████████  ████"); //3
            Console.WriteLine("                    ████      ██████    ");
            Console.WriteLine("  You are here-->   ><██████████████    "); //1
            Console.WriteLine("                    ████      ██████    ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}