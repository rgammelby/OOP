using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    public class Card
    {
        // Suits: "♠", "♣", "♥", "♦"
        private byte _value;
        private char _broadway;
        private string _suit;
        public Card()
        {
            _suit = "";
            _value = 0;
            _broadway = ' ';
        }

        public Card(string suit) : this()
        {
            _suit = suit;
        }

        public Card(string suit, byte value) : this(suit)
        {
            _value = value;
        }

        public Card(string suit, char broadway) : this(suit)
        {
            _broadway = broadway;
        }

        public byte Value
        {
            get { return _value; }
            private set { _value = value; }
        }

        public char Broadway
        {
            get { return _broadway; }
            private set { _broadway = value; }
        }

        public string Suit
        {
            get { return _suit; }
            private set { _suit = value; }
        }

        public override string ToString()
        {
            if (Value != 0)
                return string.Format("{0} {1}", Suit, Value);
            else
                return string.Format("{0} {1}", Suit, Broadway);
        }
    }
}
