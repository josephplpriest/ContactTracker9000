

namespace ContactTracker.Domain.Contacts
{
    public class Contact : Entity
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        
        public required string PreferredName { get; set; }

        public string? Occupation { get; set; }

        public List<string>? Interests { get; set; } = [];

        public Relationship? Relationship { get; set; } 
    }
    
}