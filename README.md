# TreatShop
#### By Keturah Howard _March 27th 2020_ 

## Description

ASP.NET core MVC application using Entity Framework Core and MySQL for a treat shop website. Search our shop for treats either by flavor or treats list. This application was made with the intention of practicing authorization and Many to Many database relationships with MySQL and with ASP.NET core MVC with Entity Framework Core.

## Specifications

* user arives at splash page.  Can either register/ log in/ or choose to view the selection
* user can select to look at treats via "treats" or "falvors"
* user browsing flavors will see a list of flavors, clicking on a flavor will go to a details page listing all the available treats 
* users browsing treats will see a list of treats, clicking on a treat will display to a details page with all the flavors of that treat
* user enteres an email and password when registering for an account to become a member
* member is redirected to log in page when submitting registration form
* member is redirected to welcome page after log in is complete
* member can see create links when viewing flavors and treats
* member sees edit and delete links when on details pages


## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone (INSERT REPO NAME)
    ```
2. Change directories into the project working directory:
    ```
    cd FoodStore.Solution
    ```
3. Restore all dependencies:
    ```
    dotnet restore
    ```

 #### Setup Database

4. Run the following commands in terminal on root level to setup this project Database
    ```
    dotnet ef migrations add Initial
    dotnet ef update database

    ```
5. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```
6. Open the locally hosted server in your preferred web browser:
    ```
    start http://localhost:5000
    ```

## Technologies Used

* C#
* ASP.NET core MVC 2.2
* Entity Framework Core
* MySQL + MySQL Workbench version 8.0.15
* RESTful Routing
* CRUD Functionality
* Git
* Identity

## License

Licensed under the MIT license.

&copy; 2020 Keturah Howard.