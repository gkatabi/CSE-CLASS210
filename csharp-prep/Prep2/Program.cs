using System;

class Program
{
    static void Main(string[] args)
    {
        /*A >= 90
          B >= 80
          C >= 70
          D >= 60
          F < 60*/
        Console.WriteLine("What was your percentage score?: ");
        Console.Write("Enter your percentage score: ")
        float percentageScore = float.perse(Console.readLine()); 
        float percentageScore = float.perse(percentageScore);
        if (percentageScore >= 90)
        {
            Console.ReadLine($"You Scored",{percentageScore}F);
            Console.WriteLine("You passed in: A");
        if (percentageScore >= 80);
            Console.WriteLine("You passed in: B")
        if (percentageScore >= 70);
            Console.WriteLine("You passed in: C");
        if (percentageScore >= 60);
            Console.WriteLine("You survived with a grade: D");
        if (percentageScore < 60);
            Console.WriteLine("You failed and pocketed an: F");
  
        }
    }
}