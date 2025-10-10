public class Breathing : Activity
{
    public Breathing() : base(
        "Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public override void Exercise()
    {
        StartActivity();

        int breathTime = 5; 
        int totalCycles = _duration / (breathTime * 2);

        for (int i = 0; i < totalCycles; i++)
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            ShowCountdown(breathTime);

            Console.Clear();
            Console.WriteLine("Breathe out...");
            ShowCountdown(breathTime);
        }

        EndActivity();
    }
}
