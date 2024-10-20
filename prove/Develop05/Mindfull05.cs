using System;
namespace Mindfull
{
    public class Problem
    {
        private string _axiety ="ok ";

        public string GetAnxiety()
        {
            return _anxiety;
        }
        public void setAnxiety(string anxiety)
        {
            _anxiety = anxiety;
        }
 
        private string _stress = "tod ";
        public string GetStress()
        {
            return _stress;
        }
        public void SetStress(string stress)
        {
            _stress = stress;
        }
        

    public class Solution
    {        
        private string _activity = " do ";
        public string GetActivity ( )
        {
            return _activity;
        }
        public void SetActivity(string activity)
        {
            _activity = activity;
        }


        private string _time = "sec";
        public string GetTime ( )
        {
            return _time;
        }
        public void SetTime(string time)
        {
            _time = time;
            
        }
        public string GetProblemInfo()
        {
            return ($"{anxiety } solved by {activity} in {time} seconds"):
        }

    }

}





