using system;
class product_label 
{
    public virtual void description()
    {
       //info here
        
        Console.WriteLine("description");
    }
}


class customer: product
{
    public overide void charactOne()
    {

        // info
        Console.WriteLine( "description");
    }
}

class address: label
{
  public override void charactOne() 
  {

    //info here
    Console.WriteLine("description");
  }
}

class order: label
{
  public override void charactOne() 
  {
    //info here
    
    Console.WriteLine("description");
  }
}
   

class Program 
{
  static void Main(string[] args) 
  {
     Label myCustomer = new Customer();  // Create a Label object
    Label myAddress = new Address();  
    Label  myOrder = new Order();  // Create a Order object

    myCustomer.description();
    myAddress.description();
    myOrder.description();
  }
} 
