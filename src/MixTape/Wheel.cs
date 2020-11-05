using System;
using System.Collections.Generic;

namespace MixTape
{
      
    class Wheel
    {
        
        List<char> guessed = new List<char>();
        List<string> puzzleList = new List<string>();
        //string puzzle = "Alex Karras in Webster".ToUpper();
        string puzzle = "My Little Pony".ToUpper();
        //string category = "Actor & Show";
        string category = "Television Show";
        int guesses = 4;
        string alertMessage = null;
        bool spentGuess = false;

        public void Title()
        {
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

        public void Start()
        {
            Console.Clear();
            Title();
            Console.WriteLine(PuzzleDisplay());
            Console.WriteLine($" {category}");
            Console.WriteLine("");
            Console.WriteLine($"You have {guesses} guess(es) remaining.");
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
            
            if (spentGuess == true) {guesses--;}

            
            Start();
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

