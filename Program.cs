using System;

namespace program 
{
    class Program{
        static void Main(string[] args) {

           

            System.Console.WriteLine("How many times would you like your name repeated?");
            string input2 = Console.ReadLine();
            int repeatNum = int.Parse(input2);


            int counter = 0;

            while ( counter  <=repeatNum)
            {
                System.Console.Write("Please enter a name");
            string input = Console.ReadLine();

               //counter = counter + 1
               counter++; 
            }

            System.Console.WriteLine("Goodbye");
        }
    }
}