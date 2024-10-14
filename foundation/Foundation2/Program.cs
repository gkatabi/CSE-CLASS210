using system;
class product_label 
{
    public virtual void charactOne()
    {
       //info here
        
        Console.WriteLine("charactOne");
    }
}


class customer:label
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
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
} 
