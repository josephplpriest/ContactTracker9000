using ContactTracker.Domain.Contacts;

namespace ContactTracker.Domain.Events
{
    public record CreateEventDto(
        DateTime? Date,
        string? Location,
        string Description,
        string Type,
        TimeSpan? Duration,
        string? PreNotes,
        string? PostNotes,
        bool ThankYouSent,
        bool HasOccurred,
        bool InPerson,
        Contact? Contact
    );

    public record UpdateEventDto(
        Guid EventId,
        DateTime? Date,
        string? Location,
        string Description,
        string Type,
        TimeSpan? Duration,
        string? PreNotes,
        string? PostNotes,
        bool ThankYouSent,
        bool HasOccurred,
        bool InPerson,
        Contact? Contact
    );

    public record DeleteEventDto(
        Guid EventId,
        Guid ContactId
    );


}