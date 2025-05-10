# Dependency Inversion Principle Demo

## Overview
This project demonstrates the Dependency Inversion Principle (DIP), a key design principle in object-oriented programming that promotes loose coupling between high-level and low-level modules.

## Dependency Inversion Principle
The Dependency Inversion Principle states that:
- High-level modules should not depend on low-level modules. Both should depend on abstractions.
- Abstractions should not depend on details. Details should depend on abstractions.

## Project Structure
- `IPaymentService.cs`: Defines the abstraction for payment services
- `Payment.cs`: Represents a payment transaction
- `Paypal.cs`, `Stripe.cs`, `ApplePay.cs`: Concrete implementations of payment services
- `PaymentProcessor.cs`: Demonstrates how to use different payment services
- `Program.cs`: Main entry point showing the usage of various payment services

## How It Works
The project showcases how different payment services can be easily integrated and swapped without modifying the core payment logic.

### Key Components
- `IPaymentService`: An interface defining a common contract for payment services. Concrete payment service classes implement the `IPaymentService` interface
- `Payment` class represents a payment transaction

## Running the Project
1. Ensure you have .NET SDK installed
2. Clone the repository
3. Navigate to the project directory
4. Run `dotnet run`
5. Enter the payment amount when prompted

## Benefits of This Approach
- Flexibility in adding new payment services
- Reduced coupling between components
- Easier to test and maintain
- Follows SOLID principles, specifically the Dependency Inversion Principle
