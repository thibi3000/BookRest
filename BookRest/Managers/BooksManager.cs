using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary;

namespace BookRest.Managers
{
    public class BooksManager
    {
        private static readonly List<Book> Books = new List<Book>
        {
            new Book {ISBN13 = "1-235-156-153", Title = "kdfjd", Author = "kdfsj", PageNumber = 162},
            new Book {ISBN13 = "5-452-644-658", Title = "dsipk", Author = "dkfjs", PageNumber = 52}
        };

        public List<Book> GetAll()
        {
            return new List<Book>(Books);
        }

        public Book GetByIsbn(string ISBN)
        {
            return Books.Find(book => book.ISBN13 == ISBN);
        }

        public Book Add(Book BookToAdd)
        {
            Books.Add(BookToAdd);
            return BookToAdd;
        }

        public Book Delete(string ISBN)
        {
            Book book = Books.Find(book => book.ISBN13 == ISBN);
            if (book == null) 
            { 
                return null; 
            }
            Books.Remove(book);
            return book;
        }

        public Book Update(string ISBN, Book changes)
        {
            Book book = Books.Find(book => book.ISBN13 == ISBN);
            if (book == null)
            {
                return null;
            }
            book.Title = changes.Title;
            book.Author = changes.Author;
            book.PageNumber = changes.PageNumber;
            return book;
        }
    }
}
