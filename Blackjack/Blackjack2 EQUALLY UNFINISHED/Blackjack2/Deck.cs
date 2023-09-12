using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    public class Deck
    {
        private List<Card> _Deck;
        private string[] suits =
        {
            "♠","♣","♥","♦"
        };

        private const byte FULL_DECK = 52;
        private const byte SUITS = 4;
        private const byte CARDS_PER_SUIT = 14;  // 13
        
        public Deck()
        {
            FillDeck();
        }

        public List<Card> Cards
        {
            get { return _Deck; }
            private set { _Deck = value; }
        }

        public void FillDeck()
        {
            List<Card> deck = new List<Card>();

            for (int i = 0; i < SUITS; i++)
            {
                for (int j = 1; j < CARDS_PER_SUIT; j++)
                {
                    if (j == 1)
                        deck.Add(new Card(suits[i], 'A'));
                    else if (j == 11)
                        deck.Add(new Card(suits[i], 'J'));
                    else if (j == 12)
                        deck.Add(new Card(suits[i], 'Q'));
                    else if (j == 13)
                        deck.Add(new Card(suits[i], 'K'));
                    else
                        deck.Add(new Card(suits[i], (byte)j));
                }
            }

            _Deck = deck;
        }

        public Card DrawCard(List<Card> deck)
        {
            Random r = new Random();
            var card = _Deck[r.Next(0, deck.Count)];
            _Deck.Remove(card);

            return card;
        }

        public List<Card> GetDeck()
        {
            return _Deck;
        }
    }
}
