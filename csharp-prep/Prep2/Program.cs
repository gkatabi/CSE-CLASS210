using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your  score: ");
            
        int score = Convert.ToInt32(Console.ReadLine());
        
        if (score >= 90)
        {
            Console.WriteLine("You passed");

            if (score > 95)
            {
                Console.WriteLine(score + "A" , "+");
            }
            else if (score < 95)
            {
                Console.WriteLine(score +"A" , "-");
            }
        }

        if (score >= 80)
        {
            Console.WriteLine("You passed");

            if (score > 85)
            {
                Console.WriteLine(score + "B" , "+");
            }
            else if (score < 85)
            {
                Console.WriteLine(score +"-" , "B");
            }
        }

        if (score >= 70)
        {
            Console.WriteLine("You passed");

            if (score > 75)
            {
                Console.WriteLine(score + "C" , "+");
            }
            else if (score < 75)
            {
                Console.WriteLine(score +"-" , "C");
            }
        }

        if (score >= 60)
        {
            Console.WriteLine("You passed");

            if (score > 65)
            {
                Console.WriteLine(score + "D" , "+");
            }
            else if (score < 65)
            {
                Console.WriteLine(score +"-" , "D");
            }
        }

        if (score >= 50)
        {
            Console.WriteLine("You passed");

            if (score > 55)
            {
                Console.WriteLine(score + "E" , "+");
            }
            else if (score < 55)
            {
                Console.WriteLine(score +"-" , "E");
            }
        }
        
        if (score >= 40)
        {
            Console.WriteLine("You failed");

            if (score > 45)
            {
                Console.WriteLine(score + "F" , "+");
            }
            else if (score < 45);
            {
                Console.WriteLine(score + "F" , "-");
            }
        }
    }
}

