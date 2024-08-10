using ContactTracker.Domain;

namespace ContactTracker.Domain.Events
{

    public class Event : Entity
    {
        public DateTime Date { get; set; }
        public string? Location { get; set; }
        public required string Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public string? PreNotes { get; set; }
        public string? PostNotes { get; set; }
        public bool ThankYouSent { get; set; } = false;
        public bool HasOccurred { get; set; } = false;
        public bool InPerson { get; set; }
        public Guid? contactId { get; set; }
    }

}