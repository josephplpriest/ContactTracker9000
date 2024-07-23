using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class ContactTrackerContextFactory : IDesignTimeDbContextFactory<ContactTrackerContext>
{
    public ContactTrackerContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ContactTrackerContext>();
        optionsBuilder.UseSqlite("Data Source=ContactTracker.db");

        return new ContactTrackerContext(optionsBuilder.Options);
    }
}