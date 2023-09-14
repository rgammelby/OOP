using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string _author;
        private short _pages;
        private string _title;
        private string _genre;
        private short _year;

        enum Genres { SciFi, Fantasy, Nonfiction, Cookbook, Poetry }

        public string Author
        {
            get { return _author; }
            private set { _author = value; }
        }

        public short Pages
        {
            get { return _pages; }
            private set { _pages = value; }
        }

        public string Title
        {
            get { return _title; }
            private set { _title = value; }
        }

        public string Genre
        {
            get { return _genre; }
            private set { _genre = value; }
        }

        public short Year
        {
            get { return _year; }
            private set { _year = value; }
        }

        public Book(string author, short pages, string title, byte genre, short year)
        {
            _author = author;
            _pages = pages;
            _title = title;
            _genre = ((Genres)genre).ToString();
            _year = year;
        }
    }
}
