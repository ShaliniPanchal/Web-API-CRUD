# ProductCRUDApp

This project is a **.NET Core Web API** application that provides **CRUD (Create, Read, Update, Delete)** operations for managing products using **Entity Framework Core** with a **code-first** approach. It also includes **email notification** functionality that sends an email when a new product is added.

## Features

- **CRUD operations** for products:
  - Create a new product
  - Read (get) a list of products or a single product by ID
  - Update an existing product
  - Delete a product by ID
- **Code-first** approach using Entity Framework for database management
- **Email notifications**: Automatically sends an email when a new product is created

## Technologies Used

- **.NET Core 6**
- **Entity Framework Core**
- **SQL Server** (or LocalDB)
- **System.Net.Mail** for email notifications

## Requirements

- .NET 6 SDK
- SQL Server or LocalDB
- SMTP Server (e.g., Gmail, Outlook) for email notifications

## Getting Started

### Prerequisites

- Install [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Install SQL Server or [LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-2019-express-localdb)
- Set up an SMTP email provider (e.g., Gmail, Outlook)
