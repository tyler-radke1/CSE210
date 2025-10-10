//Extra - To go the extra mile in this program, I used an abstract class for the activity. 
//Doing this I was able to use activity as more of a framework or blueprint than a base class.
// This allowed for some things to be cleaned up nicely throughout such as 
// the Excercize() function.

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");

            string? choice = Console.ReadLine();

            Activity? activity = choice switch
            {
                "1" => new Breathing(),
                "2" => new Reflection(),
                "3" => new Listing(),
                "4" => null,
                _ => null
            };

            if (activity == null)
            {
                if (choice == "4") break;
                Console.WriteLine("Invalid choice. Press Enter to continue...");
                Console.ReadLine();
            }
            else
            {
                activity.Exercise();
            }
        }
    }
}
