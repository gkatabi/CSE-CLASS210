/*using System;

class labels
//I will use the getters setters 
{
    public class packing
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        class shippingLabel
        {
            public string destiny;
            public string Destiny
            {
                get { return destiny; }
                set { destiny = value; }
            }
        }
        class program
        {
            static void main(string[] args)
            {
                //Detail company label
                shippingLabel myobj = new shippingLabel();
                myobj.destiny = "Alma packages";
                myobj.display();

                //Detail destiny
                shippingLabel.myobj = new shippingLabel();
                myobj.destiny = "42 Orlando Crescent USA";
                Console.WriteLine(myobj.destiny);
                Console.WriteLine(myobj.Destiny);
            }

        }

    }
}*/


using System;

namespace MyApplication
{
  class Car 
  {
    string color = "red";
    int maxSpeed = 200;
    string size = "big";

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
      Console.WriteLine(myObj.maxSpeed);
 Console.WriteLine(myObj.size);
 