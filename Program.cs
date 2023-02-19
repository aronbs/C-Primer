using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int largest = int.MinValue;
        int smallest = int.MaxValue;

        Console.WriteLine("Enter as many numbers as you want, then press Enter when you're done.");

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (input == "")
            {
                break;
            }

            try
            {
                int number = int.Parse(input);
                numbers.Add(number);

                if (number > largest)
                {
                    largest = number;
                }

                if (number < smallest)
                {
                    smallest = number;
                }
            }
            catch
            {
                Console.WriteLine("That's not a number, try again!");
            }
        }

         if (numbers.Count == 0)
        {
            Console.WriteLine("You didn't enter any numbers!");
        }
        else
        {
            Console.WriteLine("The smallest number you entered was: " + smallest);
            Console.WriteLine("The largest number you entered was: " + largest);
        }}

        


   



        
}
