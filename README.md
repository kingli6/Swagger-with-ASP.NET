# Swagger-with-ASP.NET

### Notes

##### Build and Run the Project:

    In the terminal, navigate to your project folder and run the following commands to build and run your .NET Web API project:

    cd YourProjectName
    dotnet build
    dotnet run

##### Steps to build project

    # step 1 Installing project
        dotnet new sln -n 'slnfileName'
        dotnet new webapi -n 'projectname'
        dotnet sln add 'projectname'

    # Step 2 Creating DbContext and Model
        -Creating DbContext file
        -Creating the Note.cs model file

    # Step 3 Creating migrations,
        -Sqlite Connextion string in appsettings.Dev...json,
        -Including it in builder.Services

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("Sqlite")));

    # Step 4 Creating database and migrations
        >> dotnet ef migrations add InitialCreate -o "Data/Migrations"
        >> dotnet ef database update

    # Step 5 Creating Repo/Services and building the CRUD functions in the Note controller
        -declaring the service files in program.cs

            builder.Services.AddScoped<INotesServices, NotesServices>();
