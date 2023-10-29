# Blazor WebAssembly Full-Stack Demo

This is a .NET 7 Blazor WebAssembly Full-Stack demo project, showcasing the capabilities of Blazor WebAssembly for building interactive web applications. The project includes both frontend and backend components, demonstrating how to create a full-stack web application using .NET technologies.

## Overview

- **Frontend**: The front end of this application is built using Blazor WebAssembly, a modern web framework that allows you to write C# code to create interactive web applications that run in the browser. It leverages the power of WebAssembly to execute .NET code directly in the browser.

- **Backend**: The backend is powered by .NET 7, providing RESTful API endpoints for the frontend to communicate with. It demonstrates how to build a robust backend using the latest features of .NET.

## Features

- **Blazor Components**: Utilize Blazor components to create dynamic and reusable UI elements on the front end.

- **RESTful API**: Build a RESTful API using .NET to handle data requests and interactions between the frontend and backend.

- **Database Integration**: Optionally, integrate a database of your choice (e.g., SQL Server, SQLite) to store and retrieve data.

## Getting Started

To get started with this project, follow these steps:

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/Coder-IsiahJones/SimpleVideoGameLibrary.git
   ```

2. Navigate to the project directory:

   ```bash
   cd SimpleVideoGameLibrary
   ```

3. Open a terminal/command prompt in the project's root directory where the DbContext is located.

4. Ensure that you have Entity Framework Core tools installed. If not, you can install them globally:

   ```bash
   dotnet tool install --global dotnet-ef
   ```

5. Configure your database connection string in the `appsettings.json` or `appsettings.Development.json` file, depending on your environment.

   Example `appsettings.json`:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=Your_Server;Database=VideoGame;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true"
     }
   }
   ```

   Replace `YourServer`, `YourDatabase`, `YourUser`, and `YourPassword` with your actual database connection details.

6. Now, you can use the following Entity Framework Core commands to create the database and apply migrations:

   - Apply pending migrations to create the database schema:

     ```bash
     dotnet ef database update
     ```

   - If there are no migrations yet, create an initial migration:

     ```bash
     dotnet ef migrations add InitialCreate
     ```

     Replace "InitialCreate" with a descriptive name for your migration.

   - Apply the migration to create the database:

     ```bash
     dotnet ef database update
     ```

7. Your database should now be created and up to date with the latest schema.

8. Start your application and explore the functionality.

## Acknowledgments

Special thanks to [Patrick God](https://www.youtube.com/channel/UCgFQ0hzIB5HEg8KiKj8BCVw) for providing the inspiration and guidance for this Blazor WebAssembly Full-Stack demo project.

Happy coding!
