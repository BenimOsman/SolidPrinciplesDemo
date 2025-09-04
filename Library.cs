namespace SolidPrinciplesDemo
{
    public class Library
    {
        private INotificationService _notificationService;

        public Library(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void NotifyMember(string message)
        {
            _notificationService.Notify(message);
        }
    }
}