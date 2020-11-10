using System;
using System.Collections.Generic;
using System.Linq;

namespace MixTape
{
    public class Puzzles
    {
        public List<string[]> puzzles = new List<string[]>()
        {
            new string[] {"My Little Pony", "Television Show", "3"},
            new string[] {"Alex Karras in Webster", "Actor & Show", "3"},
            new string[] {"Don Quixote", "Book", "4"},
            new string[] {"Lord of the Rings", "Book", "3"},
            new string[] {"Harry Potter and the Sorcerer's Stone", "Book", "3"},
            new string[] {"Alice's Adventures in Wonderland", "Book", "3"},
            new string[] {"The Lion, the Witch, and the Wardrobe", "Book", "3"},
            new string[] {"The Lion King", "Movie", "3"},
            new string[] {"Jurassic World", "Movie", "3"},
            new string[] {"Black Panther", "Movie", "3"},
            new string[] {"They Might Be Giants", "Band", "3"},
            new string[] {"Paul and Storm", "Band", "4"},
            new string[] {"Family Feud", "Gameshow", "3"},
            new string[] {"Wheel of Fortune", "Gameshow", "3"},
            new string[] {"The Price is Right", "Gameshow", "3"},
            new string[] {"Jeopardy", "Gameshow", "3"},
            new string[] {"Bite the bullet", "Idiom", "3"},
            new string[] {"Break a leg", "Idiom", "3"},
            new string[] {"A dime a dozen", "Idiom", "3"},
            new string[] {"Beat around the bush", "Idiom", "3"},
            new string[] {"Cutting corners", "Idiom", "3"},
            new string[] {"Hit the sack", "Idiom", "3"},
            new string[] {"That's the last straw", "Idiom", "3"},
            new string[] {"We'll cross that bridge when we come to it", "Idiom", "3"},
            new string[] {"Under the weather", "Idiom", "3"},
            new string[] {"Star Trek", "Television Show", "3"},
            new string[] {"Firefly", "Television Show", "4"},
            new string[] {"Dr. Horrible's Sing-Along Blog", "Movie", "3"},
            new string[] {"Office Space", "Movie", "3"}
        };

        public int PuzzleCount() {return puzzles.Count;}

        public int GetRandomPuzzleNumber()
        {
            Random rnd = new Random();
            return rnd.Next(PuzzleCount());
        }
    }
}
