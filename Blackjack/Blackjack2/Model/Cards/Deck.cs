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
        private List<Card> _cards;
        private string[] suits =
        {
            "♠","♣","♥","♦"
        };

        private const byte SUITS = 4;
        private const byte CARDS_PER_SUIT = 14;  // 13
        
        public List<Card> Cards
        {
            get { return _cards; }
            private set { _cards = value; }
        }

        public Deck()
        {
            _cards = new List<Card>();
            FillDeck();
        }

        #region Shuffle

        // For some reason, shuffling the deck and drawing .First() or .Last()
        // Always results in the deck returning cards in perfect sequence
        // ???

        Random random = new Random();

        public void ShuffleDeck()
        {
            for (int i = 0; i < _cards.Count; i++)
            {
                var shuffle = random.Next(0, _cards.Count);

                var card = _cards[i];
                _cards[i] = _cards[shuffle];
                _cards[shuffle] = card;
            }
        }

        #endregion

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
            _cards = deck;
        }

        public Random r = new Random();
        public Card DrawCard(List<Card> deck)
        {
            var card = deck[r.Next(0, _cards.Count)];
            _cards.Remove(card);

            return card;
        }

        public void EmptyDeck()
        {
            _cards.Clear();
        }
    }
}
