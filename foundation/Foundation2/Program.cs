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
    class shippingLabel
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
            packingLabel myobj = new packingLabel();
            myobj.name = "Alma packages"
            
            //Detail destiny
            shippingLabel myobj = new shippingLabel();
            myobj.destiny = "42 Orlando Crescent USA"
            Console.WriteLine(myobj.Name);
            Console.WriteLine(myobj.Destiny);
        }
        
    }

}    
        