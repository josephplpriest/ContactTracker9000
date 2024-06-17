

namespace ContactTracker.Domain.Contacts
{
    public class Contact : Entity
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        
        public required string PreferredName { get; set; }

        public string? Occupation { get; set; }

        public List<Interest>? Interests { get; set; } = [];

        public Relationship? Relationship { get; set; } 
    }

    public class Interest : Entity
    {
        public required string Name { get; set;}
    }

    
}