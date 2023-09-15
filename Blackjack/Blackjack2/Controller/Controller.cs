using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    public class Controller
    {
        // universal news
        Deck d = new Deck();
        Player p = new Player();
        Dealer dr = new Dealer();
        View GUI = new View();

        // starting hand size
        const int STARTING_CARDS = 2;

        // game controlling bool
        bool game;

        #region Game Basics

        // initializes and starts the game
        public void Start()
        {
            while (true)
            {
                game = true;
                InitializeGame();
                Game();
            }
        }

        // main game loop
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

        // takes player input
        public void PlayerAction()
        {
            var selection = Console.ReadKey(true).Key;

            switch (selection)
            {
                // deals 1 new card to the player
                case ConsoleKey.D1:
                    GUI.HighlightHitMe();
                    DrawPlayerCard();
                    break;

                // player stands, dealer takes action
                case ConsoleKey.D2:
                    GUI.HighlightStand();
                    DealerAction();
                    break;

                // quit game
                case ConsoleKey.Escape:
                    GUI.HighlightQuit();
                    Environment.Exit(0);
                    break;
            }
        }

        //  chooses whether the dealer should draw more cards or hold on their current value
        public void DealerAction()
        {
            // if the dealer's hand has a value of < 16, and < the value of the player's hand, the dealer draws a card
            while (dr.Value < 16 && dr.Value < p.Value)
            {
                DrawDealerCard();
            }

            // if the dealer's hand has a value greater than 21, the dealer loses
            if (dr.Value > 21)
            {
                GUI.DealerBust(dr);
                GameEnd();
            }
            else
                // player and dealer's hands are compared
                Showdown();
        }

        // cleans up and refills the deck
        public void GameEnd()
        {
            d.EmptyDeck();
            p.EmptyHand();
            dr.EmptyHand();
            d.FillDeck();
            TryAgain();
            game = false;
        }

        // lets the player go again or quit the game upon completion
        public void TryAgain()
        {
            GUI.TryAgain();

            var selection = Console.ReadKey(true).Key;

            if (selection == ConsoleKey.Escape)
                Environment.Exit(0);
            else
                return;
        }

        // if the player is dealt 21, they have blackjack. if the value of the player's hand exceeds 21, they lose
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

        // player/dealer hand comparison
        public void Showdown()
        {
            // if the player's hand is of greater value than the dealer's at showdown, the player wins
            if (p.Value > dr.Value)
                GUI.ShowdownPlayerWin(p, dr);

            // if the player's value is equal to or less than the dealer's at showdown, the player loses
            else if (p.Value <= dr.Value)
                GUI.ShowdownPlayerBust(p, dr);

            GameEnd();
        }

        // player and dealer get their cards
        public void InitializeGame()
        {
            for (int i = 0; i < STARTING_CARDS; i++)
            {
                DrawPlayerCard();
                DrawDealerCard();
            }

            // checks if player or dealer has an ace in their starting hand
            p.AceCheck();
            dr.AceCheck();
        }

        // draws a card for the player
        public void DrawPlayerCard()
        {
            p.DrawCard(d.DrawCard(d.Cards));
        }

        // draws a card for the dealer
        public void DrawDealerCard()
        {
            dr.DrawCard(d.DrawCard(d.Cards));
        }

        #endregion
    }
}