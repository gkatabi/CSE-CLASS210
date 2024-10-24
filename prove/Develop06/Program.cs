using System;

namespace Documents_GitHub

{

    class Program

    {

   

   

        static void main(string[]args)

        {

           

            EternalGoals1 = new EternalGoal();

            EternalGoal1.SetGoal("Read scriptures");

            EternalGoal.SetAward("100");

            Console.WriteLine(EternalGoal1.GetEternalGoalInfo());

        }

        public string GetEternalGoalInfo();

        {

            return ($"{_goal} earned you {_award}");

        }

       

 

    }

}














/*using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //goals sector
        Console.WriteLine("It's an eternal quest game application.\nWe choose and pursue any of the following goals:\n1. Care or own a family\n2. Serve church callings\n3. Work to earn\n4. Study scriptures\n5. Quit");
        List<string>goals;
        goals = new List<string>();
        goals.Add("1. Care or own a family");
        goals.Add("2. Serve church callings");
        goals.Add("3. Work to earn");
        goals.Add("4. Study scriptures ");
        goals.Add("5. Quit");
        foreach (string goal in goals);
        {
        Console.WriteLine(goal);
        } 
        Console.Write("Which number refers to your choice? ");
        string choice = Console.ReadLine();

        int choice = Convert.ToInt32(Console.ReadLine());
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
*/



