using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The journal reminder app");
        DateTime now = DateTime.Now;
        Console.WriteLine(now);
        Console.ReadLine();
        Console.WriteLine("This reminder for: \r\nI1)waking up \r\nI2)Important event \nI3) have finished \r\nIIt's records");        
        Console.Write("Chose a number for  this time's reminder: ")
        int numberChozen = int.perse(Console.ReadLine());

        

      
    }
}
print()
money= " "
done = " "
cart = [ ]
charges = [ ]
    


while True:
    Items = input("What iitem would you like to add?: ").capitalize()
    
    if Items  == "Q":
        choice = int( input ("Please select one of the following numbers: \n1. Add item\n2. View cart\n3. Remove item\n4. Compute total\n5. Quit \nYour choice is:   "))
        if choice ==2:
            print( i,item)  
        break
        if choice == 3:
            remove =int(input("Which number do you want removed?:  "))
        if choice == 4:
            compute = input("Def")
            
        if choice == 5:
            break
            

        print("   $".join(others))
    prices = input(f"What is the price of{Items}?:   ")
   
    charges.append(prices)
    print(charges)
        
#  join  where abreviation is space for separation characters followed by the dot join of 2 strings
    dizy =[Items,prices]
    print("   $"   .join(dizy))
    
    cart.append ("   $"   .join(dizy))
    print(f"{Items}, has been added to your cart")
         
    
#   Call for enumeration to identify arrays by number 
    
    
    for (i, item) in enumerate(cart, start=1):           print(i, item)