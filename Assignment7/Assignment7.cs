using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment7
*ITC 110 Fall 2016
*Rebecca Scott
*This program will be a guessing game*/

namespace Assignment7
{
    /*The goal of this project is to create a guessing game. 
	*Break the project into appropriate methods.
*
*The game should generate a random number between 1 and 500.
*
*The player gets 10 tries to guess the number. With each guess 
*the game will notify the player whether the guess is too high, 
*too low or correct.  
*
*If the player correctly guesses the number, the program will 
*stop asking for guesses, congratulate the player and show the 
*player's score. The score is 10 minus the number of guesses.
*
*Use proper naming conventions and document code.*/

    /*Extras:
    *When the game ends prompt whether the player wants to play again.
    * If the player responds yes, start the play over, if no, end the 
    *game and display all the players scores and their average scores.

    Use an array to track scores for the games played.*/
    class Program
    {
        private int num = 0;
        static void Main(string[] args)
        {
            Program p = new Program();

            p.Score();
            p.Pause();



        }//end static

        //method to generate random number
        private int GenNum()
        {
            Random rnd = new Random();
            num = rnd.Next(0, 501);

            return num;
        }//end GenNum



        //loop method to ask for guesses, say if they are high, low, or right
        private int Guesses()
        {
            Console.WriteLine("Let's play a guessing game.");
            Console.WriteLine("I have picked a number between 1 and 500.");
            Console.WriteLine("Now you try to guess what it is. You have ten tries.");

            int n = GenNum();
            int score = 0;

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Please enter your guess.");
                int guess = int.Parse(Console.ReadLine());
                score = 10 - i;

                if (guess == n)
                {
                    Console.WriteLine("Your guess is correct!");
                    break;
                }//end if
                else if (guess > n)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                }//end else if 1
                else if (guess < n)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                }


            }//end for loop
            return score;

        }//end Guesses

        //method to write score
        private void Score()
        {
            int s = Guesses();
            Console.WriteLine("Your score is {0}.", s);
        }//end score

        private void Pause()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }//end Pause

    }//end class
}//end namespace
