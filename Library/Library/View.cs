using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class View
    {
        public ConsoleKey Input()
        {
            var input = Console.ReadKey(true).Key;
            return input;
        }

        public void Menu()
        {
            Console.WriteLine("Welcome to the library. \n" +
                "[ 1 ] Borrow a book \n" +
                "[ Esc ] Exit program \n");
        }

        public void BorrowMenu()
        {
            Console.WriteLine("Which book would you like to borrow? \n" +
                "Input book number: \n");
        }

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

        public void PrintBorrowedBooks(Stack<Book> books)
        {
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

        public void BorrowInfo(Book book)
        {
            Console.WriteLine($"The book {book.Title} by {book.Author} has been added to your stack of borrowed books. \n");
        }
    }
}
