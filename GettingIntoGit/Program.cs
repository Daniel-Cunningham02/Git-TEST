using System;

namespace GettingIntoGit
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("You're now playing a guessing game. Guess a number between 1 and 100");
            int randomNumber = rand.Next(1, 100);
            Console.Write("Guess a number: ");
            string guess = Console.ReadLine();
            int guessI32 = Int32.Parse(guess);
            if(guessI32 < randomNumber)
            {
                Console.WriteLine("Your guess was too low.");
            }
            else if (guessI32 > randomNumber)
            {
                Console.WriteLine("Your guess was too high.");
            }
            else if (guessI32 == randomNumber)
            {
                Console.WriteLine("Your guess was right!!");
            }
            Console.Write("Press enter to end the program.");
            Console.Read();
        }
    }
}
