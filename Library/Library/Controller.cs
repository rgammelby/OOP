using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Controller
    {
        View GUI = new View();
        Model m = new Model();

        // initializes books and starts program
        public void Start()
        {
            m.InitializeBooks();
            MainMenu();
        }

        #region Main Menu

        // displays menu and continues with user input
        public void MainMenu()
        {
            GUI.Menu();
            Selection();
        }

        // menu input
        public void Selection()
        {
            var selection = GUI.Input();

            switch (selection)
            {
                case ConsoleKey.D1:
                    // borrow a book
                    Borrow();
                    break;

                case ConsoleKey.D2:
                    // see loaned books
                    CheckLoans();
                    break;

                case ConsoleKey.Escape:
                    // quit program
                    Environment.Exit(0);
                    break;
            }
        }

        #endregion

        // display loans and accept input
        public void CheckLoans()
        {
            GUI.PrintBorrowedBooks(m.GetLoans());
            GUI.CheckLoansMenu();

            while (true)
            {
                switch (GUI.Input())
                {
                    case ConsoleKey.Escape:
                        MainMenu();
                        break;

                    case ConsoleKey.D1:
                        Borrow();
                        break;

                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                }
            }           
        }

        // borrow book interface
        public void Borrow()
        {
            while (true)
            {
                GUI.PrintBooks(m.GetBooks());
                GUI.BorrowMenu();
                BookSelection();
                BorrowAgain();
            }
        }

        // display borrow again? screen & lets user choose
        public void BorrowAgain()
        {
            GUI.Continue();

            var selection = GUI.Input();

            if (selection != ConsoleKey.Escape)
                return;
            else
                MainMenu();
        }

        // lets the user choose which book to borrow (by number)
        public void BookSelection()
        {
            byte selection = 0;

            try
            {
                selection = GUI.ByteInput();
                var book = m.RemoveBookAtIndex(selection);
                
                m.AddBookToLoans(book);
                GUI.BorrowInfo(m.GetTopBookInStack());
            }
            catch
            {
                GUI.InputError();
            }
            return;
        }
    }
}
