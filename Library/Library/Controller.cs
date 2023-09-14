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

        public void Start()
        {
            m.InitializeBooks();

            GUI.Menu();
            Selection();
        }

        public void Selection()
        {
            var selection = GUI.Input();

            switch (selection)
            {
                case ConsoleKey.D1:
                    Borrow();
                    break;

                case ConsoleKey.D2:
                    // view loaned books
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }

        public void Borrow()
        {
            GUI.PrintBooks(m.GetBooks());
            GUI.BorrowMenu();
            BookSelection();
        }

        public void BookSelection()
        {
            var selection = short.Parse(GUI.Input());

            var book = m.RemoveBookAtIndex(selection);

            GUI.BorrowInfo(book);

            m.AddBookToLoans(book);
        }
    }
}
