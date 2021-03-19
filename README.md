# _Dr. Sillystringz's Factory_
### An independent project for Epicodus

#### _A program that will help a factory manage all of their engineers and machines._

#### By Dani Renner

## Technologies Used

* _C#_
* _.NET 5.0.102_
* _ASP.NET Core Mvc 4.8_
* _Razor_
* _Entity Framework Core_
* _Git_

## Description

_This application allows a database to hold engineers and machines. This way, the factory is able to see which engineers are licensed in which machines._

## Setup/Installation Requirements

* You can clone the repository to your desktop
* Open a SQL command line in a terminal. Copy and paste the contents of dani_renner.sql and hit enter.
* Navigate to the Factory directory
* Navigate to the HairSalon directory
* Add a file called appsettings.json. In that file, you will need to add the following code:
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[dani_renner];uid=root;pwd=password [if you have one];"
  }
}
* Install the dotnet ef tool by entering "dotnet tool install --global dotnet-ef" in the terminal
* Create the database by entering "dotnet ef database update" in the terminal
* Enter "dotnet restore" in the terminal and hit the Enter key. 
* Enter "dotnet build" in the terminal and hit the Enter key.
* Enter "dotnet run" in the terminal and hit enter to start a local host. 
* Ctrl + click the link that populates in the terminal to view the application in the webpage. It is probably http://localhost:5000/
* Use Ctrl + C in the terminal to quit the host and close out of the window in the browser.

## Known Bugs

* _None_

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright © 2021 Dani Renner

All Rights Reserved

## Contact Information

_Dani Renner (danijrenner@gmail.com)_
