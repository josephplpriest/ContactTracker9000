using Microsoft.EntityFrameworkCore;
using ContactTracker.Domain.Contacts;
using ContactTracker.Domain.Events;
public class ApplicationDbContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Event> Events { get; set; }

    public string DbPath { get; }

    public ApplicationDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "ContactTracker.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

