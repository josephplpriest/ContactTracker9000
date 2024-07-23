using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContactTracker.Domain.Contacts;
using ContactTracker.Domain.Events;

public class ContactTrackerContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Event> Events { get; set; }


    public ContactTrackerContext(DbContextOptions<ContactTrackerContext> options)
        : base(options)
    {
    }

}