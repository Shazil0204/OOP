using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Blackjack.Model
{
    public class Model
    {
        public struct Card
        {
            public string Suit { get; }
            public string Face { get; }

            public Card(string suit, string face)
            {
                Suit = suit;
                Face = face;
            }

            public override string ToString()
            {
                return $"{Face} of {Suit}";
            }
        }

        public class Player
        {
            public List<Card> Hand { get; }

            public Player()
            {
                Hand = new List<Card>();
            }

            public int CalculateHandValue()
            {
                int value = 0;
                int numAces = 0;

                foreach (var card in Hand)
                {
                    if (card.Face == "Ace")
                    {
                        value += 11;
                        numAces++;
                    }
                    else if (card.Face == "King" || card.Face == "Queen" || card.Face == "Jack")
                    {
                        value += 10;
                    }
                    else
                    {
                        value += int.Parse(card.Face);
                    }
                }

                // Handle Aces
                while (value > 21 && numAces > 0)
                {
                    value -= 10;
                    numAces--;
                }

                return value;
            }
        }
    }
}
