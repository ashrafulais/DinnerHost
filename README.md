## .NET Project using Clean architecture with DDD principles

### Clean Architecture Layers

- Presentation
  - API
  - Contracts
- Infrastructure
- Application
- Domain

### Commands
- `dotnet new sln -o DinnerHost`
- `cd DinnerHost/`
- `dotnet new webapi -o DinnerHost.API`
- `dotnet new classlib -o DinnerHost.Contracts`
- `dotnet new classlib -o DinnerHost.Infrastructure`
- `dotnet new classlib -o DinnerHost.Application`
- `dotnet new classlib -o DinnerHost.Domain`
- `dotnet sln add $(ls -r **/*.csproj)`
- `dotnet add DinnerHost.API/ reference DinnerHost.Contracts/ DinnerHost.Application/`
- `dotnet add DinnerHost.Infrastructure/ reference DinnerHost.Application/`
- `dotnet add DinnerHost.Application/ reference DinnerHost.Domain/`
- Theoritically infra is independent from the API. But make infra reachable to API project to register it's own dependencies: `dotnet add DinnerHost.API/ reference DinnerHost.Infrastructure/`
- Remove proj reference from infra like this: `dotnet remove DinnerHost.Infrastructure/ reference DinnerHost.API/DinnerHost.API.csproj` 
- Build the solution: `dotnet build`
- Run the project: `dotnet run --project DinnerHost.API`
- Run & Hot reload: `dotnet watch run --project DinnerHost.API`

- Dependency injection package `dotnet add DinnerHost.Application/ package Microsoft.Extensions.DependencyInjection.Abstractions`
- `dotnet add DinnerHost.Infrastructure/ package Microsoft.Extensions.DependencyInjection.Abstractions`

- cmd dommand to generate file tree: `tree /f /a > tree.txt`

- Add JWT extension `dotnet add DinnerHost.Infrastructure/ package System.IdentityModel.Tokens.Jwt`
- Add extension `dotnet add DinnerHost.Infrastructure/ package Microsoft.Extensions.Configuration`
- Add extension `dotnet add DinnerHost.Infrastructure/ package Microsoft.Extensions.Options.ConfigurationExtensions`

- Init user secrets: `dotnet user-secrets init  --project DinnerHost.API`
- Set the secret `dotnet user-secrets set --project DinnerHost.API "JwtSettings:Secret" "super-secret-key-from-user-secrets"`
- List the secrets: `dotnet user-secrets list --project DinnerHost.API`
  
- Add ErrorOr package: `dotnet add DinnerHost.Domain/ package ErrorOr`
- Add ErrorOr package: `dotnet add DinnerHost.Application/ package ErrorOr`
- Add ErrorOr package: `dotnet add DinnerHost.API/ package ErrorOr`

### Visualize clean architecture
```
----------------------------------
Presentation ↓ | Infrastructure ↓ -> DB
----------------------------------
         Application ↓
----------------------------------
            Domain
----------------------------------
```

<!-- ![Visualize clean architecture](Docs/Clean-arch-visual.png)

![Different project types](Docs/Clean-arch-proj-types.png)

![Final result](Docs/Clean-Arch-Final-results.png) -->

### Extensions and accessibility
- REST Client vscode extension: to run the .http commands inside the file
- Add these 2 patterns to exclude the bin and obj folders from the visible files: `**/bin`, `**/obj`. Goto vscode settings > Files: Exxclude section under the workspace tab

- Transient objects are always different; a new instance is provided to every controller and every service.
- Scoped objects are the same within a request, but different across different requests.
- Singleton objects are the same for every object and every request. 


### 4 - Error Handling

1. Using a custom Middleware - `app.UseMiddleware<ErrorHandlingMiddleware>();`
2. Using a custom filer - On top of API or Method `[ErrorHandlingFilter]` or in the builder `builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());`
   1. Describe the error using RFC spec


### 5 - Flow control


