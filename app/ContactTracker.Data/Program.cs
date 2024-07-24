using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace ContactTracker.Data
{
public class ContactTrackerContextFactory : IDesignTimeDbContextFactory<ContactTrackerContext>
{
    public ContactTrackerContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ContactTrackerContext>();
        var dbPath = DatabaseHelpers.GetDatabasePath();
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
        return new ContactTrackerContext(optionsBuilder.Options);
    }
}
}