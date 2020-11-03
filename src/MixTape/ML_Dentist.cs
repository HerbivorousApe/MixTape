using System;


namespace MixTape
{
    class ML_Dentist : MadLibs
    {

        public void ML()
        {
            Title("A Visit to the Dentist");

            Console.Write("Enter a plural noun (1/18): ");
            string pluralNoun_1 = Console.ReadLine();
            Console.Write("Enter the last name of a person in the room (2/18): ");
            string lastName_1 = Console.ReadLine();
            Console.Write("Enter an adjective (3/18): ");
            string adjective_1 = Console.ReadLine();
            Console.Write("Enter a noun (4/18): ");
            string noun_1 = Console.ReadLine();
            Console.Write("Enter a noun (5/18): ");
            string noun_2 = Console.ReadLine();
            Console.Write("Enter a part of the body (6/18): ");
            string bodyPart_1 = Console.ReadLine();
            Console.Write("Enter a part of the body (7/18): ");
            string bodyPart_2 = Console.ReadLine();
            Console.Write("plural noun (8/18): ");
            string pluralNoun_2 = Console.ReadLine();
            Console.Write("Enter a noun (9/18): ");
            string noun_3 = Console.ReadLine();
            Console.Write("Enter a noun (10/18): ");
            string noun_4 = Console.ReadLine();
            
            Console.Write("Enter an exclaimation (11/18): ");
            string exclaimation_1= Console.ReadLine();
            Console.Write("Enter a noun (12/18): ");
            string noun_5 = Console.ReadLine();
            
            Console.Write("Enter a noun (13/18): ");
            string noun_6 = Console.ReadLine();
            Console.Write("Enter a noun (14/18): ");
            string noun_7 = Console.ReadLine();
            Console.Write("Enter a verb (15/18): ");
            string verb_1 = Console.ReadLine();
            
            Console.Write("Enter a noun (16/18): ");
            string noun_8 = Console.ReadLine();
            Console.Write("Enter an adjective (17/18): ");
            string adjective_2 = Console.ReadLine();
            Console.Write("Enter a noun (18/18): ");
            string noun_9 = Console.ReadLine();

            Title("A Visit to the Dentist");
            Console.WriteLine($"A one-act play to be performed by two {pluralNoun_1} in this room.");
            Console.WriteLine($"");
            Console.WriteLine($"PATIENT: Thank you so very much for seeing me, Doctor");
            Console.WriteLine($"{lastName_1} on such {adjective_1} notice.");
            Console.WriteLine($"DENTIST: What is your problem young {noun_1}?");
            Console.WriteLine($"PATIENT: I have a pain in my upper {noun_2}, which");
            Console.WriteLine($"is giving me a severe {bodyPart_1} ache.");
            Console.WriteLine($"DENTIST: Let me take a look. Open your {bodyPart_2} wide.");
            Console.WriteLine($"Good. Now I'm going to tap your {pluralNoun_2} with my {noun_3}.");
            Console.WriteLine($"PATIENT: Should you give me a/an {noun_4} killer?");
            Console.WriteLine($"DENTIST: It's not necessary yet. {exclaimation_1}! I think I see");
            Console.WriteLine($"a/an {noun_5} in your upper {noun_6}.");
            Console.WriteLine($"PATIENT: Are you going to pull my {noun_7} out?");
            Console.WriteLine($"DENTIST: No. I'm going to {verb_1} your tooth and put in");
            Console.WriteLine($"a temporary {noun_8}.");
            Console.WriteLine($"PATIENT: When do I come back for the {adjective_2} filling?");
            Console.WriteLine($"DENTIST: A day after I cash your {noun_9}.");

            End();
        }

        
    }
}
