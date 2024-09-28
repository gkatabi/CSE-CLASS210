using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The journal reminder app");
        DateTime now = DateTime.Now;
        Console.WriteLine(now);
        Console.ReadLine();
        Console.WriteLine("This reminder for: 1)waking up \n2)Important event \nI have finished n\It's records");        
        Console.Write("Chose a number for  this time's reminder: ")
        int numberChozen = int.perse(Console.ReadLine());

        

      
    }
}