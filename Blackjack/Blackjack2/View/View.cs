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

        // prints the contents of the player's hand. red symbol for hearts and diamonds
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
                    
                    // if the card's value is 0 (if it's a broadway card) print its associated symbol instead of the value. if not, print value
                    if (card.Value == 0)
                        Console.Write(card.Broadway + " ");
                    else
                        Console.Write(card.Value + " ");
                }
            }
        }

        // prints dealer's first card. red hearts & diamonds
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

                // -//-
                if (dealer.Hand[0].Value == 0)
                    Console.Write(dealer.Hand[0].Broadway + " ");
                else
                    Console.Write(dealer.Hand[0].Value + " ");
            }

            // secret dealer cards
            Console.Write("##");
        }

        // prints value of player hand for keeping track
        public void PrintPlayerHandValue(Player player)
        {
            Console.WriteLine($"\nPlayer hand sum: {player.Value}");
        }

        // updates console screen with 
        public void UpdateScreen(Player p, Dealer dr)
        {
            PrintDealerHand(dr);
            PrintPlayerHand(p);
        }

        // player try again prompt
        public void TryAgain()
        {
            At(Console.CursorTop + 2, 6, "\nWould you like to try again? \n\n" +
                "Press any key to play again \n" +
                "Press Escape to exit");
        }

        #endregion

        #region Controls & Control Highlights

        // control info
        public void Controls()
        {
            Console.Clear();

            At(30, 0, "[ 1 ] Hit me! ");
            At(30, 1, "[ 2 ] Stand ");
            At(30, 2, "[ Esc ] Quit ");
        }

        // highlight the button hit
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

        // win or bust announcements
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

        // tool for writing to a specific location of the console
        public void At(int x, int y, string s)
        {
            var ox = Console.CursorLeft;
            var oy = Console.CursorTop;

            Console.SetCursorPosition(x, y);
            Console.Write(s);

            Console.SetCursorPosition(ox, oy);
        }

        // currently unused, prints the entire contents of the prepared deck
        public void PrintDeck(List<Card> deck)
        {
            foreach (Card card in deck)
                Console.WriteLine(card.ToString());
        }

        #endregion
    }
}
