# JiraLite

JiraLite is a lightweight bug and project tracking web application built with **ASP.NET Core Blazor Server** and **Entity Framework Core**. It provides essential features to manage projects, tickets, and comments with user authentication and role-based access.

## Features

- User registration, login, and authentication via ASP.NET Identity
- Create, edit, and delete projects and tickets
- Assign tickets to users with priorities and statuses
- Comment system on tickets for team collaboration
- Responsive UI built with Blazor Server components
- Data validation and error handling throughout the app

## Technologies Used

- ASP.NET Core Blazor Server
- Entity Framework Core (Code First Migrations)
- SQL Server / LocalDB
- ASP.NET Core Identity for authentication
- Bootstrap for styling

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download)
- SQL Server or LocalDB installed
- Visual Studio 2022 (or later) recommended but optional

### Setup Instructions

1. **Clone the repository**

   ```bash
   git clone https://github.com/your-username/JiraLite.git
   cd JiraLite
Restore dependencies

bash
Copy
Edit
dotnet restore
Apply database migrations

bash
Copy
Edit
dotnet ef database update
Run the application

bash
Copy
Edit
dotnet run
Access the app

Open your browser and go to:

arduino
Copy
Edit
https://localhost:5001
Project Structure
/Data – EF Core DbContext and migration files

/Models – Entity classes such as Project, Ticket, Comment, ApplicationUser

/Pages – Blazor components and Razor pages for UI

/Services – Business logic and data access layers

Future Enhancements
Email notifications for ticket updates and assignments

File attachments for tickets

Enhanced dashboard with analytics and reporting

Role management and permissions

