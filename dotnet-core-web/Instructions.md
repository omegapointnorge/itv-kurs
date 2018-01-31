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

(Try running `dotnet watch run` instead. This command will run the program and re-compile everytime change change anything in the project)

Try the api by browsing http://localhost:5000/api/values, you should see an array of values returned.

- Add the project to the solution:
```bash
dotnet sln add src/web/web.csproj
```
This will allow running dotnet cli commands from the application root folder later.

## Extending the API - registering dependncies on the _inversion of controll_ container
> Inversion of controll/dependency injection is an important design pattern, much used in software development. We will see an simple case of this now. If this is completely new, you can read a bit more here [here](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)

- Create a new api controller called WineController, similar to the one created automatically. Only include a simple `GET`-action. Start by having it return a static value. Make sure it works, by browsing to it.

- Create an interface called `IWineInfoRepository`, containing a method `WineInfo GetWineInfo(int id)`. Also create the `WineInfo` class, containing the properties: name, vintage and country.

- This interface will be the abstraction which the new wine controller depend upon. Create a new field of type `IWineInfoRepository` and set it throug the constructor of the WineController. This way we simply specify that the class needs some kind of wine info repository, but not specifically which implementation.

```csharp
private IWineInfoRepository _wineRepo;

public WineController(IWineInfoRepository wineRepo)
{
    _wineRepo = wineRepo;
}
```

- Now, replace the static value returned in the controller action and use the method specified in the repository.

```csharp
[HttpGet("{id}")]
public string Get(int id)
{
    return _wineRepo.GetWineInfo(id);
}
```

- This will not work as the dependency will not be met. We will fix this by registering an implementation on the container. Have a look at the `Startup.cs`-file. This is where the application is configured. In the `ConfigureServices`-method we can register our own classes which will be aviable on the container.

- Create an implementation of the interface, returning some dummy values. Then register it as an singleton in `Startup.cs`.

```csharp
services.AddSingleton<IWineInfoRepository, DummyWineInfoRepository>();
```

- Now the api should work again, returning the dummy values.


## Additional tasks
 > A logical next step could be to create an actual implementation of the info repository, e.g. by reading a file.

- A data file containing wine information from vinmonopolet.no is provided (produkter.csv). Create a new implementation of the IWineInfoRepository that reads the file, parses it, and serves results from it when asked for it. Use "varenummer" as id when calling the method. Remember to replace the dummy implementation in the Startup.cs-file.

Usefull functions you can use:
 - File.ReadAllLines(string pathToFile)
 - someString.Split(';')
 - 
