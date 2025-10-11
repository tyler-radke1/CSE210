using System;

//As my extra for this assignment, I looked into converting my save/loading functions to use JSON instead of just writing to a txt file.
//This is because JSON is more industry standard for formatting data and better suited for objects.
class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            manager.DisplayPlayerInfo();
            Console.WriteLine("\nOptions:\n1. Create New Goal\n2. List Goals\n3. Save Your Goals\n4. Load Your Goals\n5. Record\n6. Quit");
            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.ListGoalDetails();
                    break;
                case "3":
                    manager.SaveGoalsJson();
                    break;
                case "4":
                    manager.LoadGoalsJson();
                    break;
                case "5":
                    manager.RecordEvent();
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Goodbye!");
    }

}