FROM mcr.microsoft.com/dotnet/core/sdk:8.0 as build-env

WORKDIR /app

COPY *.csproj ./

RUN dotnet restore

COPY . ./

RUN dotnet publish -c Release -o output

FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

COPY --from=build-env /app/output .

ENTRYPOINT ["dotnet", "BlazorApp.dll"]