using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class View
    {
        #region Menus

        public void Menu()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the library. \n" +
                "[ 1 ] Borrow a book \n" +
                "[ 2 ] View borrowed books \n" +
                "[ Esc ] Exit program \n");
        }
        public void CheckLoansMenu()
        {
            Console.WriteLine("[ Esc ] Return to the main menu \n" +
                "[ 1 ] Borrow a book \n" +
                "[ Q ] Exit program \n");
        }

        public void Continue()
        {
            Console.WriteLine("Would you like to borrow another book? \n" +
                "Press any key to borrow another book. \n" +
                "Press Escape to return to the main menu. \n");
        }

        public void BorrowMenu()
        {
            Console.WriteLine("Which book would you like to borrow? \n" +
                "Input book number: \n");
        }

        #endregion

        #region User Input

        // accepts single key input
        public ConsoleKey Input()
        {
            var input = Console.ReadKey(true).Key;
            return input;
        }

        // accepts number input up to 255
        public byte ByteInput()
        {
            return byte.Parse(Console.ReadLine());
        }

        #endregion

        #region Print Book Information

        // prints all available books from the list
        public void PrintBooks(List<Book> books)
        {
            Console.Clear();
            
            var bookno = 0;

            foreach (Book book in books)
            {
                bookno++;

                Console.WriteLine($"Book # {bookno}");

                Console.WriteLine($"Title: {book.Title} \n" +
                    $"Author: {book.Author} \n" +
                    $"Genre: {book.Genre} \n" +
                    $"Number of pages: {book.Pages} \n" +
                    $"Released in {book.Year} \n");
            }
        }

        // prints all borrowed books from the stack
        public void PrintBorrowedBooks(Stack<Book> books)
        {
            Console.Clear();

            Console.WriteLine("Borrowed books: \n");

            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.Title} \n" +
                    $"Author: {book.Author} \n" +
                    $"Genre: {book.Genre} \n" +
                    $"Number of pages: {book.Pages} \n" +
                    $"Released in {book.Year} \n");
            }
        }

        // displays book title and author when user borrows a book
        public void BorrowInfo(Book book)
        {
            Console.WriteLine($"The book {book.Title} by {book.Author} has been added to your stack of borrowed books. \n");
        }

        #endregion

        #region Errors

        // plays if user input is unexpected (not a number)
        public void InputError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter the number of the book you would like to borrow! ");
            Console.ResetColor();
        }

        #endregion
    }
}
