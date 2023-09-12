using Blackjack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Controller
{
    public class Controller
    {
        Deck d = new Deck();
        Blackjack.Model.Model m = new Blackjack.Model.Model();

        public void Start()
        {
            d.FillDeck();
            d.PrintDeck(d);
            Console.WriteLine("Deck printed. \n");

            m.DealToPlayer(d.DrawCard(d));

            m.DealToDealer(d.DrawCard(d));

            d.PrintDeck(d);

            Console.WriteLine("Player cards: \n");

            foreach (Card card in m.p.Hand)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("Dealer cards: \n");

            foreach (Card card in m.d.hand)
            {
                Console.WriteLine(card);
            }
        }
    }
}
