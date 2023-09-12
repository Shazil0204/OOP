using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _4.Blackjack
{
    // Define a struct to represent a card
    public struct Card
    {
        public string Suit { get; }
        public string Rank { get; }

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        // Override ToString to display card details
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            while (true)
            {
                // Create a deck of cards and shuffle it
                List<Card> deck = CreateDeck();
                ShuffleDeck(deck);

                // Deal two cards to the player and the dealer
                List<Card> playerHand = new List<Card> { deck[deck.Count - 1], deck[deck.Count - 2] };
                deck.RemoveAt(deck.Count - 1);
                deck.RemoveAt(deck.Count - 1);
                List<Card> dealerHand = new List<Card> { deck[deck.Count - 1], deck[deck.Count - 2] };
                deck.RemoveAt(deck.Count - 1);
                deck.RemoveAt(deck.Count - 1);

                // Display initial hands
                Console.Clear();
                Console.WriteLine("\nYour hand:");
                DisplayHand(playerHand);
                Console.WriteLine("\nDealer's hand:");
                DisplayDealerHand(dealerHand);

                // Player's turn
                while (CalculateHandValue(playerHand) < 21)
                {
                    Console.WriteLine("\nDo you want to hit (h) or stand (s)?");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "h")
                    {
                        playerHand.Add(deck[deck.Count - 1]);
                        deck.RemoveAt(deck.Count - 1);
                        Console.WriteLine("\nYour hand:");
                        DisplayHand(playerHand);
                    }
                    else if (choice == "s")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 'h' or 's'.");
                    }
                }

                // Dealer's turn
                while (CalculateHandValue(dealerHand) < 17)
                {
                    dealerHand.Add(deck[deck.Count - 1]);
                    deck.RemoveAt(deck.Count - 1);
                }

                // Display final hands
                Console.WriteLine("\nYour hand:");
                DisplayHand(playerHand);
                Console.WriteLine("\nDealer's hand:");
                DisplayHand(dealerHand);

                // Determine the winner
                int playerValue = CalculateHandValue(playerHand);
                int dealerValue = CalculateHandValue(dealerHand);

                if (playerValue > 21 || (dealerValue <= 21 && dealerValue >= playerValue))
                {
                    Console.WriteLine("\nDealer wins!");
                }
                else
                {
                    Console.WriteLine("\nPlayer wins!");
                }

                // Ask if the player wants to play again
                Console.WriteLine("\nDo you want to play again? (y/n)");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }

        // Create a deck of cards
        static List<Card> CreateDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            List<Card> deck = new List<Card>();

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    deck.Add(new Card(suit, rank));
                }
            }

            return deck;
        }

        // Shuffle the deck
        static void ShuffleDeck(List<Card> deck)
        {
            Random rng = new Random();
            int n = deck.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = deck[k];
                deck[k] = deck[n];
                deck[n] = card;
            }
        }

        // Calculate the value of a hand
        static int CalculateHandValue(List<Card> hand)
        {
            int value = 0;
            int numAces = 0;

            foreach (var card in hand)
            {
                if (card.Rank == "Ace")
                {
                    numAces++;
                    value += 11;
                }
                else if (card.Rank == "King" || card.Rank == "Queen" || card.Rank == "Jack")
                {
                    value += 10;
                }
                else
                {
                    value += int.Parse(card.Rank);
                }
            }

            // Handle aces
            while (value > 21 && numAces > 0)
            {
                value -= 10;
                numAces--;
            }

            return value;
        }

        // Display a player's hand
        static void DisplayHand(List<Card> hand)
        {
            foreach (var card in hand)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("Total value: " + CalculateHandValue(hand));
        }

        // Display the dealer's hand with one card hidden
        static void DisplayDealerHand(List<Card> hand)
        {
            Console.WriteLine(hand[0]);
            Console.WriteLine("One card hidden");
        }
    }
}