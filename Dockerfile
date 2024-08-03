FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

WORKDIR /app

COPY . ./

RUN dotnet restore ContactTracker9000.sln

RUN dotnet publish -c Release -o output

FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

COPY --from=build-env /app/output .

ENTRYPOINT ["dotnet", "BlazorApp.dll"]