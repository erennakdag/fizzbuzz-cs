using System;

namespace programming_in_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the players' names and create their objects
            Console.Write("First Player's name: ");
            Player player1 = new Player(Console.ReadLine());
            Console.Write("Second Player's name: ");
            Player player2 = new Player(Console.ReadLine());

            // Instantiate the fizzbuzz object
            FizzBuzz fizzbuzz = new FizzBuzz(player1, player2);

            // Ask the user if they want to play
            Console.Write("Wanna play fizzbuzz? [y/n]");
            bool isPlaying = Console.ReadLine() == "y";
            while (isPlaying)
            {
                // Get the rounds and start the game loop
                Console.Write("How many rounds? ");
                fizzbuzz.Play(int.Parse(Console.ReadLine()));

                // Ask for a revanche
                Console.Write("Wanna play fizzbuzz again? [y/n]");
                isPlaying = Console.ReadLine() == "y";
            }

        }
    }
}
