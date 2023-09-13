using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    public class Player
    {
        private List<Card> _hand;
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public List<Card> Hand
        {
            get { return _hand; }
            private set { _hand = value; }
        }

        public Player()
        {
            _hand = new List<Card>();
        }

        public List<Card> GetHand()
        {
            return _hand;
        }

        public void DrawCard(Card card)
        {
            AddValue(card);
            _hand.Add(card);
        }

        public void AddValue(Card card)
        {
            // if card has a number value, add that value
            if (card.Value != 0)
                _value += card.Value;

            // if drawn card is a broadway card, add 10
            if (card.Broadway == 'J' || card.Broadway == 'Q' || card.Broadway == 'K')
                _value += 10;

            // if drawn card is an ace add 11; if the card would bring the value of the player's hand above 21, add 1 instead
            if (card.Broadway == 'A' && (_value + 11) > 21)
                _value += 1;
            else if (card.Broadway == 'A')
                _value += 11;

            // if the player already has an ace in the hand at the start of the game, and they draw a card that would bring the value of their hand above 21, convert the ace from 11 to 1 (_value -= 10)
            if (AceCount > 0 && _value > 21)
            {
                AceCount = 0;
                _value -= 10;
            }
        }

        public int GetValue()
        {
            return _value;
        }

        public void EmptyHand()
        {
            _value = 0;
            _hand.Clear();
        }

        public byte AceCount = 0;

        public void AceCheck()
        {
            foreach (Card card in _hand)
            {
                if (card.Broadway == 'A')
                    AceCount = 1;
            }
        }
    }
}
