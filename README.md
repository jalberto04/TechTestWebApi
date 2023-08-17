# TECH STACK
* .NET Core 6.0
* Entity Framework Core
* SQLite 6.0

# Setup
  - Making sure that the following packages are installed.
    `dotnet add package Microsoft.EntityFrameworkCore -v 6.0`
    `dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0`
    `dotnet add package Microsoft.EntityFrameworkCore.Tools -v 6.0`
    `dotnet add package Microsoft.EntityFrameworkCore.SQLite -v 6.0`
    `dotnet add package Microsoft.EntityFrameworkCore.SQLite.Design -v 6.0`
    `dotnet add package CsvHelper`

# DB Migrations
  1. copy and run the code below (All migration will be put in Migrations folder)
    `dotnet ef migrations add m1 -o Migrations`
      doing this will insert all available data seed for testing
  2. Run `dotnet ef database update` to complete the database migrations.

# Run Instructions
  1. run the development command `dotnet watch` or `dotnet run`

