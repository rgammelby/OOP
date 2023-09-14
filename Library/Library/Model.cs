using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Model
    {
        List<Book> books = new List<Book>();
        Stack<Book> loans = new Stack<Book>();

        public List<Book> GetBooks() { return books; }

        public Stack<Book> GetLoans() { return loans; }

        public void InitializeBooks()
        {
            // author, page count, title, genre (0 -> 4)
            books.Add(new Book("Frank Herbert", 412, "Dune", 0, 1965));
            books.Add(new Book("J. R. R. Tolkien", 304, "The Hobbit", 1, 1939));
            books.Add(new Book("Stephen Hawking", 256, "A Brief History of Time", 2, 1988));
            books.Add(new Book("Alice Waters", 416, "The Art of Simple Food", 3, 2007));
            books.Add(new Book("Anne Carson", 416, "If Not, Winter: Fragments of Sappho", 4, 2002));
        }

        public Book RemoveBookAtIndex(short index)
        {
            index -= 1;

            var book = books[index];
            books.RemoveAt(index);

            return book;
        }

        public void AddBookToLoans(Book book)
        {
            loans.Push(book);
        }
    }
}
