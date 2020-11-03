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

        public void thisisatest()
        {


            switch (xLocation)
            {
                case 0:
                switch (yLocation)
                {
                    //0,0
                    case 0:
                    returnCoords();
                    Console.WriteLine("You are in the Southwest corner of a room.");
                    break;


                    default:
                    Console.WriteLine("I am Error");
                    break;
                }
                break;
                default:
                returnCoords();
                Console.WriteLine("I am Error");
                break;
            }
        }

        public void returnCoords()
        {
            Console.WriteLine($"Coordinates: ({xLocation}, {yLocation})");
        }

        public void Move()
        {
            MazeTitle();
            returnCoords();
            availableDirection();




            Console.WriteLine($"Available Direction(s):");
            if (north) {Console.ForegroundColor = ConsoleColor.Green;}
            Console.WriteLine($"      North");
            Console.ForegroundColor = ConsoleColor.Gray;

            if (west) {Console.ForegroundColor = ConsoleColor.Green;}
            Console.Write($" West");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($"   +");

            if (east) {Console.ForegroundColor = ConsoleColor.Green;}
            Console.WriteLine($"   East");
            Console.ForegroundColor = ConsoleColor.Gray;

            if (south) {Console.ForegroundColor = ConsoleColor.Green;}
            Console.WriteLine($"      South");
            Console.ForegroundColor = ConsoleColor.Gray;

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
           
           if (xLocation == 0 && yLocation == 0) {north = true; east = true;}
           if (xLocation == 0 && yLocation == 1) {north = true; south = true; east = true;}
           if (xLocation == 0 && yLocation == 2) {south = true; east = true;}
           if (xLocation == 0 && yLocation == 6) {east = true;}

           if (xLocation == 1 && yLocation == 0) {north = true; west = true;}
           if (xLocation == 1 && yLocation == 1) {north = true; south = true; east = true; west = true;}
           if (xLocation == 1 && yLocation == 2) {south = true; west = true;}
           if (xLocation == 1 && yLocation == 6) {east = true; west = true;}
           
           if (xLocation == 2 && yLocation == 1) {east = true; west = true;}
           if (xLocation == 2 && yLocation == 6) {east = true; west = true;}

           if (xLocation == 3 && yLocation == 1) {east = true; west = true;}
           if (xLocation == 3 && yLocation == 3) {north = true; east = true;}
           if (xLocation == 3 && yLocation == 4) {north = true; south = true; east = true;}
           if (xLocation == 3 && yLocation == 5) {south = true; east = true;}
           if (xLocation == 3 && yLocation == 6) {east = true; west = true;}

           if (xLocation == 4 && yLocation == 1) {east = true; west = true;}
           if (xLocation == 4 && yLocation == 3) {north = true; east = true; west = true;}
           if (xLocation == 4 && yLocation == 4) {north = true; south = true; east = true; west = true;}
           if (xLocation == 4 && yLocation == 5) {north = true; south = true; east = true; west = true;}
           if (xLocation == 4 && yLocation == 6) {south = true; east = true; west = true;}

           if (xLocation == 5 && yLocation == 0) {north = true; east = true;}
           if (xLocation == 5 && yLocation == 1) {north = true; south = true; east = true; west = true;}
           if (xLocation == 5 && yLocation == 2) {south = true; east = true;}
           if (xLocation == 5 && yLocation == 3) {north = true; west = true;}
           if (xLocation == 5 && yLocation == 4) {north = true; south = true; west = true;}
           if (xLocation == 5 && yLocation == 5) {south = true; west = true;}
           if (xLocation == 5 && yLocation == 6) {east = true; west = true;}
           if (xLocation == 5 && yLocation == 8) {north = true; east = true;}
           if (xLocation == 5 && yLocation == 9) {south = true; east = true;}

           if (xLocation == 6 && yLocation == 0) {north = true; east = true; west = true;}
           if (xLocation == 6 && yLocation == 1) {north = true; south = true; east = true; west = true;}
           if (xLocation == 6 && yLocation == 2) {north = true; south = true; east = true; west = true;}
           if (xLocation == 6 && yLocation == 3) {north = true; south = true;}
           if (xLocation == 6 && yLocation == 4) {north = true; south = true; east = true;}
           if (xLocation == 6 && yLocation == 5) {north = true; south = true;}
           if (xLocation == 6 && yLocation == 6) {north = true; south = true; west = true;}
           if (xLocation == 6 && yLocation == 7) {north = true; south = true;}
           if (xLocation == 6 && yLocation == 8) {north = true; south = true; west = true;}
           if (xLocation == 6 && yLocation == 9) {south = true; west = true;}

           if (xLocation == 7 && yLocation == 0) {north = true; west = true;}
           if (xLocation == 7 && yLocation == 1) {north = true; south = true; west = true;}
           if (xLocation == 7 && yLocation == 2) {south = true; west = true;}
           if (xLocation == 7 && yLocation == 4) {east = true; west = true;}

           if (xLocation == 8 && yLocation == 3) {north = true; east = true;}
           if (xLocation == 8 && yLocation == 4) {north = true; south = true; east = true; west = true;}
           if (xLocation == 8 && yLocation == 5) {south = true; east = true;}

           if (xLocation == 9 && yLocation == 3) {north = true; west = true;}
           if (xLocation == 9 && yLocation == 4) {north = true; south = true; west = true;}
           if (xLocation == 9 && yLocation == 5) {north = true; south = true; west = true;}
           if (xLocation == 9 && yLocation == 6) {north = true; south = true;}
           if (xLocation == 9 && yLocation == 7) {north = true; south = true;}
           if (xLocation == 9 && yLocation == 8) {north = true; south = true;}
           if (xLocation == 9 && yLocation == 9) {north = true; south = true;}

           if (yLocation == 10)
            {
                MazeTitle();
                YouWin();
            }

        }

        public void YouWin()
        {
            Console.WriteLine("");
            Console.WriteLine("   ██╗   ██╗ ██████╗ ██╗   ██╗    ███████╗███████╗ █████╗  ██████╗██████╗ ███████╗██████╗ ██╗");
            Console.WriteLine("   ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██╔════╝██╔════╝██╔══██╗██╔════╝██╔══██╗██╔════╝██╔══██╗██║");
            Console.WriteLine("    ╚████╔╝ ██║   ██║██║   ██║    █████╗  ███████╗███████║██║     ██████╔╝█████╗  ██║  ██║██║");
            Console.WriteLine("     ╚██╔╝  ██║   ██║██║   ██║    ██╔══╝  ╚════██║██╔══██║██║     ██╔═══╝ ██╔══╝  ██║  ██║╚═╝");
            Console.WriteLine("      ██║   ╚██████╔╝╚██████╔╝    ███████╗███████║██║  ██║╚██████╗██║     ███████╗██████╔╝██╗");
            Console.WriteLine("      ╚═╝    ╚═════╝  ╚═════╝     ╚══════╝╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝     ╚══════╝╚═════╝ ╚═╝");
            Console.WriteLine("");
        }
    }
}