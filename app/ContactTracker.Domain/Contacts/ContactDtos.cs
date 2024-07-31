namespace ContactTracker.Domain.Contacts
{
    public record CreateContactDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string PreferredName { get; set; } = string.Empty;
        public string? Occupation { get; set; }
        public List<string> Interests { get; set; } = new List<string>();
        public Relationships Relationship { get; set; }
    }

    public record UpdateContactDto
    {
        public Guid ContactId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string PreferredName { get; set; } = string.Empty;
        public string? Occupation { get; set; }
        public List<string> Interests { get; set; } = new List<string>();
        public Relationships Relationship { get; set; }
    }

    public record DeleteContactDto
    {
        public Guid ContactId { get; set; }
        public Guid EventId { get; set; }
    }
}