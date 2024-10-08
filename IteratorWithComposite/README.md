# Iterator with Composite

This project demonstrates the combination of the **Iterator** and **Composite** design patterns using **C#**, enabling traversal through complex hierarchical structures containing different types of objects through a unified interface.

## Design Patterns Overview

- **Iterator**: The Iterator pattern provides a way to sequentially access the elements of a collection without exposing its underlying structure

- **Composite**: The Composite pattern allows you to compose objects into tree-like structures to represent part-whole hierarchies. It enables clients to treat individual objects and compositions of objects uniformly.

## Key Elements of the Combination

- **`FileSystemNode`** Abstract Class: Represents all the node types.

- **`File & Folder`** Classes: Implementions for the leaf and composite objects respectively.

- **`IIterableCollection & IIterator`** Interfaces: They provide a standardized way to traverse elements of the hierarchy without exposing the underlying structure.

## Benefits of the Combination

By combining the **Iterator** and **Composite** patterns, the following advantages are achieved:

- **Simplicity for Client Code**: The client can traverse a hierarchical structure containing different types of nodes (both individual and composite objects) using a unified interface. This means the client doesn't need to be aware of the specific implementation details of the structure or the traversal algorithms used.

- **Decoupling of Traversal Logic**: The traversal logic is decoupled from the composite structure itself. The Iterator takes care of how elements are accessed, leaving the Composite structure focused on organizing elements hierarchically.

- **Uniform Treatment**: Both leaf nodes (simple objects) and composite nodes (complex objects) are treated uniformly during traversal, simplifying the design and interaction with hierarchical structures.

## Considerations

While this combination offers simplicity and uniformity in most cases, some considerations include:

- **Scalability**: For simple scenarios with a limited number of composite nodes and traversal algorithms, this combination works efficiently. However, for larger structures containing numerous node types and complex traversal requirements, the implementation can become increasingly complex and harder to manage.

## When to Use

This combination is suitable for scenarios where:

- The system needs to handle tree-like structures with part-whole hierarchies.

- Uniform traversal of both individual and composite objects is required.

- The client code should be kept simple and free from the details of the underlying hierarchy.

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
