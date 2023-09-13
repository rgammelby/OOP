using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    public class Dealer
    {
        // see Player class for comments, these classes are identical (yes, i know)

        private List<Card> _hand;
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Dealer()
        {
            _hand = new List<Card>();
        }

        public List<Card> Hand
        {
            get { return _hand; }
            private set { _hand = value; }
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
            if (card.Value != 0)
                _value += card.Value;

            if (card.Broadway == 'J' || card.Broadway == 'Q' || card.Broadway == 'K')
                _value += 10;

            if (card.Broadway == 'A' && (_value + 11) > 21)
                _value += 1;
            else if (card.Broadway == 'A')
                _value += 11;

            if (AceCount > 0 && _value > 21)
            {
                AceCount = 0;
                _value -= 10;
            }
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

        public void EmptyHand()
        {
            _value = 0;
            _hand.Clear();
        }
    }
}
