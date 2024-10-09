using System;

class labels
//I will use the getters setters 
{
    class packing label
    {
        private string name;
        public string Name
        {
            get {return name;}
            set {name = value;}
        }
    class shipping label
    {
        private string destiny;
        public string Destiny
        {
            get{return destiny;}
            set{destiny= value;}
        }
    }
    class program
    { 
        static void main(string[]args)
        { 
            //Detail company label
            packing label myobj = new packing label();
            myobj.name = "Alma packages"
            
            //Detail destiny
            shipping label myobj = new shipping label();
            myobj.destiny = "42 Orlando Crescent USA"
            Console.WriteLine(myobj.name);
            Console.WriteLine(myobj.destiny;
        }
        
    }

}    
        