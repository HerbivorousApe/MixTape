using System;


namespace MixTape
{
    class ML_Vacation : MadLibs
    {

        public void ML()
        {
            Title("Vacations");

            Console.Write("Enter an adjective (1/19): ");
            string adjective_1 = Console.ReadLine();
            Console.Write("Enter an adjective (2/19): ");
            string adjective_2 = Console.ReadLine();
            Console.Write("Enter a noun (3/19): ");
            string noun_1 = Console.ReadLine();
            Console.Write("Enter a noun (4/19): ");
            string noun_2 = Console.ReadLine();
            Console.Write("Enter a plural noun (5/19): ");
            string pluralNoun_1 = Console.ReadLine();
            Console.Write("Enter a game (6/19): ");
            string game_1 = Console.ReadLine();
            Console.Write("Enter a plural noun (7/19): ");
            string pluralNoun_2 = Console.ReadLine();
            Console.Write("Enter a verb ending in \"ing\" (8/19): ");
            string verbIng_1 = Console.ReadLine();
            Console.Write("Enter a verb ending in \"ing\" (9/19): ");
            string verbIng_2 = Console.ReadLine();
            Console.Write("Enter a plural noun (10/19): ");
            string pluralNoun_3 = Console.ReadLine();
            Console.Write("Enter a verb ending in \"ing\" (11/19): ");
            string verbIng_3 = Console.ReadLine();
            Console.Write("Enter a noun (12/19): ");
            string noun_3= Console.ReadLine();
            Console.Write("Enter a plant (13/19): ");
            string plant_1 = Console.ReadLine();
            Console.Write("Enter a part of the body (14/19): ");
            string bodyPart_1 = Console.ReadLine();
            Console.Write("Enter a place (15/19): ");
            string place_1 = Console.ReadLine();
            Console.Write("Enter a verb ending in \"ing\" (16/19): ");
            string verbIng_4 = Console.ReadLine();
            Console.Write("Enter an adjective (17/19): ");
            string adjective_3 = Console.ReadLine();
            Console.Write("Enter a number (18/19): ");
            string number_1 = Console.ReadLine();
            Console.Write("Enter a plural noun (19/19): ");
            string pluralNoun_4 = Console.ReadLine();

            Title("Vacations");
            Console.WriteLine($"A vacation is when you take a trip to some {adjective_1} place");
            Console.WriteLine($"with your {adjective_2} family. Usually you go to some place");
            Console.WriteLine($"that is near a/an {noun_1} or up on a/an {noun_2}.");
            Console.WriteLine($"A good vacation place is one where you can ride {pluralNoun_1}");
            Console.WriteLine($"or play {game_1} or go foraging for {pluralNoun_2}. I like");
            Console.WriteLine($"to spend my time {verbIng_1} or {verbIng_2}.");
            Console.WriteLine($"When parents go on a vacation, they spend their time eating");
            Console.WriteLine($"three {pluralNoun_3} a day, and fathers, play golf, and mothers");
            Console.WriteLine($"sit around {verbIng_3}. Last summer, my little brother");
            Console.WriteLine($"fell in a/an {noun_3} and got poison {plant_1} all");
            Console.WriteLine($"over his {bodyPart_1}. My family is going to go to (the)");
            Console.WriteLine($"{place_1}, and I will practice {verbIng_4}. Parents");
            Console.WriteLine($"need vacations more than kids because parents are always very");
            Console.WriteLine($"{adjective_3} and because they have to work {number_1}");
            Console.WriteLine($"hours every day all year making enough {pluralNoun_4} to pay");
            Console.WriteLine($"for the vacation.");

            End();
        }

        
    }
}
