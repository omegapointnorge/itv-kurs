# Winer - simple wine app, loading entities from a db and returns them, all ran using docker

## Create a web project

> Start from within the Winer directory

- Create a new project using dotnet cli:
```bash
dotnet new webapi -o src/web
```
This creates a template web api project inside the web directory!
- Go inside the web-directory and run the project:
```bash
dotnet run
```
Try the api by browsing http://localhost:5000/api/values, you should see an array of values returned.

- Add the project to the solution:
```bash
dotnet sln add src/web/web.csproj
```