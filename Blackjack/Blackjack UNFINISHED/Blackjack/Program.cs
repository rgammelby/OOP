using Blackjack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // allows the console to print proper suit symbols
            Console.OutputEncoding = Encoding.UTF8;


            Blackjack.Controller.Controller c = new Blackjack.Controller.Controller();
            c.Start();
        }

        public Deck GetDeck()
        {
            Deck d = new Deck();
            d.FillDeck();

            return d;
        }
    }
}