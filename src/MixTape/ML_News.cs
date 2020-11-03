using System;


namespace MixTape
{
    class ML_News : MadLibs
    {

        public void ML()
        {
            Title("Weird News");

            Console.Write("Enter a noun (1/23): ");
            string noun_1 = Console.ReadLine();
            Console.Write("Enter a wacky State (2/23): ");
            string state_1 = Console.ReadLine();
            Console.Write("Enter a verb (past tense) (3/23): ");
            string verbPt_1 = Console.ReadLine();
            Console.Write("Enter a noun (4/23): ");
            string noun_2 = Console.ReadLine();
            Console.Write("Enter a proper name (5/23): ");
            string properName_1 = Console.ReadLine();
            Console.Write("Enter a verb ending in \"ing\" (6/23): ");
            string verbIng_1 = Console.ReadLine();
            Console.Write("Enter a noun (7/23): ");
            string noun_3 = Console.ReadLine();
            Console.Write("Enter a verb (8/23): ");
            string verb_1 = Console.ReadLine();
            Console.Write("Enter a noun (9/23): ");
            string noun_4 = Console.ReadLine();
            Console.Write("Enter a part of the body (10/23): ");
            string bodyPart_1 = Console.ReadLine();
            
            Console.Write("Enter a adjective (11/23): ");
            string adjective_1= Console.ReadLine();
            Console.Write("Enter a relative (12/23): ");
            string relative_1 = Console.ReadLine();
            
            Console.Write("Enter an activity (13/23): ");
            string activity_1 = Console.ReadLine();
            Console.Write("Enter a chain restaurant (14/23): ");
            string restaurant_1 = Console.ReadLine();
            Console.Write("Enter a verb (past tense) (15/23): ");
            string verbPt_2 = Console.ReadLine();
            
            Console.Write("Enter an month (16/23): ");
            string month_1 = Console.ReadLine();
            Console.Write("Enter a verb ending in \"ing\" (17/23): ");
            string verbIng_2 = Console.ReadLine();
            Console.Write("Enter a noun (18/23): ");
            string noun_5 = Console.ReadLine();
            Console.Write("Enter a verb (past tense) (19/23): ");
            string verbPt_3 = Console.ReadLine();
            Console.Write("Enter an adjective (20/23): ");
            string adjective_2 = Console.ReadLine();

            Console.Write("Enter a verb ending in \"ing\" (21/23): ");
            string verbIng_3 = Console.ReadLine();
            Console.Write("Enter a noun (22/23): ");
            string noun_6 = Console.ReadLine();
            Console.Write("Enter a plural noun (23/23): ");
            string pluralNoun_1 = Console.ReadLine();



            Title("Weird News");
            Console.WriteLine($"A {noun_1} in {state_1} was arrested this morning after they {verbPt_1}");
            Console.WriteLine($"in front of a {noun_2}. {properName_1} had a history of {verbIng_1}, but");
            Console.WriteLine($"no one, not even his {noun_3}, ever imagined he'd {verb_1} with a {noun_3}");
            Console.WriteLine($"stuck in his {bodyPart_1}.");
            Console.WriteLine($"");
            Console.WriteLine($"\"I always thought he was {adjective_1}, but I never thought he'd do something");
            Console.WriteLine($"like this. Even his {relative_1} was surprised.\"");
            Console.WriteLine($"");
            Console.WriteLine($"After a brief {activity_1}, cops followed him to a {restaurant_1}, wher he reportedly");
            Console.WriteLine($"{verbPt_2} in the fry machine.");
            Console.WriteLine($"");
            Console.WriteLine($"In {month_1}, a woman was charged with a similar crime. Rather than");
            Console.WriteLine($"{verbIng_2} with a {noun_5}, she {verbPt_3} with a {adjective_2} dog.");
            Console.WriteLine($"");
            Console.WriteLine($"Either way, we imagine that after witnessing him {verbIng_3} with a {noun_6} there");
            Console.WriteLine($"are probably a whole lot of {pluralNoun_1} that are going to need some therapy.");

            End();
        }

        
    }
}
