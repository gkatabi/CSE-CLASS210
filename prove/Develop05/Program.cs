using System;
//namespace storage_emulated
namespace program
{
    class Problem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the mindfulness program!");
            Console.WriteLine("Describe your self by chosing a number\nrelated to your problem");
            Console.WriteLine(@"1. Fearful\n2. Stranded\n3.Forgetful ";);
            string choice = Console.Write("Which number is it?: ");
 
            int choice = int .parse (Console.ReadLine());
            Console.WriteLine ($"{choice}");
            Problem problem = new Problem()
            problem.Set_stress =  ( "  ");
            problem.Set_anxious =  ("  ");


            Solution solution = new Solution()
            solution.Set_Breath =("  ");
            solution.Set_Reflect=("  ");
            solution.Set_List   =("  ");   


        }
    }
}