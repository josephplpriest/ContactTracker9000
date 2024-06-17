using System.Text.Json;
using ContactTracker.Domain.Contacts;
using ContactTracker.Domain.Events;

namespace ContactTracker.Domain.Tests;

public class EventTests
{
    [Fact]
    public void CanCreateEvent()
    {

        var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scaffold/TestEvent.json");
        var json = File.ReadAllText(filePath);
        
        var e = JsonSerializer.Deserialize<Event>(json);

    }
}

public class ContactTests
{
    [Fact]
    public void CanCreateContact()
    {
        var contactJson = File.ReadAllText("Scaffold/TestContact.json");

        var c = JsonSerializer.Deserialize<Contact>(contactJson);

    }
}

// Test Ideas

/*
No overlapping events?
Suggesting existing interests based on string similarity?
Most recent event in the past vs upcoming events
Selection by interest


*/

