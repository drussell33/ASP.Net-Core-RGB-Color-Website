# ASP.Net Core RGB Color Website

## Description

ASP.Net Core RGB Color Website is a simple web application built using
ASP.NET Core MVC that demonstrates dynamic color rendering based on RGB
values. The project showcases server-side rendering combined with
client-side interactions to update UI elements in real time.

## Badges

![Repo
Size](https://img.shields.io/github/repo-size/drussell33/ASP.Net-Core-RGB-Color-Website)
![Last
Commit](https://img.shields.io/github/last-commit/drussell33/ASP.Net-Core-RGB-Color-Website)
![Top
Language](https://img.shields.io/github/languages/top/drussell33/ASP.Net-Core-RGB-Color-Website)

## Key Features

-   ASP.NET Core MVC web application structure
-   Dynamic RGB color rendering in the UI
-   Server-side controllers handling user input
-   Razor views for rendering HTML
-   Basic client-side interactivity for updating colors

## Tech Stack

### Backend

-   ASP.NET Core MVC (C#)

### Frontend

-   Razor Views
-   HTML/CSS
-   JavaScript

### Database

-   None (no database detected)

### Tools / Services

-   .NET SDK
-   Visual Studio / Visual Studio Code

## Architecture Overview

The application follows the ASP.NET Core MVC pattern. Controllers handle
incoming HTTP requests and process RGB input values. These values are
passed to Razor Views, which render the UI dynamically. Client-side
JavaScript enhances interactivity by allowing real-time updates to color
values without requiring full page reloads.

## Project Structure
``` 
    ASP.Net-Core-RGB-Color-Website/
    ├── Controllers/        # Handles HTTP requests and application logic
    ├── Models/             # Data models for RGB values
    ├── Views/              # Razor views for UI rendering
    ├── wwwroot/            # Static assets (CSS, JS, images)
    ├── Program.cs          # Application entry point
    ├── Startup.cs          # Middleware and service configuration
    └── appsettings.json    # Configuration settings
```
## Getting Started

### Prerequisites

-   .NET SDK (6.0 or later recommended)

### Installation

``` bash
git clone https://github.com/drussell33/ASP.Net-Core-RGB-Color-Website.git
cd ASP.Net-Core-RGB-Color-Website
dotnet restore
```

### Usage

``` bash
dotnet run
```

Navigate to:

    http://localhost:5000

## Roadmap

-   [x] Basic MVC structure implemented
-   [x] RGB color rendering functionality
-   [ ] Add persistent storage for saved colors
-   [ ] Improve UI/UX styling
-   [ ] Add validation for RGB inputs
-   [ ] Deploy to cloud hosting

## Contributing

1.  Fork the repository
2.  Create a feature branch
3.  Commit your changes
4.  Push to your branch
5.  Open a Pull Request

## Screenshots / Demo

*Add screenshots or demo links here*

## Contact

GitHub: https://github.com/drussell33
