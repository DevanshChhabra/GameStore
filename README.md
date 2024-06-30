# Game Store

A comprehensive web application for managing a catalog of games, built with Blazor WebAssembly and MongoDB. This project demonstrates the use of modern web technologies to create a responsive, interactive, and efficient web application.

## Features

- **Game Catalog Management**: View, add, edit, and delete games from a central catalog.
- **Blazor WebAssembly**: Client-side web UI framework providing interactive web applications using C# instead of JavaScript.
- **MongoDB Integration**: Use MongoDB for a NoSQL database solution to store and retrieve game data.
- **Component-Based Architecture**: Modular design with reusable components, including game list, game form, and delete confirmation modal.
- **Responsive Design**: Built with Bootstrap for a mobile-friendly, responsive user interface.

## Technologies Used

- **Blazor WebAssembly**: For building interactive web UIs using C#.
- **ASP.NET Core**: Backend server handling API requests.
- **MongoDB**: NoSQL database for storing game data.
- **Bootstrap**: Responsive design framework for a modern UI.
- **JavaScript Interop**: Integrate JavaScript with Blazor for enhanced functionality.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [MongoDB](https://www.mongodb.com/try/download/community) (Community Edition)
- [Node.js](https://nodejs.org/) (for npm and bootstrap)

### Installation

1. **Clone the repository**:
   ```sh
   git clone https://github.com/DevanshChhabra/gamestore.git
   cd gamestore
2. **Set up MongoDB:**
   Ensure MongoDB is installed and running on your local machine.
   Create a database named `GameStore` with a collection named `Games`.
3. **Configure the application:**
   Open the `appsettings.json` file.
   Update the MongoDB connection string and database name.
4. **Install .NET dependencies:**
   ```sh
   dotnet restore
5. **Build the application:**
   ```sh
   dotnet build
6. **Run the application:**
   ```sh
   dotnet run

### Usage

1. **Accessing the Application**:

   Open your web browser and navigate to http://localhost:5000.

2. **Features**

* **View Games**: Browse through the list of games in your catalog.
* **Add Games**: Click the "Add Game" button to open a form and enter details for a new game.
* **Edit Games**: Select a game and click the "Edit" button to modify game details.
* **Delete Games**: Click the "Delete" button to remove a game, with a confirmation modal for safety.

3. **Responsive Design**:

   Enjoy a fully responsive interface built with Bootstrap, compatible with various devices.

## Additional Information

- **JavaScript Interop**: Some advanced features may require JavaScript interop. Ensure your browser supports JavaScript and Blazor WebAssembly.

- **Troubleshooting**:
  - If you encounter issues connecting to MongoDB, verify your connection string and ensure MongoDB is running.
  - For .NET-related issues, ensure you have the correct SDK version installed.

## Acknowledgements

- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) for the amazing framework.
- [MongoDB](https://www.mongodb.com/) for the robust NoSQL database solution.
- [Bootstrap](https://getbootstrap.com/) for the responsive design framework.

