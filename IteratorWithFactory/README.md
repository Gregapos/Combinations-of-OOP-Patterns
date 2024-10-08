# Iterator with Factory Method

This project demonstrates the combination of the **Iterator** and **Factory Method** design patterns using **C#**, offering a flexible and adaptable solution for traversing various collections of objects.

## Design Patterns Overview

- **Iterator**: The Iterator pattern provides a way to sequentially access the elements of a collection without exposing its underlying structure

- **Factory Method**: The Factory Method pattern defines an interface for creating an object but allows subclasses to alter the type of object that will be created. This helps in decoupling the object creation process from the client code. In this combination, it serves to generate and return collection traversal algorithms, based on the type of collection and the desired way to traverse it.

## Key Elements of the Combination

- **`ICollectionCreator`** Interface and **`ListCreator` & `HeapCreator`** Classes: They handle the creation of different types of collections and iterators.

- **`IIterator`** Interface: Provides a standard way to traverse elements in a collection without exposing the internal details of the collection.

- Concrete IIterator implementations

## Benefits of the Combination

By combining the **Iterator** and **Factory Method** patterns, several advantages are achieved:

- **Extensibility**: New types of collections and traversal algorithms can be introduced with minimal changes. The Factory Method pattern simplifies the process of extending the system by allowing new iterators to be created easily for new collection types.

- **Decoupling of Object Creation**: The Factory Method decouples the creation of iterators and collections from the client code, enhancing flexibility and maintainability.

- **Uniform Traversal Interface**: The client code can traverse different collections through a unified interface without needing to understand the internal implementation of the collection or the specific traversal algorithm. This keeps the client code simple and focused.

## Considerations

While this combination brings flexibility and scalability, there are some trade-offs:

- **Overhead from Abstraction**: The additional layer of abstraction introduced by the Factory Method pattern can slightly impact performance, especially when dealing with very large collections or complex traversal algorithms. This overhead should be considered in performance-critical applications.

- **Complexity for Simple Scenarios**: For simple collections or systems where only a single traversal algorithm is required, the use of both Iterator and Factory Method might introduce unnecessary complexity.

## When to Use

This combination is suitable for scenarios where:

- Multiple types of collections and traversal algorithms are needed.

- The system is expected to scale with new types of collections and iterators in the future.

- A unified and flexible traversal mechanism is required, without exposing the internal structure of collections to client code.

For smaller systems with fewer traversal needs, simpler patterns might suffice, as the added complexity may not be justified.

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
