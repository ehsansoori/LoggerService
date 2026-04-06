# LoggerService

A simple C# project that demonstrates the Dependency Injection principle using a modular logging system.

## Project Overview

This solution shows how to decouple application components by depending on abstractions instead of concrete implementations.

The project uses an `ILogger` interface and multiple logger implementations such as:

- `ConsoleLogger`
- `FileLogger`
- `MultiLogger`

These loggers are injected into the service instead of being created directly inside it.

## Solution Structure

- **LoggerService.Core**  
  Contains the core logic, interfaces, and logger implementations.

- **LoggerService.Console**  
  Contains the application entry point (`Program.cs`) and runs the demo.

## Key Concepts Demonstrated

- Interface-based design
- Dependency Injection
- Loose coupling
- Better maintainability
- Easy extensibility

## Example

```csharp
ILogger logger = new ConsoleLogger();
var service = new LogService(logger);
service.ProcessLog("Hello from logger service...");