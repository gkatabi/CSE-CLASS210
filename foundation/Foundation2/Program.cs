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
        Sales= sales;
        Names = " ";
     
    }
    
}




class Customer 
{
    public string Name  { get; set; }
    public string Address{ get; private set; }

    public Customer () // Empty constructor
    { }

    public Product(string Name, string Address)
    {
        Name = name; 
        Addreas = " "; 
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
    public string Resident { get; set; }
    public string international { get; private set; }

    public Customer() 
    { }

    public Customer(string Resident, string International)
    {
        Resident = USA;
        International = " ";
     
    }
}








class alAddressor 
{
    public int House { get; set; }
    public string Street{ get; private set; }

    public Adressor() 
    { }

    public Adressor(int House,string Street)
    {
        House = house; 
        Street = " "; 
    }
    
    public string City { get; set; }
    public string Province{ get; private set; }

    public Addressor () 
    { }

    public Addressor (string City, string Provincy)
    {
        City = city;
        Province = " ";
     
    }
    public string Resident { get; set; }
    public string international { get; private set; }

    public Customer() 
    { }

    public Customer(string Resident, string International)
    {
        Resident = USA;
        International = " ";
     
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

