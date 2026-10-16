
using System.ComponentModel.Design;

Console.WriteLine("-------------------------------------");
Console.WriteLine(" Welcome to the Number Guessing Game!");
Console.WriteLine("-------------------------------------");


Console.WriteLine(" Guess a number between 1 and 100");

Random random = new Random();
int numberToGuess = random.Next(1, 101);


Console.WriteLine("Enter your guess: ");
int tipp = Convert.ToInt32(Console.ReadLine());

while (tipp != numberToGuess)
{
    if (tipp > numberToGuess)
    {
        Console.WriteLine("Go lower");
    }
    else if (tipp < numberToGuess)
    {
        Console.WriteLine("Go higher!");
    }

    Console.WriteLine("Enter your guess: ");
    tipp = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Richtig!");













