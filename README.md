# Swagger-with-ASP.NET

### Notes

    Here is a simple .NET Core API with Swagger.

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

#### Viewing your API with Swagger

    -locate your localhost web address to view your site
        a) check your launchSettings.json which is inside you Properties folder
            "applicationUrl": "https://localhost:7059;http://localhost:5067",   <-- this is mine, yours will be different
        b) when you start your project with 'dotnet run'
            you can read the address in the info:
                info: Microsoft.Hosting.Lifetime[14]
                Now listening on: http://localhost:5067
    -To launch Swagger type:
        http://localhost:5067/swagger/index.html

##### Build and run the project:

    In the terminal, navigate to your project folder and run the following commands to build and run your .NET Web API project:

    >> cd YourProjectName
    >> dotnet build
    >> dotnet run

#### If downloading the Github repo

    Run "dotnet restore" to generate .vscode/obj/bin files...
