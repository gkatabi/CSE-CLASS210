
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        FirstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        LastName = Console.ReadLine();
        Console.WriteLine($"    "
    {




















        Try to restructure the logic so it does exactly what you want.

Random r = new Random();

int val = r.Next(1, 100);
int guess = 0;
bool correct = false;

Console.WriteLine("I'm thinking of a number between 1 and 100.");

while (!correct)
{
    Console.Write("Guess: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("That's not a number.");
        continue;
    }
<<<<<<< HEAD
}

=======

    if (guess < val)
    {
        Console.WriteLine("No, the number I'm thinking is higher than that number.");
    }
    else if (guess > val)
    {
        Console.WriteLine("No, the number I'm thinking is lower than that number.");
    }
    else
    {
        correct = true;
        Console.WriteLine("You guessed right!");
    }
    }
}
>>>>>>> 29764bf4e13b331fe6a1e5174b23b97fca2a3492
