using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Model
{
    public class Model
    {
        // PLAYER

        public struct Player
        {
            public List<Card> Hand { get; set; }
        }

        public Player p = new Player();

        public void DealToPlayer(Card c)
        {
            p.Hand.Add(c);
        }

        public List<Card> GetPlayerHand()
        {
            List<Card> hand = p.Hand;

            return hand;
        }

        // DEALER

        public struct Dealer
        {
            public List<Card> hand { get; set; }
        }

        public Dealer d = new Dealer();

        public void DealToDealer(Card c)
        {
            d.hand.Add(c);
        }

        public List<Card> GetDealerHand()
        {
            List<Card> hand = d.hand;

            return hand;
        }
    }
}
