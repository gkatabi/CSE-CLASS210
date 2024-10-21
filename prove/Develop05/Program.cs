using System;
namespace Mindfull
{
    public class Problem
    {
        static void Main(string[]args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("On :{0}",dateTime);
            Console.ReadKey();
            
            Problem problem1 = new Problem();
            Problem1.SetAnxiety = ("forgetting " );
            Problem2.SetStress =( " busy ");

            Solution solution1 = new Solution();
            Solution1.SetActivity = ("breath");
            Soolution2.SetTime = ("Seconds");
            
            Console.WriteLine("1.Stress\n2 Anxiety");
            int chosen = Console.Write("Under which number does your problem fall?");
            Console.ReadKey();
            Thread.sleep(1000);
            if int Chosen =" 1";
                Console.WriteLine(Problem1.GetProblemInfo());
                Console.WriteLine ("Choose from these below");
                string number = Console.Write("1. I forget things that I plan\2. I am too busy to do it\3. Iam afraid it will take long");
                string number =  (Console.ReadKey());
                Console.WriteLine($"TThe {number} situation has a solution to it");
            if int chosen = "2";
                Thread.sleep(1000);
                Console.WriteLine(Problem2.GetProblemInfo());
                Comsole.WriteLine("5. Fear\n6. Stranded");
                string these = Console.Writerite("choice is:  ");
                Console.ReadLine();
                Console.WriteLine($"The {these} situation has a solution");
                Console.WriteLine(Solutiob1.GetSolutionInfo());
                Console.Writeine($"{Solution1.SetActivity} in for 10 {Solution2.SetTime}");
                    
                
     //       Problem problem1 = new Problem();
     //       Problem1.SetAnxiety = ("forgetting " );
     //       Problem2.SetStress =( " busy ");
     //       Console.WriteLine(Problem1.GetProblemInfo());

    //        Solution solution1 = new Solution();
   //         Solution1.SetActivity = ("breath");
  //          Soolution2.SetTime = ("Seconds");
  //          Console.WriteLine(Solutiob1.GetSolutionInfo());
        }
    }
}



