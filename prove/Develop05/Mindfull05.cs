using system;
//namespace storage_emulated
namespace program
{
    public class Problem
    {
        protected string _stressed = @"1. Fearful\n2. Stranded\n3.Forgetful ";
        protected string _anxious  = @"1. Busy\n2. Forget\n3. Unreliable ";
        public string GetProblem()
        {
            return $"Are you{_stressed}?\nAre you{_anxious}?";
        }
        
    }
    
    public class solutionActivity
    {
        private string _breath = @"1. Breath & out and wait for10 seconds\2. Breath out and in & wait for 20 seconds ";
        private string _reflect= @"1. Reflect on how your parent suffered\n2. Imitate Jesus\3. Close eyes & imagine God ";
        private string _list   = @"1. listing how you feel\2. listing what you have learned\n3. listing your wishes ";
        public string GetSolutionActivity()
        {
            return $"{_breath}\n and {_reflect}\n {_list}";
           
        }


    }
   
}





















}
