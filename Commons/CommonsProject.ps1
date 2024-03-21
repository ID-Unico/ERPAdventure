dotnet new webapi -n CommonsAPI
dotnet new classlib -n CommonsApp
dotnet new classlib -n CommonsCore
dotnet new classlib -n CommonsData

dotnet new sln -n ScriptSolution

dotnet sln .\ScriptSolution.sln add .\CommonsAPI\
dotnet sln .\ScriptSolution.sln add .\CommonsApp\
dotnet sln .\ScriptSolution.sln add .\CommonsCore\
dotnet sln .\ScriptSolution.sln add .\CommonsData\

dotnet add .\CommonsAPI\CommonsAPI.csproj reference .\CommonsApp\CommonsApp.csproj
dotnet add .\CommonsApp\CommonsApp.csproj reference .\CommonsData\CommonsData.csproj
dotnet add .\CommonsApp\CommonsApp.csproj reference .\CommonsCore\CommonsCore.csproj
dotnet add .\CommonsData\CommonsData.csproj reference .\CommonsCore\CommonsCore.csproj

dotnet add .\CommonsCore\CommonsCore.csproj package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.3
dotnet add .\CommonsData\CommonsData.csproj package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.3
dotnet add .\CommonsApp\CommonsApp.csproj package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.3

dotnet add .\CommonsAPI\CommonsAPI.csproj package Microsoft.EntityFrameworkCore --version 8.0.3
dotnet add .\CommonsApp\CommonsApp.csproj package Microsoft.EntityFrameworkCore --version 8.0.3
dotnet add .\CommonsCore\CommonsCore.csproj package Microsoft.EntityFrameworkCore --version 8.0.3
dotnet add .\CommonsData\CommonsData.csproj package Microsoft.EntityFrameworkCore --version 8.0.3

dotnet add .\CommonsAPI\CommonsAPI.csproj package Microsoft.EntityFrameworkCore.Design --version 8.0.3
dotnet add .\CommonsApp\CommonsApp.csproj package Microsoft.EntityFrameworkCore.Design --version 8.0.3
dotnet add .\CommonsCore\CommonsCore.csproj package Microsoft.EntityFrameworkCore.Design --version 8.0.3
dotnet add .\CommonsData\CommonsData.csproj package Microsoft.EntityFrameworkCore.Design --version 8.0.3

dotnet add .\CommonsAPI\CommonsAPI.csproj package Microsoft.EntityFrameworkCore.Tools --version 8.0.3
dotnet add .\CommonsApp\CommonsApp.csproj package Microsoft.EntityFrameworkCore.Tools --version 8.0.3
dotnet add .\CommonsCore\CommonsCore.csproj package Microsoft.EntityFrameworkCore.Tools --version 8.0.3
dotnet add .\CommonsData\CommonsData.csproj package Microsoft.EntityFrameworkCore.Tools --version 8.0.3

dotnet add .\CommonsApp\CommonsApp.csproj package Microsoft.Extensions.Identity.Core --version 8.0.3







