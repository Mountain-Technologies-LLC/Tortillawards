# Tortillawards

Birthed in 2014 by Anthony Pearson as a website for gag awards.
The first ballot of gag awards was created for the Theta-Rho Chapter of TKE Fraternity.
Features included signing in with Facebook, voting for a nomination, and viewing tallies.
The original logo and mascot are exactly the same here.
On November 22, 2014, the first awards were presented at the Kentucky Derby Formal.
Awards included 'Grows Good Hair' awarded to Scott Reid, and 'Most Likely to Wake Up in Another Country' awarded to James Seegebarth.
Winners were awarded funny certificates.
However, the project shortly died after.

The rebirth. Is here. Now with more abilities and features.
New features include a slick domain, sign in with email, creating and managing ballots, ownership of ballots, adding new awards to a ballot, and nominations.
These features expand from the MVC to a fully functioning product.
Tortillawards is built with AWS, ASP.NET Core Blazor, and Bootstrap.
Also, by the way, it's all open source.

## Requirements
.NET 8
SQL Server or MySql (with some setup)
Entity Framework Core tools reference - .NET Core CLI

## Setup with MySql Server
- Will need MySql Server to be able to deploy data migrations
- May need to work with MySqlConnection appsetting to create new database

## Setup with SQL Server
Data/Migrations may need to be removed/initialized
- Remove migrations in Data/Migrations
- Run ```dotnet ef database add Initial -o Data/Migrations```
- Run ```dotnet ef database update```

You may need to add permissions to the connection string.

## Running the App
Every logged in user will have access to one Ballot. You should not need to have an email server.

![home](Screenshot-Home.png "Home")
![ballot](Screenshot-Ballot.png "Ballot")
