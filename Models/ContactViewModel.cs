namespace VLMS.Models
{
    public class ContactViewModel
    {
        public int Id { get; set; } // Ensure there is an Id property for entity tracking
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
