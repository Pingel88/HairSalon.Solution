## <div align="center">Eau Claire's Salon</div>
#### <div align="center">*Epicodus Week 10 C# Project 03/12/2021* </div> 
***<p align="center">By Mike Pingel***</p>
<p align="center">
<img alt="C#" src="https://forthebadge.com/images/badges/made-with-c-sharp.svg"/>
</p>

___
### This project is not in a complete or portfolio ready state, and should not be considered as representation of professional work.
___
## *Description*    
### *An MVC application to manage stylists and their clients at Eau Claire's Salon. Upon being greeted with a splash page, the user can add new clients and stylists as well as view clients tied to individual stylists. This project utilizes Entity to communicate with a MySQL database that stores client and stylist data.*

## *Setup/Installation instructions*
### *From the web*
* Go to the GitHub repository for this project: [https://github.com/Pingel88/HairSalon.Solution.git](https://github.com/Pingel88/HairSalon.Solution.git).
* At the top of the repository, click <img src="https://i.imgur.com/Ej9Dphm.png" alt="Code Button" height="20" align="center" /> then select "Download ZIP".

  <img src="https://i.imgur.com/tZKvGne.gif" alt="download zip gif" height="200"/>
* Unzip the file, navigate to the **'HairSalon'** folder to view code.
### *From the terminal*
* Clone my repository from GitHub using `git clone https://github.com/Pingel88/HairSalon.Solution.git` in your terminal or GitBash
* Navigate to the downloaded folder using `cd` command
* Execute `code .` command in your terminal and it will open all source code in your code editor.

### ⚠️*Note*⚠️
To run this project locally you will need to have .NET Core and MySQL, follow along with the Epicodus C# setup lessons to verify installation.

###  *View website*
A GitHub page is not available for this project. To view functionality in your browser:
* Import **mike_pingel.sql** database
  * Open MySQL Workbench and select your local instance
  * Select `Data Import/Restore` on the Administration tab in the Navigator
  * Select `Import from Self-Contained File` and navigate to and select the **mike_pingel.sql** file you cloned/downloaded with the project
  * Select `New...` under Default Schema to be Imported To
  * Enter `mike_pingel` and click OK
  * Click on `Start Import` to import the database
  * Close MySQL Workbench if desired
* Rename **EDITMEappsettings.json** in the **'HairSalon'** folder to **appsettings.json**
* Open **appsettings.json** in VS Code or Notepad
  * Enter your password in the DefaultConnection string (replacing `[PASSWORD]`) and save the file
* Navigate to the **'HairSalon'** folder in your terminal
* Enter `dotnet run`
* Open your browser and visit http://localhost:5000

## *Technologies used*
* C# 9
* .NET Core v5.0
* MySQL & MySQL Workbench
* <span>ASP.</span>NET Core MVC
* Razor
* HTML Helper
* REPL
* Git & GitHub

## *Known bugs*
* Leaving a **'Not Null'** field blank will send the user to an error page forcing them to use the browser back button.

## Contact Information
[![Ask Me Anything !](https://img.shields.io/badge/Ask%20me-anything-1abc9c.svg)](mailto:mdpingel+github@gmail.com?subject=[GitHub]Epicodus%20Project%20-%20HairSalon.Solution)

## *License and copyright*

***© Michael Pingel, 2021***

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)