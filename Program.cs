namespace SolidPrinciplesDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Book book = new Book { Title = "1984", Author = "George Orwell" };
            BookRepository repo = new BookRepository();
            repo.Add(book);

            LibraryMember member = new PremiumMember { Name = "Alice" };
            Console.WriteLine($"{member.Name} can borrow {member.BorrowLimit()} books.");

            Student student = new Student();
            Professor professor = new Professor();

            student.Borrow(book);
            professor.Borrow(book);
            professor.Reserve(book);

            INotificationService notification = new EmailNotification();
            Library library = new Library(notification);
            library.NotifyMember("Your reserved book is available.");
        }
    }
}