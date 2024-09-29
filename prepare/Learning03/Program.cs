using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The journal reminder app");
        DateTime now = DateTime.Now;
        Console.WriteLine(now);
        Console.ReadLine();
        Console.WriteLine("This reminder for: \r\nI1.waking up \r\nI2.Important event \nI3.I have finished \r\nI4.It's recorded \r\nI5.Q");        
        Console.Write("Chose a number for  this time's reminder: ")
        int numberChozen = int.perse(Console.ReadLine());
      
    }
}
