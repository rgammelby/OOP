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

        bool game;

        #region Game Basics

        public void Start()
        {
            while (true)
            {
                game = true;
                InitializeGame();
                Game();
                Console.Clear();
            }
        }


        public void Game()
        {
            while (game)
            {
                GUI.Controls();
                GUI.UpdateScreen(p, dr);
                GUI.PrintPlayerHandValue(p);
                CheckValues();

                if (game)
                    PlayerAction();
            }
        }

        #endregion

        #region Mechanics

        public void PlayerAction()
        {
            var selection = Console.ReadKey(true).Key;

            switch (selection)
            {
                case ConsoleKey.D1:
                    GUI.HighlightHitMe();
                    DrawPlayerCard();
                    break;

                case ConsoleKey.D2:
                    GUI.HighlightStand();
                    DealerAction();
                    break;

                case ConsoleKey.Escape:
                    GUI.HighlightQuit();
                    Environment.Exit(0);
                    break;
            }
        }

        public void DealerAction()
        {
            while (dr.Value < 16 && dr.Value < p.Value)
            {
                DrawDealerCard();
            }

            if (dr.Value > 21)
            {
                GUI.DealerBust(dr);
                GameEnd();
            }
            else
                Showdown();
        }

        public void GameEnd()
        {
            d.EmptyDeck();
            p.EmptyHand();
            dr.EmptyHand();
            d.FillDeck();
            TryAgain();
            game = false;
        }

        public void TryAgain()
        {
            GUI.TryAgain();

            var selection = Console.ReadKey(true).Key;

            if (selection == ConsoleKey.Escape)
                Environment.Exit(0);
            else
                return;
        }

        public void CheckValues()
        {
            if (p.Value == 21)
            {
                GUI.Blackjack();
                GameEnd();
            }
            else if (p.Value > 21)
            {
                GUI.Bust();
                GameEnd();
            }
        }

        public void Showdown()
        {
            if (p.Value > dr.Value)
                GUI.ShowdownPlayerWin(p, dr);
            else if (p.Value <= dr.Value)
                GUI.ShowdownPlayerBust(p, dr);

            GameEnd();
        }

        public void InitializeGame()
        {
            for (int i = 0; i < STARTING_CARDS; i++)
            {
                DrawPlayerCard();
                DrawDealerCard();
            }

            p.AceCheck();
        }

        public void DrawPlayerCard()
        {
            p.DrawCard(d.DrawCard(d.Cards));
        }

        public void DrawDealerCard()
        {
            dr.DrawCard(d.DrawCard(d.Cards));
        }

        #endregion
    }
}