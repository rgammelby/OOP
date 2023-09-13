using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    public class Dealer
    {
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
        }
        /*
        public int GetValue()
        {

        }*/

        public void EmptyHand()
        {
            _hand.Clear();
        }
    }
}
