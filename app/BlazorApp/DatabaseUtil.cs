using ContactTracker.Data;
using Microsoft.EntityFrameworkCore;

public static class DatabaseUtility
{
    // Method to seed the database. Should not be used in production.
    // options: The configured options.
    // count: The number of contacts to seed.
    public static async Task EnsureDbCreatedAndSeedWithCountOfAsync(DbContextOptions<DbContext> options, int count)
    {
        // Empty to avoid logging while inserting (otherwise will flood console).
        var factory = new LoggerFactory();
        var builder = new DbContextOptionsBuilder<DbContext>(options)
            .UseLoggerFactory(factory);

        using var context = new DbContext(builder.Options);
        // Result is true if the database had to be created.
        if (await context.Database.EnsureCreatedAsync())
        {
            var seed = new SeedContacts();
            await seed.SeedDatabaseWithContactCountOfAsync(context, count);
        }
    }
}
