# ASP.NET Core Web API Clean Architecture Template
This is a very basic clean architecture template using ASP.NET Core Web API.

## Template Setup

Clone the project and restore all dependencies. This should be done automatically by Visual Studio upon opening of the solution. Otherwise, if it doesn't restore the dependencies, run the following in the Package Manager console.

```
dotnet restore
```

## Database Setup

The template is using code-first approach. Thus, it will automatically create a database (if it does not exist yet) and run the migrations to the target database connection found in the appsettings.json. To update the database, run the following in the Package Manager console.

```
update-database
```

## Contributing

This is a work in progress template. This is setup to be as minimal as possible. Any suggestions and reccomendations are very welcome. Please create an issue directly or reach out to me.
