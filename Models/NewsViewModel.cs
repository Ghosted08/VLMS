namespace VLMS.Models
{
    public class NewsViewModel
    {
        public int Id { get; set; }  // Add this line
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
