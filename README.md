
# _Travel Api Client_
#### _Epicodus Project June 10, 2020_

#### By _**Julia Seidman & DJ Zevenbergen & Jason Macie**_


## Description

_A project to introduce practice working with an unknown api._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Install MySQL on your computer.
3. Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
4. In your terminal, navigate to the project directory and run the commands dotnet restore and dotnet build to download dependencies and build the configuration.
5. Currently, the mySQL database is set up with an appsettings.json file that was not uploaded to Github.  Once you have saved the SQL database on your computer, create an appsettings.json file in the project root directory, and update it with your MySQL installation information in this format:
6. To run MySQL migrations and create a database in your MySQL installation, enter the following command in your terminal: ```dotnet ef database update```.
7. This API uses Swagger. To launch the Swagger/OpenAPI utility in your browser, from the project directory in your terminal, enter ```dotnet run``` and open a browser page at localhost:5000.  You can now see all API routes grouped by controller.  Clicking on a route will expand it and show details of that route, and give you the option to "Try It Out."


## Known Bugs

There are no known bugs at the time of this update.

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue] here on GitHub._

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MySQL
* Identity
* MSBuild
* Git and GitHub
* Swagger/OpenAPI

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Site allows any visitor to view a list of all reviewed "Places"** | User Input: "See Places" | Output: "Seattle, 8/10, Las Vegas, 2/10, Vermont, 8/10, Connecticut, 5/10" |
| **Site allows any visitor to view details of a selected "Place"** | User Input: "See Seattle" | Output: 
    ///        "City": "Seattle",
    ///        "Country": "United States",
    ///        "Description": "Always damp. Great bartenders."
    ///        "Rating": 8/10 (would get rained on again)" |
| **Site allows visitor to create a user account** | User Input: "Create Account" | Output: "Create a username and password." |
| **Site authenticates users on login** | User Input: "Log In" | Output: "Welcome, Wanderer!" |
| **Site allows authenticated users to create new destinations** | User Input: "Add New Place:" 
///     "City": "Salzburg",
///     "Country": "Austria",
///     "Description": "Beautiful, but a little boring and expensive.  Better food than Germany."
///     "Rating": 6/10 | Output: "Thanks for adding Salzburg!" |
| **Site allows authenticated users to rate any destination** | User Input: "Seattle: 4/10, `Where have all the dive bars gone?`" | Output: "Thank you for reviewing Seattle.  Your rating will be added." |
| **Site allows authenticated users to edit ratings and reviews they created.** | User Input: "Seattle, 5/10, `Found Poggie Tavern in West Seattle, and it shows the Seattle dive bar is still alive and kicking.  Or at least alive.`" | Output: "Your rating for Seattle has been changed.  Thanks!" | 
<!-- Stretch goals: Create user authenticated put & delete methods for places in addition to ratings -->





### License
This software is licensed under the MIT license.

Copyright (c) 2020 **_Julia Seidman, DJ Zevenbergen & Jason Macie_**