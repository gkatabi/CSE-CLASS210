using System;
using System.Collections.Generic;
namespace Documents_GitHub

{

    class program

    {

 

   

        static void main(string[]args)

        {

           

            EternalGoals EternalGoals1 = new EternalGoals();

            EternalGoals1.SetGoal("1.Read scriptures");

            EternalGoals1.SetAward("100");

            Console.ReadLine(EternalGoals1.GetEternalGoalsInfo());

 

           

            ServeACalling EternalGoals2 = new ServeACalling();

            EternalGoals2.SetGoal("Every month");

            EternalGoals2.SetAward("60");

            Console.ReadLine(EternalGoals2.GetEternalGoalsInfo());

 

            AttendChurch EternalGoals3 = new AttendChurch();

            EternalGoals3.SetGoal("Eat sacrament");

            EternalGoals3.SetAward("10");

            Console.ReadLine(EternalGoals3.GetEternalGoalsInfo());

 

            WorkHard EternalGoals4 = new WorkHard();

            EternalGoals4.SetGoal("Become self reliant");

            EternalGoal4.SetAward("50");

            Console.ReadLine(EternalGoals4.GetEternalGoalsInfo());

 

           

            Console.WriteLine(These are eternal goals to get you closer );

            Console.Write("Write the one related to a goal"  );
            List<string> DoneList = new List<string>();
            DoneList.Add("Read scriptures");
            DoneList.Add("Serve a calling");
            DoneList.Add("Attend church");
            DoneList.Add("Work hard");
            DoneList.Add("Quit every thing ");
            foreach (var DoneValue in Enum.GetValues<DoneEnum>())
{
  obj.DoneType = (DoneEnum)DoneValue;
  

            Number<int, string> Number = new Number<int, string>() {
    { 1, "Reading scriptures" }, { 2, "Serving a calling" }, { 3, "Attend church" }, {4, "Work hard"}, {5, "Quit every thing"} 
};

foreach (KeyValuePair<int, string> pair in dictionary)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
           
}
            Console.Write("Write a number related to a goal you have pursued");
            int number = int .parse(Console.ReadLine);

            bool 5 = false;
            while (number !5)
            {   
                List<string> done = new List<string>();
                if (number = 1)
                {
                    done.Add($"{ }");
                }
                
                if (number = 2)
                {
                    done.Add($"{ }");
                }

                if (number = 3)
                {
                    done.Add($"{ }");
                }

                if (number = 4)
                {
                    done.Add($"{ }");
                }

                if (number = 5)
                {
                    done.Add($"{ }");
                }

             
                done.Add($"{ }");
                Console.ReadLine();
            

            

                    // Create a box or an empty list  where to top up the goals chosen

                   

                    Console.Write("Write another number related to a goal similar to your goals"  );

                    int number = int.parse (Console.ReadLine());

                    string a = "1";

                    string b = "2";

                    string c = "3";

                    string d = "4";

 

            }

 

        }

       

    }

}





 
