using System;

namespace Documents_GitHub

{

    class program

    {

 

   

        static void main(string[]args)

        {

           

            EternalGoals EternalGoals1 = new EternalGoals();

            EternalGoal1.SetGoal("1.Read scriptures");

            EternalGoal1.SetAward("100");

            Console.ReadLine(EternalGoals1.GetEternalGoalInfo());

 

           

            ServeACalling EternalGoals2 = new ServeACalling();

            EternalGoal2.SetGoal("Every month");

            EternalGoal2.SetAward("60");

            Console.ReadLine(EternalGoals2.GetEternalGoalsInfo());

 

            AttendChurch EternalGoals3 = new AttendChurch();

            EternalGoal3.SetGoal("Eat sacrament");

            EternalGoal3.SetAward("10");

            Console.ReadLine(EternalGoals3.GetEternalGoalsInfo());

 

            WorkHard EternalGoals4 = new WorkHard();

            EternalGoal4.SetGoal("Become self reliant");

            EternalGoal4.SetAward("50");

            Console.ReadLine(EternalGoals4.GetEternalGoalsInfo());

 

           

            Console.WriteLine(These are eternal goals to get you closer to Christ.\n1. Have a set goal\n2. Serve a calling\n3. Attend Church\n4. Work hard);

            Console.Write("Write the number related to a goal similar to your goals"  );

            int number = int.parse (Console.ReadLine());

            string a = "1";

            string b = "2";

            string c = "3";

            string d = "4";

            bool 5 = false;

            while (number !5)

            {

           

                string number a = Console.WriteLine("Have a set goal ");

                string number b = Console.WriteLine("Serve a calling");

                string number c = Console.WriteLine("Attend church ");

                string number d = Console.WriteLine("Work hard ");

                Console.WriteLine($"number");

 

                if (number > 0)

                {

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





 
