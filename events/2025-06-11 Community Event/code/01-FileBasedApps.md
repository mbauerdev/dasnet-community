Microsoft Docs:
https://devblogs.microsoft.com/dotnet/announcing-dotnet-run-app/

# Demo: Hello World

Create file `app.cs`:
```csharp
Console.WriteLine("🏆");
``` 

Run:
```bash
dotnet run app.cs
```

# Demo: Hello World (with Main-method)

Change file `app.cs`:
```csharp
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🏆");
    }
}
```

Run:
```bash
dotnet run app.cs
```

Convert to project-based app:
```bash
dotnet project convert app.cs
``` 

# Demo: API

Create file `app.cs`:
```csharp
// Reference SDK
#:sdk Microsoft.NET.Sdk.Web

// Reference package(s)
#:package Microsoft.AspNetCore.OpenApi@10.*-*

// Code
var builder = WebApplication.CreateBuilder();

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapGet("/", () => "Hello, world!");
app.Run();
```

Run:
```bash
dotnet run app.cs
```

Convert to project-based app:
```bash
dotnet project convert app.cs
``` 