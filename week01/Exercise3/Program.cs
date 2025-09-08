using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Random rnd = new Random();

            int number = rnd.Next(100);

            bool isPlaying = true;

            int guessCount = 0;

            while (isPlaying)
            {
                Console.WriteLine("What is your guess?");

                string guess = Console.ReadLine();

                int intGuess = int.Parse(guess);

                guessCount += 1;

                if (intGuess > number)
                {
                    Console.WriteLine("Your guess is too high!");
                }
                else if (intGuess < number)
                {
                    Console.WriteLine("Your guess is too low!");
                }
                else
                {
                    Console.WriteLine($"Your guess is right. You Win! You guessed it in {guessCount} tries.");
                    isPlaying = false;
                }
            }

        }
    }
}