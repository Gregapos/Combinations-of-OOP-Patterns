# Builder with Composite

This project demonstrates the combination of the **Builder** and **Composite** design patterns using **C#**. By combining these patterns, we can create complex, hierarchical systems with a clear and structured approach to object construction and management.

## Design Patterns Overview

- **Builder**: The Builder pattern encapsulates the construction logic of the hierarchical structure.
- **Composite**: The Composite pattern provides a unified interface to manage both composite (objects that contain other objects) and leaf objects (individual objects). It allows clients to treat individual objects and compositions of objects uniformly.

## Key Elements of the Combination

- **`FileSystemNode`** Abstract Class: Declares common behavior for both composite and leaf objects.
- **`File & Folder`** Classes: Implementions for the leaf and composite objects respectively.
- **`FileSystemBuilder`** Class: Creates and assembles nodes to build a file system.

## Benefits of the Combination

By combining the **Builder** and **Composite** patterns, the following advantages are observed:

- **Structured Hierarchy**: The combination allows for the clear and structured construction of complex hierarchical systems. The Builder pattern facilitates a step-by-step approach, while the Composite pattern offers a unified interface for managing both complex objects and individual leaves.

- **Scalability**: This combination demonstrates a high degree of scalability, as new elements can be added without significantly altering the rest of the system. The hierarchical nature of the Composite pattern makes it easy to add new nodes or leaves to the structure.

- **Modularity**: Both the Builder and Composite patterns promote modularity by separating concerns. The construction logic is handled independently from the composite structure’s management.

## Considerations

While this combination offers flexibility and structure, there are trade-offs:

- **Abstraction Overhead**: Introducing a Builder to manage a Composite structure adds an extra layer of abstraction. This could potentially impact performance, especially in large-scale systems, due to the overhead introduced by managing the hierarchy through builders.

- **Increased Complexity**: The abstraction introduced by the Builder may make the system more complex to understand and maintain. This should be weighed against the benefits, particularly in cases where simpler structures might suffice.

## When to Use

This combination is useful when you need to create complex, hierarchical systems that are likely to evolve over time. If the system requires frequent addition of new nodes or leaves, and a clear separation between construction and management is necessary, this approach provides great flexibility. However, for simpler systems, the added abstraction may be unnecessary.

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
