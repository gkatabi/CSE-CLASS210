user system;
namespace storage_emulated
{
    public class Problem
    {
        protected string _stressed = "1. Fear\n2. Stranded\n3.Forget ";
        protected string _anxious  = "1. Busy\n2. Forget\n3. Unreliable ";
        public string Get problem()
        {
            return $"{   }  {  } { } ";
        }
        
    }
    
    public class solutionActivity
    {
        private string _breath = "1. Breath and waitfor10 seconds\2. Breath out and wait for 10 seconds ";
        private string _reflect= "1. Reflect on how your parent suffered\n2. Imitate Jesus\3. Close eyes and imagine inside heaven ";
        private string _list   = "1. List how you feel\2. List what you have learned\n3. List your wishes ";
        public string GetSolutionActivity()
        {
            return $"{_breath}{_reflect} {_list}";
           
        }


    }
   
}





















}
