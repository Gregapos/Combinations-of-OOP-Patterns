# Chain or Responsibility with Command (Handlers as Commands)

This project demonstrates the combination of the **Chain of Responsibility** and **Command** design patterns using **C#**, where handlers in the chain are treated as commands. This approach is particularly useful for creating pipelines, providing flexibility and adaptability in processing sequences.

## Design Patterns Overview

- **Chain of Responsibility**: The Chain of Responsibility pattern allows requests to pass through a chain of handlers, where each handler decides either to process the request or pass it to the next handler in the chain.

- **Command**: The Command pattern encapsulates all the information about an operation to be performed on data, in a standalone object

## Key Elements of the Combination

- **`BaseCommand`** Abstract Class: Defines the default behavior of all the chain handlers.

- **`ValidationCommand, TransformationCommand, EnrichmentCommand & FinalProcessingCommand`** Classes: Command types that represent different processing stages.

- **`DataRequest`** Class: Represent the data being processed.

## Benefits of the Combination

By combining the **Chain of Responsibility** and **Command** patterns, the following advantages are observed:

- **Separation of Concerns**: Each handler focuses on a specific operation, allowing for a clear separation of responsibilities. The overall flow is managed by the chain, leading to modular and maintainable code.

- **Extensibility**: Introducing new processing stages is straightforward. New commands can be added to the chain without significantly impacting the existing handlers, ensuring flexibility and scalability.

- **Dynamic Processing Pipelines**: The sequence of handlers in the chain can be dynamically adjusted at runtime, making it easy to modify the processing logic without altering the underlying structure.

- **Testability**: Since each handler (command) operates independently, testing individual processing steps is simplified. This helps ensure reliability and robustness.

## Considerations

While this approach offers numerous benefits, some trade-offs should be considered:

- **Performance Overhead**: Passing objects (requests) through multiple ICommand instances can introduce performance overhead, especially in cases where the chain is long or the operations are complex.

- **Complexity**: As the chain grows, keeping track of the order and dependencies between handlers can become challenging. Care should be taken to manage this complexity as the system evolves.

## When to Use

This combination is ideal in scenarios where there is a need for a flexible, modular, and maintainable processing pipeline, such as in:

- Systems that process a sequence of actions (e.g., data transformation pipelines).

- Situations where new processing stages need to be added dynamically without affecting the entire system.

- Scenarios where actions need to be executed in a specific order, but the order can be modified or extended at runtime.

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
