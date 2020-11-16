using System;
using System.Collections.Generic;
using System.Drawing;

namespace MixTape
{
      
    class Wheel : Puzzles
    {
        List<char> guessed = new List<char>();
        List<string> puzzleList = new List<string>();
        
        string puzzle; 
        string category;
        int guesses;
        string alertMessage = null;
        bool spentGuess = false;
        bool gameWon = false;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        List<string> alphabetList = new List<string>();
        
        public void Title()
        {
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("██╗    ██╗██╗  ██╗███████╗███████╗██╗          ██████╗ ███████╗");
            Console.WriteLine("██║    ██║██║  ██║██╔════╝██╔════╝██║         ██╔═══██╗██╔════╝");
            Console.WriteLine("██║ █╗ ██║███████║█████╗  █████╗  ██║         ██║   ██║█████╗  ");
            Console.WriteLine("██║███╗██║██╔══██║██╔══╝  ██╔══╝  ██║         ██║   ██║██╔══╝  ");
            Console.WriteLine("╚███╔███╔╝██║  ██║███████╗███████╗███████╗    ╚██████╔╝██║     ");
            Console.WriteLine(" ╚══╝╚══╝ ╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝     ╚═════╝ ╚═╝     ");
            Console.WriteLine("");
            Console.WriteLine("███╗   ███╗██╗███████╗███████╗ ██████╗ ██████╗ ████████╗██╗   ██╗███╗   ██╗███████╗");
            Console.WriteLine("████╗ ████║██║██╔════╝██╔════╝██╔═══██╗██╔══██╗╚══██╔══╝██║   ██║████╗  ██║██╔════╝");
            Console.WriteLine("██╔████╔██║██║███████╗█████╗  ██║   ██║██████╔╝   ██║   ██║   ██║██╔██╗ ██║█████╗  ");
            Console.WriteLine("██║╚██╔╝██║██║╚════██║██╔══╝  ██║   ██║██╔══██╗   ██║   ██║   ██║██║╚██╗██║██╔══╝  ");
            Console.WriteLine("██║ ╚═╝ ██║██║███████║██║     ╚██████╔╝██║  ██║   ██║   ╚██████╔╝██║ ╚████║███████╗");
            Console.WriteLine("╚═╝     ╚═╝╚═╝╚══════╝╚═╝      ╚═════╝ ╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═══╝╚══════╝");
            Console.WriteLine("");
        }


        public void SessionSetup()
        {
            puzzleList.Clear();
            guessed.Clear();
            int puzNum = GetRandomPuzzleNumber();
            puzzle = puzzles[puzNum][0].ToUpper();
            category = puzzles[puzNum][1];
            guesses = Int32.Parse(puzzles[puzNum][2]);
            Start();
        }

        public void Start()
        {
            Console.Clear();
            Title();
            var puzzleDisplay = PuzzleDisplay();
            var alphabetDisplay = AlphabetDisplay();
            
            
            
            Console.Write($" {puzzleDisplay}");
            Console.WriteLine("                    Guessed Letters:");
            Console.Write($" {category}");
            Console.WriteLine($"                    {alphabetDisplay}");
            gameWon = GameWon();
            if (gameWon) 
            {
                Console.WriteLine("");
                YouWin();
                End();
            };
            Console.WriteLine("");
            Console.WriteLine($"You have {guesses} attempts remaining.");
            if (alertMessage != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine(alertMessage); alertMessage = null;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("");
            Console.Write("Enter your guess: ");
            var keyGuess = Console.ReadKey(true).Key;

            char guess = (char) keyGuess;

            bool validChar = LetterCheck(guess);
            
            if (!validChar) 
            {
                alertMessage = "Please enter a valid character.";
                Start();
            }

            bool alreadyGuessed = AlreadyGuessed(guess);

            if (alreadyGuessed)
            {
                alertMessage = "You already guessed that letter. Please try again";
                Start();
            }

            guessed.Add(guess);

            spentGuess = true;

            foreach (var item in puzzle)
            {
                if (guess == item) 
                {
                    spentGuess = false;
                }
            } 
            
            if (spentGuess == true) 
            {
                guesses--;
            }

            if (guesses < 0) {YouLose();}
            
            Start();
        }

        public void YouLose()
        {
            Console.Clear();
            Title();
            Console.WriteLine("");
            Console.WriteLine("You ran out of guesses.");
            Console.WriteLine("");
            Console.WriteLine($"The answer was \"{puzzle}\"");
            End();
        }

       public void End()
        {
            Console.WriteLine("");
            Console.WriteLine("Press M to return to the menu, P to play another random puzzle, or ESC to exit.");

            Program program = new Program();

            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.M:
                Console.WriteLine("Returning to Menu");
                program.Menu();
                break;
                case ConsoleKey.P:
                Console.WriteLine("Loading another puzzle");
                SessionSetup();
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
        public string PuzzleDisplay()
        {
            puzzleList.Clear();
            
            foreach (var item in puzzle)
            {
                bool flipped = false;
                if (LetterCheck(item))
                {
                    foreach (var guess in guessed)
                    {
                        if (item == guess) 
                        {
                            puzzleList.Add(item.ToString());
                            flipped = true;
                        }
                    }
                    if (!flipped) {puzzleList.Add("_");}      
                }
                else 
                {
                    puzzleList.Add(item.ToString());
                }
            }



            return string.Join("", puzzleList);
        }
        
        public string AlphabetDisplay()
        {
            alphabetList.Clear();
            
            foreach (var item in alphabet)
            {
                bool flipped = false;
                    foreach (var guess in guessed)
                    {
                        if (item == guess) 
                        {
                            alphabetList.Add(item.ToString());
                            flipped = true;
                        }
                    }
                    if (!flipped) {alphabetList.Add("_".ToString());}
            }
            return string.Join("", alphabetList);
        }

        public bool GameWon()
        {
            gameWon = true;
            foreach (var item in puzzleList)
            {
                if (item == "_") {gameWon = false;}
            }
            return gameWon;
        }

        public bool AlreadyGuessed(char guess)
        {
            foreach (var item in guessed)
            {
                if (guess == item) {return true;}
            }
            return false;
        }

        public bool LetterCheck(char guess)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(guess.ToString(), "^[a-zA-z]"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void YouWin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ██╗   ██╗ ██████╗ ██╗   ██╗    ██╗    ██╗██╗███╗   ██╗██╗");
            Console.WriteLine(" ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║    ██║██║████╗  ██║██║");
            Console.WriteLine("  ╚████╔╝ ██║   ██║██║   ██║    ██║ █╗ ██║██║██╔██╗ ██║██║");
            Console.WriteLine("   ╚██╔╝  ██║   ██║██║   ██║    ██║███╗██║██║██║╚██╗██║╚═╝");
            Console.WriteLine("    ██║   ╚██████╔╝╚██████╔╝    ╚███╔███╔╝██║██║ ╚████║██╗");
            Console.WriteLine("    ╚═╝    ╚═════╝  ╚═════╝      ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }


}

