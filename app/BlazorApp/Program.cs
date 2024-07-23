using BlazorApp.Components;
using ContactTracker.Domain.Contacts;
using ContactTracker.Domain.Events;
using ContactTracker.Data.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IContactService, ContactService>();

builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<IEventService, EventService>();

builder.Services.AddDbContext<ContactTrackerContext>(options =>
{
    var folder = Environment.SpecialFolder.LocalApplicationData;
    var path = Environment.GetFolderPath(folder);
    var dbPath = Path.Join(path, "ContactTracker.db");
    options.UseSqlite($"Data Source={dbPath}");
});


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// This section sets up and seeds the database. 
await using var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateAsyncScope();

var context = scope.ServiceProvider.GetRequiredService<ContactTrackerContext>();
await DatabaseUtility.EnsureDbCreatedAndSeedWithCountOfAsync(context, 30);

    

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
