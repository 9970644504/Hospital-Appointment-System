# Hospital Appointment System (ASP.NET Core MVC)

## Overview
A basic Hospital Appointment System built with ASP.NET Core MVC (.NET 7) and Entity Framework Core (LocalDB). Features:
- ASP.NET Core Identity (Login/Register)
- CRUD for Patients, Doctors, Appointments
- Admin dashboard (summary counts)
- Simple Bootstrap-based UI

## Prerequisites
- Visual Studio 2022 with ASP.NET workload
- .NET 7 SDK
- LocalDB (installed with Visual Studio)

## Quick setup
1. Open the folder in Visual Studio or open the `.csproj` file.
2. In **Tools → NuGet Package Manager**, restore packages (or run `dotnet restore`).
3. Update database (Package Manager Console):
   ```
   Add-Migration InitialCreate
   Update-Database
   ```
4. Run the project (Ctrl+F5). Register a new user, then use the navigation to add patients, doctors and schedule appointments.

## Notes
- Connection string is configured for LocalDB in `appsettings.json`.
- If you want a `.sln` created by Visual Studio, open folder and create a solution, or use Visual Studio's Create Project UI.
