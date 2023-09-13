using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _4.Blackjack.Model.Model;

namespace _4.Blackjack.Controller
{
    public class BlackjackGame
    {
        Model.Model model = new Model.Model();

        private List<Card> deck;
        public Player player;
        public Player dealer;

        public BlackjackGame()
        {
            InitializeDeck();
            player = new Player();
            dealer = new Player();
        }

        private void InitializeDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            deck = new List<Card>();

            foreach (var suit in suits)
            {
                foreach (var face in faces)
                {
                    deck.Add(new Card(suit, face));
                }
            }
        }

        public void ShuffleDeck()
        {
            Random rng = new Random();
            deck = deck.OrderBy(card => rng.Next()).ToList();
        }

        public Card DealCard()
        {
            if (deck.Count == 0)
            {
                Console.WriteLine("The deck is empty.");
                return default(Card); // Return a default card if the deck is empty.
            }

            Card card = deck[0];
            deck.RemoveAt(0);
            return card;
        }

        public void StartGame()
        {
            ShuffleDeck();
            player.Hand.Clear();
            dealer.Hand.Clear();

            // Deal initial cards
            player.Hand.Add(DealCard());
            dealer.Hand.Add(DealCard());
            player.Hand.Add(DealCard());
            dealer.Hand.Add(DealCard());

            // Implement game logic here
            // You can add methods for player's turn, dealer's turn, and determining the winner.
        }

        // Implement additional game logic methods here
    }
}
