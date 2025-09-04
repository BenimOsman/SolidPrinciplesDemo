using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    public class BookRepository
    {
        public void Add(Book book)
        {
            // Simulate adding a book to a database
            System.Console.WriteLine($"Book added: {book.Title} by {book.Author}");
        }

        public Book Find(string title)
        {
            // Simulate finding a book (placeholder)
            return new Book { Title = title, Author = "Unknown" };
        }
    }
}
