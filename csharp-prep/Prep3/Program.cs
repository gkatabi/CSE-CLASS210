using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the magic number");

        string Number = Console.Write("What is the number? ");

        int Number = Convert.ToInt32(Console.ReadLine());


        int Number = Console.ReadLine();
        Console.WriteLine(Number);
        Number = 5



        while (Number != 5)
        {

            Console.WriteLine("Wrong guess");

            Console.WriteLine("Guess again");
            if (Number > 5)
            {
                Console.WriteLine("That is high. Guess lower");

            }
            if (Number < 5) 
            {
                Console.WriteLine("That is lower than it");
            else if (Number = 5)
            {
                Console.WriteLine("Congraturations");
            

            }

         Number++
        if (Number = 5)
        {
            Console.WriteLine("That is the number");
        }
        
    }
}