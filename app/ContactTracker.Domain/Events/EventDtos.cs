
namespace ContactTracker.Domain.Events
{
    public class CreateEventDto
    {
        public DateTime Date { get; set; }
        public string? Location { get; set; }
        public string Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public string? PreNotes { get; set; }
        public string? PostNotes { get; set; }
        public bool InPerson { get; set; }
        public Guid? ContactId { get; set; }
    }

    public class UpdateEventDto
    {
        public Guid EventId { get; set; }
        public DateTime Date { get; set; }
        public string? Location { get; set; }
        public string Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public string? PreNotes { get; set; }
        public string? PostNotes { get; set; }
        public bool InPerson { get; set; }
        public Guid? ContactId { get; set; }
        public bool ThankYouSent { get; set; }
        public bool HasOccurred { get; set; }
    }


    public class DeleteEventDto
    {
        public Guid EventId { get; set; }
    }
}