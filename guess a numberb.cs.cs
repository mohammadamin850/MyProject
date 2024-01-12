using System;
using System.Linq;

namespace Mr.Mohammad
{
    // The class 'name' encapsulates the game logic for a Rock, Paper, Scissors game.
    class name
    {
        // The entry point of the program where the game loop will be executed.
        static void Main(string[] args)
        {
            // Set the background color of the console for better visibility.
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Apply the changed background color.
            Console.Clear();
            // Create an instance of Random to generate computer choices.
            Random random = new Random();
            // Flag for checking if the player wants to play another round.
            bool playagain = true;
            // Declare variables to store player and computer choices.
            string player, computer;
            // Loop for the main game execution will continue as long as playagain is true.
            while (playagain)
            {
                // Get the player's choice.
                player = playerRound();
                // Get the computer's choice.
                computer = playerRoundComputer(random);
                // Display the choices of the player and the computer.
                Console.WriteLine($"Player = {player}");
                Console.WriteLine($"Computer = {computer}");
                // Determine and display the winner.
                Winner(player, computer);
                // Ask the player if they want to play again and update playagain variable accordingly.
                playagain = PlayAgain();
            }
            // Message displayed when the game loop ends.
            Console.WriteLine("Thanks for playing.");
        }

        // Method to ask the player if they want to play another round.
        static bool PlayAgain()
        {
            Console.WriteLine("Would you like to play again? (Y/N)");
            // Get the player's response and convert it to uppercase.
            var result = Console.ReadLine();
            // Return true if the player enters 'Y', otherwise false.
            return result.ToUpper() == "Y";
        }

        // Method to get the player's choice.
        static string playerRound()
        {
            string player = "";
            // Loop until a valid choice is made.
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.WriteLine("Enter ROCK, PAPER, SCISSORS:");
                // Read the player's choice, convert it to uppercase to handle case insensitivity.
                player = Console.ReadLine().ToUpper();
            }
            // Return the valid choice.
            return player;
        }

        // Method to get the computer's random choice.
        static string playerRoundComputer(Random random)
        {
            // Generate a random number between 1 and 3 to represent the computer's choice.
            switch (random.Next(1, 4))
            {
                case 1:
                    return "ROCK";
                case 2:
                    return "PAPER";
                case 3:
                    return "SCISSORS";
                default:
                    // Return an empty string if a number outside the range is somehow generated.
                    return "";
            }
        }

        // Method to determine the winner of the current round.
        static void Winner(string player, string computer)
        {
            // A switch statement that covers all possible outcomes of the game.
            switch (player)
            {
                case "ROCK":
                    // Nested if-else to check the computer's choice and determine the winner.
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You lose.");
                    }
                    else
                    { 
                        Console.WriteLine("You win!"); 
                    }
                    break;
                case "PAPER":
                    if (computer == "PAPER")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "ROCK")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose.");
                    }
                    break;

                case "SCISSORS":
                    if (computer == "PAPER")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (computer == "ROCK")
                    {
                        Console.WriteLine("You lose.");
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    break;
            }
        }
    }
}