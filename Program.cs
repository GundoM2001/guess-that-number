using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            int guess;
            int numberOfGuesses = 20;
            bool gameOver = false;

            Console.WriteLine("I'm thinking of a number between 1 and 100. What is it? ;)");

            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;

                if (guess != randomNumber && numberOfGuesses == 0)
                {
                    Console.WriteLine("Wow! I gave you 20 guesses and you can't figure it out.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over...");
                }

                else if (guess == randomNumber)
                {
                    Console.WriteLine("You win. Congrats for not having the IQ of a rock");
                    Console.WriteLine();
                    Console.WriteLine("Game Over...");
                    gameOver = true;
                }

                else if (guess > randomNumber)
                {
                    Console.WriteLine("Sorry. Too high. Guess lower");
                }

                else if (guess < randomNumber)
                {
                    Console.WriteLine("Sorry. Too low. Guess higher");
                }
            }

            Console.WriteLine("Thanks for playing");
        }
    }
}
