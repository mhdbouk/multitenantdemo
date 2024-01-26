# MultiTenant DEMO

## Description

This is the source code for the YouTube video `Is Your .NET App Multi-Tenant Yet? Learn How!`. In this video, we will learn how to implement multi-tenancy in a .NET application. We will start with a simple Todo application and then add multi-tenancy to it. We will also learn how to use the `HttpContext` to get the current tenant in the application.

### Check the YouTube video here

[![Is Your .NET App Multi-Tenant Yet? Learn How!](https://img.youtube.com/vi/AHXrBjQge5s/0.jpg)](https://www.youtube.com/watch?v=gHfSB0LFs4U)

[Is Your .NET App Multi-Tenant Yet? Learn How!](https://www.youtube.com/watch?v=gHfSB0LFs4U)

## Project Structure

The main solution file is [MultiTenancy.sln](MultiTenancy/MultiTenancy.sln), and the source code is located in the [MultiTenancy](MultiTenancy/MultiTenancy) directory. Here are some key files:

- [`Program.cs`](MultiTenancy/MultiTenancy/Program.cs): The entry point of the application.
- [`TenancyManager.cs`](MultiTenancy/MultiTenancy/TenancyManager.cs): Manages the tenants in the application.
- [`TenancyMiddleware.cs`](MultiTenancy/MultiTenancy/TenancyMiddleware.cs): Middleware for handling multi-tenancy.
- [`TodoDbContext.cs`](MultiTenancy/MultiTenancy/TodoDbContext.cs): The DbContext for the Todo application.
- [`appsettings.json`](MultiTenancy/MultiTenancy/appsettings.json): Contains the application settings.

## Getting Started

To get started with the project, follow these steps:

1. Clone the repository.
2. Run `dotnet run` to start the application.

Please ensure you have .NET 8 installed on your machine before you proceed.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
