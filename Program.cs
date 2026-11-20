

using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Willkommen zu meinem Zahlen Guesser");
        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Ich habe mir eine Zahl zwischen 1 und 100 ausgedacht, finde sie heraus");


        Random random = new Random();
        int numberToGuess = random.Next(1, 101);


        Console.WriteLine(" Was ist dein Guess?");
        string eingabe = Console.ReadLine();
        int guess = Convert.ToInt32(eingabe);

        while (guess != numberToGuess)
        {
            if (guess < numberToGuess)
            {
                Console.WriteLine("Geh höher");
            }

            else if (guess > numberToGuess)
            {

                Console.WriteLine(" Geh tiefer");
            }

            Console.WriteLine(" Gib einen neuen Guess ein");
            eingabe = Console.ReadLine();
            guess = Convert.ToInt32(eingabe);
        }

        Console.WriteLine("Richhtigggg du hasst es geschaft");
    }
}
