using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    public class Student : IBorrowable
    {
        public void Borrow(Book book)
        {
            System.Console.WriteLine($"Student borrows '{book.Title}' by {book.Author}");
        }
    }
}
