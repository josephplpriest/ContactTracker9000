using ContactTracker.Domain.Contacts;

// Generates desired number of random contacts.
public class SeedContacts
{
    // Use these to make names.
    private readonly string[] _firstnames = new[] 
    {
        "Jordan",
        "Avery",
        "Taylor",
        "Morgan",
        "Casey",
        "Riley",
        "Quinn",
        "Skyla",
        "Sage",
        "Remy"
    };

    // Combined with things for last names.
    private readonly string[] _lastnames = new[]
    {
        "Smith", 
        "Johnson", 
        "Williams", 
        "Brown", 
        "Jones", 
        "Garcia", 
        "Miller", 
        "Davis", 
        "Rodriguez", 
        "Martinez"
    };

    private readonly string[] _nicknames = new[]
    {
        "Buddy", 
        "Ace", 
        "Lucky", 
        "Sunny", 
        "Red", 
        "Sparky", 
        "Champ", 
        "Scout", 
        "Rocky", 
        "Pepper"
    };

    private readonly string[] _interests = new[]
    {
        "pickleball",
        "programming",
        "reading",
        "hiking"
    };

    // Occupations
    private readonly string[] _occupation = new[]
    {
        "Doctor",
        "Software Engineer",
        "Lawyer"
    };

    // Picks a random item from a list.
    // list: A list of string to parse.
    private string RandomOne(string[] list)
    {
        var idx = Random.Shared.Next(list.Length - 1);

        return list[idx];
    }

    // Make a new contact.
    // Returns a random Contact instance.
    private Contact MakeContact()
    {
        var contact = new Contact
        {
            FirstName = RandomOne(_firstnames),
            LastName = RandomOne(_lastnames),
            PreferredName = RandomOne(_nicknames),
            Occupation = RandomOne(_occupation),
            Interests = [RandomOne(_interests), RandomOne(_interests)],
            Relationship = (Relationships)Random.Shared.Next(Enum.GetValues<Relationships>().Length)
        };

        return contact;
    }

    public async Task SeedDatabaseWithContactCountOfAsync(ContactTrackerContext context, int totalCount, CancellationToken cancellationToken = default)    {
        var count = 0;
        var currentCycle = 0;
        while (count < totalCount)
        {
            var list = new List<Contact>();
            while (currentCycle++ < 100 && count++ < totalCount)
            {
                list.Add(MakeContact());
            }
            if (list.Count > 0)
            {
                context.Contacts?.AddRange(list);
                await context.SaveChangesAsync();
            }
            currentCycle = 0;
        }
    }
}
