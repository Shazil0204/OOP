using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using _4.Blackjack.Controller;

namespace _4.Blackjack
{
    #region View
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            while (true)
            {
                BlackjackGame game = new BlackjackGame();
                game.StartGame();

                // Display the game state (player's hand, dealer's visible card, etc.)
                Console.WriteLine("Your hand:");
                foreach (var card in game.player.Hand)
                {
                    Console.WriteLine(card);
                }

                Console.WriteLine($"Dealer's visible card: {game.dealer.Hand[0]}");

                // Implement user interactions to hit or stand (e.g., by reading user input)
                while (true)
                {
                    Console.Write("Do you want to (H)it or (S)tand? ");
                    string choice = Console.ReadLine().Trim().ToUpper();

                    if (choice == "H")
                    {
                        // Implement player's hit logic
                        game.player.Hand.Add(game.DealCard());
                        Console.WriteLine("Your hand:");
                        foreach (var card in game.player.Hand)
                        {
                            Console.WriteLine(card);
                        }

                        if (game.player.CalculateHandValue() > 21)
                        {
                            Console.WriteLine("You busted! You lose.");
                            break;
                        }
                    }
                    else if (choice == "S")
                    {
                        // Implement player's stand logic

                        // Dealer's turn
                        while (game.dealer.CalculateHandValue() < 17)
                        {
                            game.dealer.Hand.Add(game.DealCard());
                        }

                        Console.WriteLine("Dealer's hand:");
                        foreach (var card in game.dealer.Hand)
                        {
                            Console.WriteLine(card);
                        }

                        // Determine the winner
                        int playerValue = game.player.CalculateHandValue();
                        int dealerValue = game.dealer.CalculateHandValue();

                        if (playerValue > 21)
                        {
                            Console.WriteLine("You busted! You lose.");
                        }
                        else if (dealerValue > 21 || playerValue > dealerValue)
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (playerValue < dealerValue)
                        {
                            Console.WriteLine("Dealer wins.");
                        }
                        else
                        {
                            Console.WriteLine("It's a tie!");
                        }

                        break;
                    }
                }

                // Ask the user if they want to play again
                Console.Write("Do you want to play again? (Y/N): ");
                string playAgain = Console.ReadLine().Trim().ToUpper();
                if (playAgain != "Y")
                {
                    break;
                }
            }

            Console.WriteLine("Thanks for playing Blackjack!");
        }
    }

    #endregion
}