# Builder with Abstract Factory

This project demonstrates the combination of the **Builder** and **Abstract Factory** design patterns using **C#**. By combining these patterns, we can create complex objects step by step while maintaining flexibility in object creation.

## Design Patterns Overview

- **Builder**: The Builder pattern allows for step-by-step construction of complex objects. It separates the construction process from the representation, enabling the same construction procedure to create different configurations of the same type of object.

- **Abstract Factory**: The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

## Key Elements of the Combination

- **`AbstractFactory`** Interface: Declares methods for creating related or dependent objects.

- **`ComputerBuilder`** Class: Implements the `Builder` interface, assembling the respective parts to a final product.

- **`Director`** Class: Orchestrates the building process.

## Benefits of the Combination

By combining the **Builder** and **Abstract Factory** patterns, the following advantages are observed:

- **Flexibility**: This combination allows for the flexible construction of complex objects whose components must be chosen from families of related objects. The Abstract Factory supplies these parts, while the Builder assembles them.

- **Encapsulation**: The Director encapsulates the logic and construction process, preventing the client code from being overwhelmed with unnecessary details. This ensures that the client interacts with a clean interface, making the code easier to use and maintain.

- **Scalability**: The system, as observed in the thesis's examined scenarios, is easily extendable. It becomes straightforward to introduce new types of components and products without altering the existing codebase significantly.

## Considerations

While beneficial, there are some trade-offs:

- **Complexity**: The combination introduces additional complexity to the system, as it requires defining multiple classes and interfaces. This can make the system harder to understand and maintain for simpler use cases.

- **Distributed Logic**: The object creation logic is spread across multiple objects, which can lead to concerns about the distribution of responsibilities and potential maintenance overhead.

## When to Use

Before choosing this approach over simpler solutions, consider the specific needs of the project. For instance, if frequent introduction of new component types or product configurations is expected, and a modular, scalable architecture is preferred, this approach is advantageous. However, for simpler systems with fewer variations, the added complexity might not be justified.

## How to Run

1. **Ensure .NET 8 SDK is installed**: Make sure you have .NET 8 SDK installed. You can check your installed version by running:

   ```bash
   dotnet --version
   ```

2. **Build the project**: Navigate to the project folder and build the solution using:

   ```bash
   dotnet build
   ```

3. **Run the project**: After building the solution, run the project with:

   ```bash
   dotnet run
   ```
