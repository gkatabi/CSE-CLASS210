using System;

namespace MyApplication
{
    class Video
    {
        string tittle = "Funn movie";
        string author = "Roberts";
        string identity = Console.writeLine("Provide your names & coment");
        string identity = Console.Write("Your personal name ");
        string identity = Console.ReadLine();
        string country = Console.Write("Your country: ");
        string country = Console.ReadLine();
        string comment = Console.Write("Your coment please: ");
        string comment = Console.ReadLine();

        static void Main(string[] args)
        {

            Video myObj = new Video();
            Console.WriteLine(myObj.tittle);
            Console.WriteLine(myObj.author);
            Console.WriteLine(myObj.identity);
            Console.WriteLine(myObj.country);
            Console.WriteLine(myObj.comment);
        }

    }
}




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
 