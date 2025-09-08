using System;
using System.Globalization;

// Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0. 
//(Remember: You should not add 0 to the list. If you do, later calculations and operations will not be correct.)

// Once you have a list, have your program do the following:

// Core Requirements

// Work through these core requirements step-by-step to complete the program. 
//Please don't skip ahead and do the whole thing at once, because others on your team may benefit from building the program up slowly.

// Compute the sum, or total, of the numbers in the list.
// Compute the average of the numbers in the list.
// Find the maximum, or largest, number in the list.
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.WriteLine("Enter Numbers. Enter 0 when you are finshed.");
            string entry = Console.ReadLine();
            int entryNumber = int.Parse(entry);

            if (entryNumber != 0)
            {
                numbers.Add(entryNumber);
            }
            else
            {
                int sum = 0;
                int max = 0;
                foreach (var number in numbers)
                {
                    sum += number;

                    max = number > max ? number : max;
                }
                Console.WriteLine($"You entered {numbers.Count()} numbers");
                Console.WriteLine($"The sum is {sum}");

                Console.WriteLine($"The average is {sum / numbers.Count()}");

                Console.WriteLine($"The highest number is {max}");
            }
        }
    }
}