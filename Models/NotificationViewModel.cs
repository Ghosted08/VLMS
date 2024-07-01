namespace VLMS.Models
{
    public class NotificationViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }  // Add this line
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
