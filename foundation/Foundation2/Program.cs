using system;
class product_label 
{
    public virtual void charactOne()
    {
       //info here
        
        Console.WriteLine("charactOne");
    }
}


class customer: product
{
    public overide void charactOne()
    {

        // info
        Console.WriteLine( "    ");
    }
}

class address: label
{
  public override void charactOne() 
  {

    //info here
    Console.WriteLine("       ");
  }
}

class order: level
{
  public override void charactOne() 
  {
    //info here
    
    Console.WriteLine("          ");
  }
}
   

class Program 
{
  static void Main(string[] args) 
  {
     LabelmyCustomer = new Customer();  // Create a Label object
    Label myAddress = new Address();  
    Label  myOrder = new Order();  // Create a Dog object

    myCustomer.charactOne();
    myAddress.charactOne();
    myOrder.charactOne();
  }
} 
