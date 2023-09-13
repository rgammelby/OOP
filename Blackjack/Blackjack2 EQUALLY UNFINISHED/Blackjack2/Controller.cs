using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    public class Controller
    {
        Deck d = new Deck();
        Player p = new Player();
        Dealer dr = new Dealer();
        View GUI = new View();

        const int STARTING_CARDS = 2;

        public void Start()
        {
            List<Card> deck = d.GetDeck();

            InitializeGame(deck);
            

            Console.ReadLine();
        }

        public void InitializeGame(List<Card> deck)
        {
            for (int i = 0; i < STARTING_CARDS; i++)
            {
                DrawPlayerCard(deck);
                DrawDealerCard(deck);
            }

            GUI.PrintDealerHand(dr);
            GUI.PrintPlayerHand(p);
        }

        public void DrawPlayerCard(List<Card> deck)
        {
            p.DrawCard(d.DrawCard(deck));
        }

        public void DrawDealerCard(List<Card> deck)
        {
            dr.DrawCard(d.DrawCard(deck));
        }
    }
}