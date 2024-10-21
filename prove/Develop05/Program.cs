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
            Solution2.SetTime = ("Seconds");
            
            Console.WriteLine("1.Stress\n2 Anxiety");
            int chosen = Console.Write("Under which number does your problem fall?");
            Console.ReadKey();
            Thread.sleep(1000);
            if (Chosen =" 1")
            {
                Console.WriteLine(Problem1.GetProblemInfo());
                Console.WriteLine ("Choose from these below");
                Console.WriteLine("1. I forget things that I plan\2. I am too busy to do it\3. Iam afraid it will take long");
                Console.Write("Number: ");
                string number =  (Console.ReadKey());
                Console.WriteLine($"TThe {number} situation has a solution to it");
            }
            if (chosen = "2")
            {
                Thread.sleep(1000);
                Console.WriteLine(Problem2.GetProblemInfo());
                Comsole.WriteLine("5. Fear\n6. Stranded"); 
                Console.Writerite("choice is: ");
                int choice = Convert .ToInt32(Console.ReadLine());
                Console.WriteLine($"The" + Choice +"th situation has a solution");
                Console.WriteLine(Solutiob1.GetSolutionInfo());
                Console.Writeine($"{Solution1.SetActivity} in for 10 {Solution2.SetTime}");
            }
        }
    }
}



