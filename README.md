# ContactTracker9000
An ASP.NET Core application for tracking information related to friends, family and professional contacts
```
├── app
│   ├── BlazorApp
│   │   ├── appsettings.Development.json
│   │   ├── appsettings.json
│   │   ├── BlazorApp.csproj
│   │   ├── Components
│   │   │   ├── App.razor
│   │   │   ├── _Imports.razor
│   │   │   ├── Layout
│   │   │   │   ├── MainLayout.razor
│   │   │   │   ├── MainLayout.razor.css
│   │   │   │   ├── NavMenu.razor
│   │   │   │   └── NavMenu.razor.css
│   │   │   ├── Pages
│   │   │   │   ├── Contacts.razor
│   │   │   │   ├── Error.razor
│   │   │   │   ├── Home.razor
│   │   │   │   └── Weather.razor
│   │   │   └── Routes.razor
│   │   ├── DatabaseUtility.cs
│   │   ├── Program.cs
│   │   ├── Properties
│   │   │   └── launchSettings.json
│   │   ├── SeedDatabase.cs
│   │   └── wwwroot
│   │       ├── app.css
│   │       ├── bootstrap
│   │       │   ├── bootstrap.min.css
│   │       │   └── bootstrap.min.css.map
│   │       └── favicon.png
│   ├── ContactTracker.Data
│   │   ├── ContactTracker.Data.csproj
│   │   ├── GetDatabasePath.cs
│   │   ├── Migrations
│   │   │   ├── 20240723134153_InitialCreate.cs
│   │   │   ├── 20240723134153_InitialCreate.Designer.cs
│   │   │   └── ContactTrackerContextModelSnapshot.cs
│   │   ├── Model.cs
│   │   ├── Program.cs
│   │   └── Repositories
│   │       ├── ContactRepository.cs
│   │       └── EventRepository.cs
│   ├── ContactTracker.Domain
│   │   ├── Contacts
│   │   │   ├── Contact.cs
│   │   │   ├── ContactDtos.cs
│   │   │   ├── ContactService.cs
│   │   │   └── IContactRepository.cs
│   │   ├── ContactTracker.Domain.csproj
│   │   ├── ContactTracker.Domain.sln
│   │   ├── Entity.cs
│   │   └── Events
│   │       ├── Event.cs
│   │       ├── EventDtos.cs
│   │       ├── EventService.cs
│   │       ├── EventType.cs
│   │       └── IEventRepository.cs
│   └── ContactTracker.Domain.Tests
│       ├── ContactTracker.Domain.Tests.csproj
│       ├── ContactTracker.Domain.Tests.sln
│       ├── DomainTests.cs
│       └── Scaffold
│           ├── TestContact.json
│           └── TestEvent.json
├── ContactTracker9000.sln
└── README.md
```