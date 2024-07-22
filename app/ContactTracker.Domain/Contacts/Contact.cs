namespace ContactTracker.Domain.Contacts
{
    public class Contact : Entity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public required string PreferredName { get; set; }
        public string? Occupation { get; set; }
        public List<string>? Interests { get; set; } = new List<string>();
        public Relationships? Relationship { get; set; }
    }

    public enum Relationships
    {
        Family,
        Friend,
        Professional
    }
}