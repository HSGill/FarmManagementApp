# Farm Management App

Farm Management App is a web application built using Blazor WebAssembly and MongoDB, designed to help farmers manage and monitor data about their fields.

## Table of Contents

- [Features](#features)
- [Technology Stack](#technology-stack)
- [Folder Structure](#folder-structure)
- [Setup](#setup)
- [Architecture](#architecture)
- [Trello Board for Planning](#trello-board-for-planning)
## Features

1. **Farm Details:**
   - View and edit farm details, including name, address, total area, and owner information.

2. **Field List:**
   - View a list of all fields in the farm.
   - Filter fields by name, use, and product.
   - Add new fields to the farm.

3. **Field Details:**
   - View individual details of each field, including name, area, use, product, and expected yield.

## Technology Stack

- **Blazor WebAssembly:** Front-end framework for building interactive web applications.
- **MudBlazor:** UI components library for Blazor.
- **MongoDB:** NoSQL database for storing farm and field data.

## Folder Structure

The Farm Management App follows a structured organization to maintain clarity and modularity in the codebase. Here's an overview of the main folders:

## 📁 FarmManagementApp.Client

This folder contains the client-side Blazor WebAssembly application.

- **📁 Models:**
  - Contains the data models representing entities such as farms, fields, and owners.

- **📁 Services:**
  - Holds the services responsible for data retrieval, manipulation, and interaction with external APIs or databases.

- **📁 Pages:**
  - Razor components representing the various pages of the application.

- **📁 Shared:**
  - Contains shared components, layouts, or utilities used across multiple pages.

- **📁 wwwroot:**
  - Assets, styles, and client-side resources.

## Setup

1. **Prerequisites:**
   - Ensure you have [.NET SDK](https://dotnet.microsoft.com/download) installed.
   - Make sure MongoDB is installed and running.

2. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/farm-management-app.git
   cd farm-management-app

## Architecture

The application follows a client-server architecture:

- **Client Side (Blazor WebAssembly):**
  - The client-side application is built using Blazor WebAssembly.
  - It interacts with the server-side API to fetch and manipulate data.

- **Server Side (ASP.NET Core Web API):** (This has to be implemented)
  - An ASP.NET Core Web API acts as an intermediary between the Blazor WebAssembly client and the MongoDB database.
  - The API handles database connections, executes queries securely, and exposes controlled endpoints for client-side interactions.

## MongoDB Driver Compatibility Issue

The MongoDB driver attempts to start a new thread, which is not supported in the context of Blazor WebAssembly. Threads in Blazor WebAssembly are limited compared to traditional server-side .NET applications. This limitation results in a `PlatformNotSupportedException` exception.

## Solution

To address this issue, the recommended approach is to use a server-side API. This API acts as a secure intermediary between the client-side Blazor WebAssembly application and the MongoDB database. It ensures proper handling of database connections and queries, adhering to the constraints of Blazor WebAssembly.

# Trello Board for Planning

For collaborative planning and tracking of tasks, I used Trello. Visit Trello Board to stay updated on project progress, upcoming features, and tasks in the pipeline. There are few tasks outstanding Please feel free to assign it to yourself.

👉 [Farm Management System Trello Board](https://trello.com/invite/b/57Vp9OuV/ATTIc48bb85d58572a52b15232193ad7ede8BDBD78B7/farm-management-system)


