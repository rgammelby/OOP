using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    public class Controller
    {
        public void Start()
        {
            Deck d = new Deck();
            /*
            var card = new Card("♠", 'A');
            Console.WriteLine(card.ToString());
            Console.ReadLine();*/

            List<Card> deck = d.GetDeck();

            /*
            foreach (Card c in deck)
            {
                Console.WriteLine(c);
            }*/

            Console.ReadLine();
        }
    }
}
