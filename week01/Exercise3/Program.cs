using System;


class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Console.WriteLine("Hi! Welcome to the guess game.");
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int numberGuess = -1;
            int guessCount = 0;

            while (numberGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                numberGuess = int.Parse(Console.ReadLine());
                guessCount++;

                if (numberGuess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (numberGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }

            Console.WriteLine($"It took {guessCount} guesses to find the magic number!");
            Console.WriteLine();

            Console.Write("Do you want to continue? (yes/no): ");
            response = Console.ReadLine().ToLower();

            Console.WriteLine();

            if (response != "yes")
            {
                Console.WriteLine("Thanks for playing! Goodbye.");
            }

        }


    }

}