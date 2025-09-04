namespace SolidPrinciplesDemo
{
    public abstract class LibraryMember
    {
        public string Name { get; set; }
        public abstract int BorrowLimit();
    }

    public class RegularMember : LibraryMember
    {
        public override int BorrowLimit() => 5;
    }

    public class PremiumMember : LibraryMember
    {
        public override int BorrowLimit() => 10;
    }
}