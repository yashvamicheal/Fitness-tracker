# FitTrack — ASP.NET Core Fitness Tracker

## Pages
1. Home / Learn About the Page — project overview and sample dashboard.
2. Missions & Equipment — fitness missions and equipment.
3. Know About Exercise — searchable exercise library.
4. Diet Purpose — general balanced-meal planning.
5. Competition Registration — form stored in SQLite.

## Technology
- ASP.NET Core 8 Razor Pages
- C#
- Entity Framework Core
- SQLite
- HTML/CSS/JavaScript
- Responsive, multi-colour UI

## Real-world problem addressed
Many beginners keep fitness information in separate places: activity goals, exercise instructions, meal planning and event registration. FitTrack combines these common tasks into one small web application.

## Run
Install .NET 8 SDK, open this folder in Visual Studio / VS Code, then run:

    dotnet restore
    dotnet run

Open the localhost URL shown by ASP.NET.

The SQLite database `fitness.db` is created automatically on first run.

## Notes
The activity numbers and diet examples are demo data for an academic project. They are not medical or individualized nutrition advice.
