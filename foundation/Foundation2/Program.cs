using system;
class Product
{
    public int Quantity   { get; set; }
    public string Name  { get; private set; }

    public Product() 
    { }

    public Product(int Quantity, string name)
    {
        Quantity = quantity; 
        Name = " "; 
    }
    
    public int Price  { get; set; }
    public string Identity { get; private set; }

    public Product() 
    { }

    public Product(int Price, string Identity)
    {
        Price = price; 
        Identity = " "; 
    }
    
}
class Order
{
    public string Sales   { get; set; }
    public string Names { get; private set; }

    public Order() 
    { }

    public Product(string Sales, string Names)
    {
        Sales = sales; 
        Names = " "; 
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
    public Customer () 
    { }
    public Product(string Name, string Address)
    {
        Name = name; 
        Addreas = " "; 
    }
    
    public int Sum { get; set; }
    public int Shipping{ get; private set; }
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
class PackingShipping
{
    public static void Main()
    {

       Var name   = new Name(20, "John");

       Var identify       = new Identity    (3, "Books " );

       Var names  = new Names  [, "Framingo" ];

       Var sum = new Sum    ( , "35 " );

       Var name  = new Name ( ,"40 Queens " );

       Var sun  = new  Sum  ( "350, " );

       Var resident = new Resident ( ,"No " );

       Var house = new House ( ,"Madiba " );

       Var city = new City ( ,"Western " );

       Var resident = new Resident ( " " );
    }
}















