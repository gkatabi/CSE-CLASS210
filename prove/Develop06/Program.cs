using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //goals sector
        List<string>goals;
        goals = new List<string>();
        goals.Add("1. Care or own a family");
        goals.Add("2. Serve church callings");
        goals.Add("3. Work to earn");
        goals.Add("4. Study scriptures ");
        goals.Add("5. Quit");
        //goals sector 
        Console.WriteLine("It's an eternal quest game application.\nWe choose and pursue any of the following goals:\n1. Care or own a family\n2. Serve church callings\n3. Work to earn\n4. Study scriptures\n5. Quit");
        Console.Write("Which number refers to your goal? ");
        string goals = Console.ReadLine();
        int goal = Convert.ToInt32(Console.ReadLine());
        goal = 5;
        while (goal < 5) ;
        goal++;
        Console.WriteLine(goal + "goal");




        //                    Goal goal = new Goal();



    }
}
//Condition user's choices
//Call for inheritance method
//if (goal>3;for goal;while
//{
//   Console.Loveme();
//} 

//        Intentions intentions = new intentions(oftime



