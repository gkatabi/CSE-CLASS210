using System;
using System.IO;
{
    public class program
    {
        public static void Main(string[]args)
        {
            Console.Write("What Chapter should I remind you in psalms?: ");
            int chapter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Psalms " + chapter);


            //int _verse1;
            Console.Write("Which verse is the starting point?:  ");
            int verse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Psalms {verse} - ");

            Console.Write("What is the ending point?: ");
            verseEnd = int.parse(Console.ReadLine());
            Console.WriteLine("Psalms", chapter + verse + verseEnd);
            Console.Write("Copy and paste all its words here: ");
            
            string text = Console.Write("Paste text: ");
            
            
            string book = @"C:\book.txt";
            File.AppendAll Text(book,Environment.NewLine+ "  ");
            string txtappd = File.ReadAllText(book);
        }
    }
}           
    
