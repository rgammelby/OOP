using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    public class View
    {
        #region Game Progress

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

        public void PrintPlayerHandValue(Player player)
        {
            Console.WriteLine($"\nPlayer hand sum: {player.Value}");
        }

        public void UpdateScreen(Player p, Dealer dr)
        {
            PrintDealerHand(dr);
            PrintPlayerHand(p);
        }


        public void TryAgain()
        {
            At(Console.CursorTop + 2, 6, "\nWould you like to try again? \n\n" +
                "Press any key to play again \n" +
                "Press Escape to exit");
        }

        #endregion

        #region Controls & Control Highlights

        public void Controls()
        {
            Console.Clear();

            At(30, 0, "[ 1 ] Hit me! ");
            At(30, 1, "[ 2 ] Stand ");
            At(30, 2, "[ Esc ] Quit ");
        }

        public void HighlightHitMe()
        {
            Console.ForegroundColor = ConsoleColor.White;
            At(30, 0, "[ 1 ] Hit me! ");
            Task.Delay(100).Wait();
            Console.ResetColor();
        }

        public void HighlightStand()
        {
            Console.ForegroundColor = ConsoleColor.White;
            At(30, 1, "[ 2 ] Stand ");
            Task.Delay(100).Wait();
            Console.ResetColor();
        }
        public void HighlightQuit()
        {
            Console.ForegroundColor = ConsoleColor.White;
            At(30, 2, "[ Esc ] Quit ");
            Task.Delay(100).Wait();
            Console.ResetColor();
        }

        #endregion

        #region Win / Bust Announcements
        public void ShowdownPlayerWin(Player p, Dealer d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You win with {p.Value} to the Dealer's {d.Value}. ");
            Console.ResetColor();
        }

        public void ShowdownPlayerBust(Player p, Dealer d)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The Dealer has you beat with a {d.Value} to your {p.Value}. ");
            Console.ResetColor();
        }

        public void DealerBust(Dealer d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You win! The dealer has gone bust with a {d.Value}. ");
            Console.ResetColor();
        }

        public void Blackjack()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Blackjack! You've won.");
            Console.ResetColor();
        }
        public void Bust()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You've gone bust!");
            Console.ResetColor();
        }

        public void Win()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You've won!");
            Console.ResetColor();
        }

        #endregion

        #region Utility
        public void At(int x, int y, string s)
        {
            var ox = Console.CursorLeft;
            var oy = Console.CursorTop;

            Console.SetCursorPosition(x, y);
            Console.Write(s);

            Console.SetCursorPosition(ox, oy);
        }
        public void PrintDeck(List<Card> deck)
        {
            foreach (Card card in deck)
                Console.WriteLine(card.ToString());
        }

        #endregion
    }
}
