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
            Console.WriteLine(Problem1.GetProblemInfo());
            Console.WriteLine("1.Stress\n2 Anxiety");
            int chosen = Console.Write("Under which number does your problem fall?");
            Console.ReadKey();
            Thread.sleep(1000);
            if int Chosen =" 1";
                Console.WriteLine(Problem1.GetProblemInfo());
                Console.WriteLine ("Choose from these below");
                string number = Console.Write("1. I forget things that I plan\2. I am too busy to do it\3. Iam afraid it will take long");
                string number =  (Console.ReadKey());
                Console.WriteLine($"{number}");
            if int chosen = "2";
                Thread.sleep(1000);
                Comsole.WriteLine("5. Fear\n6. Stranded");
                string <list> these = Console.Writerite("choice is:  ");
                Console.ReadLine();
                 
                
            Problem problem1 = new Problem();
            Problem1.SetAnxiety = ("forgetting " );
            Problem2.SetStress =( " busy ");
            Console.WriteLine(Problem1.GetProblemInfo());

            Solution solution1 = new Solution();
            Solution1.SetActivity = ("breath");
            Soolution2.SetTime = ("Seconds");
            Console.WriteLine(Solutiob1.GetSolutionInfo());
        }
    }
}



