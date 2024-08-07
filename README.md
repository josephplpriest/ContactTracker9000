
<img src="images/readme_header.jpeg" alt="drawing" width="750" height="200"/>

# ContactTracker9000
A Blazor C#/dotnet Server application for tracker information about friends, family and professional contacts.

![Passing Tests](https://github.com/josephplpriest/ContactTracker9000/actions/workflows/main.yml/badge.svg)
[![language](https://img.shields.io/badge/language-C%23-239120)](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/)
[![GitHub last commit](https://img.shields.io/github/last-commit/josephplpriest/ContactTracker9000)](#)


## Installation/Use:

### via .NET Local Install
```
# Clone the repository
git clone https://github.com/josephplpriest/ContactTracker9000

# Navigate to the project directory
cd ContactTracker9000

# Verify .NET SDK is installed
dotnet --version  # Check the installed version of .NET SDK

# Run via the terminal
dotnet watch --project app/ContactTracker.WebApp/ContactTracker.WebApp.csproj

# open http://localhost:5135    --> if not opened automatically
```

### via Docker

```
# Clone the repository
git clone https://github.com/josephplpriest/ContactTracker9000

# Navigate to the project directory
cd ContactTracker9000

# Run via docker
docker build . --tag contacttracker:latest && docker run -p 8080:8080 contacttracker:latest

# open http://localhost:8080    --> if not opened automatically

```

| Features | Description |
| --------- | ---------- |
|Clean design|3-Tier architecture separated into Domain, Data and Web projects|
|CI/CD Features|Github action workflow to run unit tests on push |
||Docker image to allow easy multi-arch deployment|
||Github action to deploy application on fly.io|
|Async methods|Restful async methods (create/list/update/delete)|
