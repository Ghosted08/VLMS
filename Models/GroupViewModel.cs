namespace VLMS.Models
{
    public class GroupViewModel
    {
        public int Id { get; set; }  // Add this line
        public string Name { get; set; }
        public string Description { get; set; }
        public int MemberCount { get; set; }
    }
}
