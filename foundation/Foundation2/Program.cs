using system;
class Product
{
    public int Quantity   { get; set; }
    public string Name  { get; private set; }

    public Product() // Empty constructor
    { }

    public Product(int Quantity, string name)
    {
        Quantity = quantity; // Work with Age as it is a field
        Name = " "; 
    }
    
    public int Price  { get; set; }
    public string Identity { get; private set; }

    public Product() // Empty constructor
    { }

    public Product(int Price, string Identity)
    {
        Price = price; // Work with Age as it is a field
        Identity = " "; 
    }
    
}





class Order
{
    public string Sales   { get; set; }
    public string Names { get; private set; }

    public Order() // Empty constructor
    { }

    public Product(string Sales, string Names)
    {
        Sales = sales; // products sold to 1 buyer
        Names = " "; // names of a buyer
    }
    
    public int Sum { get; set; }
    public int Sipping{ get; private set; }

    public Order() 
    { }

    public Order(int Sum, string Shipping)
    {
        Sum = sum;
        Shipping = " ";
     
    }
    
}










class ClassWithMain
{
    public static void Main()
    {
        // Using object initializer
        var student = new Student
        {
            Age = 20, // Work with Age just like a public field
            Name = "John" // ERROR: setter for the Name is private
        };

        // Using classic approach
        var student = new Student();
        student.Age = 20; // Work with Age just like a public field
        student.Name = "John" // ERROR: setter for the Name is private

// Using a constructor that sets age
var student = new Student(20, "John");
    }






















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

    //info here now
    private int house = Console.Write("Your house number: ");
    private int house = int.parse(Console.ReadLine());
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
