# Winer - simple wine app, loading entities from a db and returns them

## Create simple web api project

> Start from within the Winer directory (ignore the paket files)

- Create a new project using dotnet cli:
```bash
dotnet new webapi -o src/web
```
This creates a template web api project inside the web directory!
Have a look at the created files. Most interesting is `Startup.cs` and the controller in the Controllers directory. The former is where the application is configured, we will add some more features from this file later. The template controller is simple REST controller returing dummy values.

- To run the project, go inside the web folder and run:
```bash
dotnet run
```
Try the api by browsing http://localhost:5000/api/values, you should see an array of values returned.

- Add the project to the solution:
```bash
dotnet sln add src/web/web.csproj
```
This will allow running dotnet cli commands from the application root folder later.

## Add repository service to the api

- Create a new controller called WineController
- Create a RepositoryService and regsiter on the container + as dependency in the controller
- Serve static values throug the new api

## Serve static files 
- Create index.html and main.js in a wwwroot folder
- Add static files and default files features
- Call the api through javascript dispalying the data

