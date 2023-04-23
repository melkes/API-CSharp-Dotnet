# Animal Shelter API
#### By Mike Wilkes
#### A .NET# API for a database of adoptable pets
## Technologies Used

- C#
- ASP.NET Core MVC
- Entity Framework Core
- MySQL
- Git

## Description

This is a web API made using the ASP.NET framework, for use with a MySQL database to manage and display data. It is designed to be used by an animal shelter or other end-user to create, view, edit, and delete listings of adoptable pets.

## Setup instructions

- Clone this repository and open in VS Code
- Navigate to the PetShelterAPI directory (inside PetShelterAPI.Solution)
- Create an appsettings.json file with the following contents, replacing the values inside brackets [] with your own:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
- Run database migrations to create the needed database tables: 
  - `dotnet ef database update`
- In a terminal window, run:
  - `dotnet run`
- You may be asked to enter your system password

### Testing with Swagger
- In a web browser, navigate to https://localhost:5001/swagger/index.html.
- Try a search query with GET, create an entry with POST, search by entry id with GET {id}, edit an entry with PUT, or remove one with DELETE.
  - Click the dropdown for the chosen method, then click "Try it out"

### Paging
In order to test the pagination function, use the included `.sql` file.
- Open MySQLWorkbench and select Data Import/Restore from the Administration tab
- Choose "Import from Self-Contained File" and select `shelter_api_pets.sql` from this repository
- Open `appsettings.json` and change line 10 so that your database is set to `shelter_api_pets`
## Known Bugs
No known bugs

## Project Roadmap
Future improvements could include:
- Creating a service for generating pagination URLs, so that a client could have links to the First Page, Last Page, Next page and Previous page.
- Configuring this URL service to get the base URL.
- Creating a pagination helper class to have more reusable code and reduce the size of the controller.

## License

MIT License

Copyright (c) _2023_ _Mike Wilkes_