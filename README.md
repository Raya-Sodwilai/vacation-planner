# _Vacation Planner_

#### _This is a vacation planner application with CRUD operations, ASP .NET MVC and Data Tables with API Calls._

#### By _**Raya Sodwilai**_

## Technologies Used

* ASP .NET MVC
* C#
* HTML
* JavaScript
* CSS

## Description

_This application allows users to create/plan their future vacations that includes city, number of guest, date and time. Users are also able to add and delete the vacations list._

## Pre-requisites

* C#/.NET5
* MySQL Workbench
* Internet Browser
* A GitHub Account
* Code Editor such as Visual Studio Code

## Setup/Installation Requirements

 * Clone the repository with command ```shell $ git clone gitHub-URL-repository```
 * Open the repository on your computer in your text editor.
 * Navigate to the Vacation folder & create a file called ```shell appsettings.json```
 * Once inside ```shell appsettings.json```, write the following code:
      * ```shell { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[NAME YOUR DATABASE HERE];uid=[MySQL USER-NAME HERE];pwd=[MySQL PASSWORD HERE];" } }```

      * Fill in the required info. (database name, MySQL user-name & password) without the squared brackets.
 * Navigate to the Vacation folder and run the command ```shell $dotnet ef database update```
 * Stay in the Vacation folder and run the command ```shell $dotnet build```
 * To begin using the MVC application, run the command ```shell $dotnet run```
 * Visit the app via the browser: 'localhost:5000/'

## Known Bugs

* N/A

## License

_MIT Copyright (c) 2021 Raya Sodwilai_

## Contact Information

_sodwilai@pdx.edu_
