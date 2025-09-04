using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    public class Professor : IBorrowable, IReservable
    {
        public void Borrow(Book book)
        {
            System.Console.WriteLine($"Professor borrows '{book.Title}'");
        }

        public void Reserve(Book book)
        {
            System.Console.WriteLine($"Professor reserves '{book.Title}'");
        }
    }
}
