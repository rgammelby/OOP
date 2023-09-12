using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Model
{
    public class Card
    {
        // Suits: "♠", "♣", "♥", "♦"
        private byte _value;
        private string _suit;

        public Card()
        {
            _value = 0;
            _suit = "";
        }

        public Card(byte value) : this()
        {
            _value = value;
        }

        public Card(string suit, byte value) : this(value)
        {
            _suit = suit;
        }

        public byte Value
        { 
            get { return _value; }
            private set { _value = value; } 
        }

        public string Suit
        {
            get { return _suit; }
            private set { _suit = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Suit, Value);
        }
    }
}
