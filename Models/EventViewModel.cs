namespace VLMS.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }  // Add this line
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
