using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    public class View
    {
        public void PrintPlayerHand(Player player)
        {
            Console.WriteLine("\nPlayer's hand: ");

            foreach (Card card in player.Hand)
            {
                if (card.Suit == "♥" || card.Suit == "♦")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{card.Suit} ");
                    Console.ResetColor();

                    if (card.Value == 0)
                        Console.Write(card.Broadway + " ");
                    else
                        Console.Write(card.Value + " ");
                }
                else
                {
                    Console.Write($"{card.Suit} "); 
                    
                    if (card.Value == 0)
                        Console.Write(card.Broadway + " ");
                    else
                        Console.Write(card.Value + " ");
                }
            }
        }

        public void PrintDealerHand(Dealer dealer)
        {
            Console.WriteLine("Dealer's hand: ");

            if (dealer.Hand[0].Suit == "♥" || dealer.Hand[0].Suit == "♦")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{dealer.Hand[0].Suit} ");
                Console.ResetColor();

                if (dealer.Hand[0].Value == 0)
                    Console.Write(dealer.Hand[0].Broadway + " ");
                else
                    Console.Write(dealer.Hand[0].Value + " ");
            }
            else
            {
                Console.Write($"{dealer.Hand[0].Suit} ");

                if (dealer.Hand[0].Value == 0)
                    Console.Write(dealer.Hand[0].Broadway + " ");
                else
                    Console.Write(dealer.Hand[0].Value + " ");
            }
        }

        public void PrintDeck(List<Card> deck)
        {
            foreach (Card card in deck)
                Console.WriteLine(card.ToString());
        }
    }
}
