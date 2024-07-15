// using System;
// using System.Linq;
// using System.Text.Json;
// using ContactTracker.Domain.Contacts;
// using ContactTracker.Domain.Events;

// var contactJson = File.ReadAllText("TestContact.json");

// var c = JsonSerializer.Deserialize<Contact>(contactJson);

// var eventJson = File.ReadAllText("TestEvent.json");

// var e = JsonSerializer.Deserialize<Event>(eventJson);

// using var db = new ContactTrackerContext();

// Console.WriteLine("Inserting a new event");
// db.Add(e);
// db.SaveChanges();

// // Read
// Console.WriteLine("Querying for an event");
// var ev = db.Events
//     .OrderBy(e => e.Type)
//     .First();

// Console.WriteLine($"{JsonSerializer.Serialize(ev)}");