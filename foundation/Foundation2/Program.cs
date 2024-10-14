using system;
class product_label 
{
    public virtual void description()
    {
       //info here
        
        Console.WriteLine("description");
    }
}


class customer: label
{
    public overide void description()
    {

        // info
        private string name = Console.Write("What is your name: ");
Console.ReadLine();
        Console.WriteLine($"{name} description");
    }
}

class address: label
{
  public override void description() 
  {

    //info here
    private int house = Console.Write("Your house number: ");
    private int house = into.parse(Console.ReadLine());
    Console.WriteLine($"House description: {house}");
  }
}

class order: label
{
  public override void description() 
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
