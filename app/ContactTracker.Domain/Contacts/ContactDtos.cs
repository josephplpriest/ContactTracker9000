namespace ContactTracker.Domain.Contacts
{
    public record CreateContactDto(
        string? FirstName,
        string? LastName,
        string PreferredName,
        string? Occupation,
        List<string> Interests,
        Relationship Relationship
    );

    public record UpdateContactDto(
        Guid ContactId,
        string? FirstName,
        string? LastName,
        string PreferredName,
        string? Occupation,
        List<string> Interests,
        Relationship Relationship
    );

    public record DeleteContactDto(
        Guid ContactId,
        Guid EventId
    );
}