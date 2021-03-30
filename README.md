# _Dr. Sillystringz's Factory_
### An independent project for Epicodus

#### _A program that will help a factory manage all of their engineers and machines._

#### By Dani Renner

## Technologies Used

* C#
* .NET 5.0.102
* <span>ASP.NET</span> Core Mvc 4.8
* Razor
* Entity Framework Core
* Git
* MySQL

## Description

_This application allows a many-to-many database relationship to hold engineers and machines. This way, the factory is able to see which engineers are licensed in which machines. Both engineers and machines can be added, deleted, and edited._

## Setup/Installation Requirements

* You can clone the repository to your desktop
* Navigate to the Factory directory
* Add a file called appsettings.json. In that file, you will need to add the following code:
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=dani_renner;uid=root;pwd=_password_;"
  }
}
* (The 'password' is only necessary if you have a password for your MySQL)
* Save
### Setting up the database
#### Using SQL
1. Open a SQL command line in a terminal. Copy and paste the contents of dani_renner.sql and hit enter.
2. Quit out of SQL with Ctrl + c
#### OR Using .NET
1. In the terminal, navigate to the Factory directory
2. Enter "dotnet ef migrations add Initial"
3. Enter "dotnet ef database update"
### Running the program
* From the Factory directory, Enter "dotnet run" in the terminal and hit enter to start a local host. 
* Ctrl + click the link that populates in the terminal to view the application in the webpage. It is probably http://localhost:5000/
* Use Ctrl + C in the terminal to quit the host and close out of the window in the browser.

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright © 2021 Dani Renner

All Rights Reserved

## Contact Information

_Dani Renner (danijrenner@gmail.com)_
