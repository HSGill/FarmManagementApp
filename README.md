# Farm Management App

Farm Management App is a web application built using Blazor WebAssembly and MongoDB, designed to help farmers manage and monitor data about their fields.

## Table of Contents

- [Features](#features)
- [Technology Stack](#technology-stack)
- [Folder Structure](#folder-structure)
- [Setup](#setup)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

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

The project follows a clean folder structure for better organization:

- **FarmManagementApp:**
  - **Models:**
    - Contains classes representing the data structure, such as `Farm`, `Owner`, `Field`, and `Address`.
  - **Services:**
    - `FieldService.cs`: Handles operations related to fields data.
    - `FarmService.cs`: Manages operations related to farms.
  - **Pages:**
    - Contains Blazor components for different pages, such as `Index.razor`(Farm Details Page) and `FieldList.razor`(Fields Page). It has a drawer component
    - to add new field.
  - **Shared:**
    - Shared components, layouts, or utilities used across the application.
  - **wwwroot:**
    - Static files, such as images or CSS files.

## Setup

1. **Prerequisites:**
   - Ensure you have [.NET SDK](https://dotnet.microsoft.com/download) installed.
   - Make sure MongoDB is installed and running.

2. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/farm-management-app.git
   cd farm-management-app
