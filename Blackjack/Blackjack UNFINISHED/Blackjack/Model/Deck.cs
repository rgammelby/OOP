using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Model
{
    public class Deck
    {
        // contains 52 cards

        //private Card[] _deck;
        public List<Card> _deck = new List<Card>();

        public List<Card> DeckOfCards
        { 
            get { return _deck; }
            private set { _deck = value; }
        }

        /*
        public Card[] deck
        {
            get { return _deck; }
            private set { _deck = value; }
        }*/

        public string[] suits =
        {
            "♠","♣","♥","♦"
        };

        public const string
                SPADES = "♠",
                CLUBS = "♣",
                HEARTS = "♥",
                DIAMONDS = "♦";

        public const byte FULL_DECK = 52;
        public const byte SUITS = 4;
        public const byte CARDS_PER_SUIT = 13;

        public void FillDeck()
        {
            for (int i = 0; i < SUITS; i++)
            {
                for (int j = 1; j < CARDS_PER_SUIT; j++)
                {
                    _deck.Add(new Card(suits[i], (byte)j));
                }
            }
        }

        public void PrintDeck(Deck d)
        {
            for (int i = 0; i < d.DeckOfCards.Count; i++)
            {
                Console.WriteLine(d.DeckOfCards[i].ToString());
            }
        }

        public Card DrawCard(Deck d)
        {
            var card = d.DeckOfCards.Last();
            d.DeckOfCards.Remove(card);

            return card;
        }

        public void ShuffleDeck(Deck d)
        {
            Random random = new Random();

            var ran = random.Next(52);
            var dom = random.Next(52);
        }
    }
}
