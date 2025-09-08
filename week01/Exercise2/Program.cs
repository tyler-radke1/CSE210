using System;

// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60
// Assignment


// Ask the user for their grade percentage,
//  then write a series of if, else if, else statements to print out the appropriate letter grade.
//   (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percentageString = Console.ReadLine();
        double percentage = double.Parse(percentageString);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 70)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"You got a {percentage}%, which is a {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("you failed");
        }
    }
}