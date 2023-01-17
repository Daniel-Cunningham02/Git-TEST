using System;

namespace GettingIntoGit
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Input Two numbers for the Maximum and Minimum on two separate lines.");
            string min = Console.ReadLine();
            string max = Console.ReadLine();
            Console.WriteLine("You're now playing a guessing game. Guess a number between " + Int32.Parse(min) + " and " + Int32.Parse(max) + ".");
            int randomNumber = rand.Next(Int32.Parse(min), Int32.Parse(max));
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
