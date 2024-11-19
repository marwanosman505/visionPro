# Property Management System with ASP.NET Core

Welcome to the **Property Management System**, an ASP.NET Core web application designed to manage properties in a hierarchical structure of **Sites**, **Buildings**, **Rooms**, and **Assets**. This project serves as a demonstration of using ASP.NET Core and Entity Framework Core to build a robust, scalable, and maintainable web application for property management use cases.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)

## Introduction

The Property Management System is a web application built with the ASP.NET Core MVC framework. It showcases how to implement a property management solution, allowing users to perform CRUD (Create, Read, Update, Delete) operations on properties organized in a hierarchical manner:

- **Sites**: The top-level entity representing a location or campus.
- **Buildings**: Structures within a site.
- **Rooms**: Individual rooms within a building.
- **Assets**: Items or equipment located within a room.

This project is ideal for learning how to:

- Use ASP.NET Core for building web applications.
- Implement Entity Framework Core for data access.
- Design a relational database schema with complex relationships.
- Apply MVC architectural patterns.
- Handle user input and validation.
- Enhance the user interface with Bootstrap.

## Features

- **CRUD Operations**: Full create, read, update, and delete functionality for all entities.
- **Entity Relationships**: Demonstrates one-to-many and many-to-one relationships.
- **Responsive UI**: User interface built with Bootstrap for mobile-friendly design.
- **Data Validation**: Server-side validation using data annotations.
- **Search and Filtering**: Ability to search and filter assets within the system.
- **Authentication and Authorization**: (Optional) Secure the application with user authentication.

## Technologies Used

- **ASP.NET Core**: Framework for building web applications.
- **Entity Framework Core**: Object-relational mapper for database operations.
- **SQL Server**: Relational database management system.
- **Bootstrap**: CSS framework for responsive design.
- **C#**: Programming language used for backend development.
- **Razor Views**: For dynamic server-side rendering of HTML pages.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or [Visual Studio Code](https://code.visualstudio.com/) with C# extensions
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [Azure SQL Database](https://azure.microsoft.com/en-us/services/sql-database/)
- [Git](https://git-scm.com/downloads) for version control
