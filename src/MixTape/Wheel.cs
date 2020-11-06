using System;
using System.Collections.Generic;


namespace MixTape
{
      
    class Wheel : Puzzles
    {

        Random rnd = new Random();   
        List<char> guessed = new List<char>();
        List<string> puzzleList = new List<string>();
        //int pzNum = GetRandomPuzzleNumber();
        string puzzle = "My Little Pony".ToUpper(); //puzzles[rnd.Next(puzzles.Count)][0];
        string category = "Television Show";
        int guesses = 3;
        string alertMessage = null;
        bool spentGuess = false;
        bool gameWon = false;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        List<string> alphabetList = new List<string>();

      /*  public int GetRandomPuzzleNumber()
        {
            Random rnd = new Random();
            Puzzles puzzles = new Puzzles();
            return rnd.Next(puzzles.Count);
        }

        public string GetRandomPuzzle(string type)
        {
            int pzNum = rnd.Next(puzzles.Count);
            switch (type)
                {
                    case "name":
                    return puzzles[pzNum][0].ToUpper();
                    case "category":
                    return puzzles[pzNum][1];
                    case "guesses":
                    return puzzles[pzNum][2];
                    default:
                    return null;
                }
        }*/

        public void Title()
        {
            
            Console.WriteLine(puzzles[rnd.Next(puzzles.Count)][0]);
            Console.WriteLine(puzzles.Count);
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
            if (gameWon) {Console.WriteLine("");Console.WriteLine("YOU WIN!!!"); End();};
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

    }


}

