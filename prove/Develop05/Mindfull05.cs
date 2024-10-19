using System;
namespace Mindfull
{
    public class Problem
    {
        private string _fear ="Stressed ";
        public string GetFear(string fear)
        {
            return _fear;
        }
 

        public void GetStranded(string stranded)
        {
            return _stranded;
        }
        private string _stranded = "Stressing ";

        private string _forgetful = "Anxiety";
        public string GetForgetful(string anxiety)
        {
            return _anxiety;
        }
        public void GetProblem()
        {
            return  (_fear)   (_Stressed);
        }
    }
    public class Activity
    {        
        private string _breath = " deepbreath ";
        public void GetBreath (string deepbreath )
        {
            return _deepbreath;
        }
        private  string _reflect = "Archeived ";
        public string GetReflect (string archeived)
        {
            return _archeived;
        }
        private string _list = "Things  ";
        public string GetList (string things )
        {
            return _things;
        }
        public string GetActivity()
        {
            return (_breath) (_reflect )  ( _list);
        }

    }

}


