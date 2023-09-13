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
        private List<Card> _deck;
        private string[] suits =
        {
            "♠","♣","♥","♦"
        };

        private const byte FULL_DECK = 52;
        private const byte SUITS = 4;
        private const byte CARDS_PER_SUIT = 14;  // 13
        
        public Deck()
        {
            _deck = new List<Card>();
            FillDeck();
        }

        Random random = new Random();

        public void ShuffleDeck()
        {
            for (int i = 0; i < _deck.Count; i++)
            {
                var shuffle = random.Next(0, _deck.Count);

                var card = _deck[i];
                _deck[i] = _deck[shuffle];
                _deck[shuffle] = card;
            }
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

            _deck = deck;
        }

        public Random r = new Random();
        public Card DrawCard(List<Card> deck)
        {
            var card = deck[r.Next(0, deck.Count)];
            deck.Remove(card);

            return card;
        }

        public List<Card> GetDeck()
        {
            return _deck;
        }
    }
}
