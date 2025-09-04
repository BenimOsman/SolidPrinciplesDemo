namespace SolidPrinciplesDemo
{
    public class EmailNotification : INotificationService
    {
        public void Notify(string message)
        {
            System.Console.WriteLine($"Email sent: {message}");
        }
    }
}