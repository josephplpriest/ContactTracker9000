using ContactTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

public static class DatabaseUtility
{
    public static async Task EnsureDbCreatedAndSeedWithCountOfAsync(
        ContactTrackerContext context, 
        int count, 
        CancellationToken cancellationToken = default)
    {
        // var factory = new LoggerFactory();
        // var builder = new DbContextOptionsBuilder<ContactTrackerContext>()
        //     .UseLoggerFactory(factory);

        var factory = LoggerFactory.Create(builder =>
        {
        builder
        .AddFilter((category, level) => 
            category == DbLoggerCategory.Database.Command.Name && 
            level == LogLevel.Information)
        .AddConsole();
        });

        if (await context.Database.EnsureCreatedAsync(cancellationToken))
        {
            var seed = new SeedContacts();
            await seed.SeedDatabaseWithContactCountOfAsync(context, count, cancellationToken);
        }
    }
}