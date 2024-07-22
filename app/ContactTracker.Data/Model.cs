using Microsoft.EntityFrameworkCore;
using ContactTracker.Domain.Contacts;
using ContactTracker.Domain.Events;

public class ContactTrackerContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Event> Events { get; set; }

    // Optional: If you want to use a specific DbPath
    public string DbPath { get; }

    public ContactTrackerContext(DbContextOptions<ContactTrackerContext> options)
        : base(options)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Combine(path, "ContactTracker.db");
    }

}
