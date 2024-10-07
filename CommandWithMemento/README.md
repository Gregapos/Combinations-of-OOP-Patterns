# Command with Memento

This project demonstrates the combination of the **Command** and **Memento** design patterns using **C#**. By combining these patterns, we can implement undoable operations while maintaining clear separation of concerns.

## Design Patterns Overview

- **Command**: The Command pattern turns a request into a stand-alone object that contains all information about the request.

- **Memento**: The Memento pattern captures and externalizes an object's internal state without violating encapsulation, so that the object can be restored to this state later.

## Key Elements of the Combination

- **`AddTextCommand`** Class: Command type that adds text to another text.
- **`CommandInvoker`** Class: Manages the execution of commands and stores mementos for undo operations, acting both as Invoker for the Command pattern and as Caretaker for the Memento pattern.
- **`Memento`** Class: Captures the internal state of an object so that it can be restored later.
- **`TextService`** Class: Acts as the Originator and maintains the content of the entire text.

## Benefits of the Combination

By combining the **Command** and **Memento** patterns, the following advantages are observed:

- **Undoable Operations**: This combination allows for the implementation of undoable commands, where the Memento pattern ensures that the system can revert to a previous state.

- **Separation of Concerns**: There is a clear separation between the invoker, which manages command execution, and the commands themselves. Each command is responsible for its own execution and undo logic, while the Memento handles the preservation of object states.

- **Scalability**: The system is highly maintainable and scalable. Adding new command types is straightforward, and implementing new undoable features only impacts the CommandInvoker class locally, without requiring significant changes elsewhere in the system.

## Considerations

Despite the benefits, there are some trade-offs:

- **Performance Overhead**: Managing multiple mementos can lead to performance overhead, particularly in terms of memory consumption and processing time. Each undoable command requires capturing and storing snapshots of the object’s state, which may affect the system’s responsiveness.

## When to Use

This combination is particularly useful in scenarios where undo functionality is required, such as text editors, graphics software, or any system that needs to revert to previous states. While the added overhead of memento management should be considered, the separation of concerns and support for undo operations make this approach a solid choice for scalable, maintainable systems.

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
