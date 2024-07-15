using ContactTracker.Domain;

namespace ContactTracker.Domain.Events
{
    public record CreateEventDto(
        DateTime? Date,
        string? Location,
        string Description,
        EventType Type,
        TimeSpan? Duration,
        string? PreNotes,
        string? PostNotes,
        bool InPerson,
        Guid? ContactId,
        ContactTracker.Domain.Contacts.Contact? Contact
    );

    public record UpdateEventDto(
        Guid EventId,
        DateTime? Date,
        string? Location,
        string Description,
        EventType Type,
        TimeSpan? Duration,
        string? PreNotes,
        string? PostNotes,
        bool InPerson,
        Guid? ContactId,
        ContactTracker.Domain.Contacts.Contact? Contact,
        bool ThankYouSent,
        bool HasOccurred
    );

    public record DeleteEventDto(
        Guid EventId
    );
}