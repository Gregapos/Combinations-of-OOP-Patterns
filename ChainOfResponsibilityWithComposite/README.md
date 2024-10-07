# Chain of Responsibility with Composite

This project demonstrates the combination of the **Chain of Responsibility** and **Composite** design patterns using **C#**. By combining these patterns, we simplify the management of event propagation and processing within nested hierarchies.

## Design Patterns Overview

- **Chain of Responsibility**: The Chain of Responsibility pattern allows for passing events - requests along a chain of nodes - handlers (The event is passed from a node, to it's parent node). Each handler can either process the request or pass it to the next handler in the chain.
- **Composite**: The Composite pattern provides a unified interface to manage both composite (objects that contain other objects) and leaf objects (individual objects). It allows clients to treat individual objects and compositions of objects uniformly, in order to serve the event propagation mechanism.

## Key Elements of the Combination

- **`UIComponent`** Abstract Class: Represents all the UI component types and contains a \_handleableEvents list that maintains the events that each component can handle by itself.
- **`Button & Panel`** Classes: Implementions for the leaf and composite objects respectively.

## Benefits of the Combination

By combining the **Chain of Responsibility** and **Composite** patterns, the following advantages are observed:

- **Efficient Event Handling**: This combination allows for the creation of hierarchical structures where each UI element can handle events or pass them along the chain. Events are propagated through the hierarchy, enabling flexible and modular event management.

- **Scalability**: The system is highly scalable. New UI elements and event handling capabilities can be introduced without requiring significant changes to the existing codebase. New elements only need to implement the appropriate classes, and new event types affect only the relevant elements.

- **Modularity**: The system remains modular, with each UI element responsible for its own event handling. The Composite pattern ensures that new elements can be easily added to the hierarchy, while the Chain of Responsibility allows event handling to be distributed.

## Considerations

Despite the benefits, there are some trade-offs:

- **Tracking Event Propagation**: In deep hierarchies, tracking the propagation path of events may become difficult, especially when events are passed through multiple elements in the chain. This can make debugging and understanding the flow of event handling more challenging.

- **Performance Overhead**: In cases where there are deep hierarchies of elements, the propagation of events through many layers may impact performance, as each element in the chain must be checked to determine if it should handle the event.

## When to Use

This combination is particularly useful in scenarios involving complex user interfaces with hierarchical structures where different elements need to handle different events. For example, it is effective in GUI systems, where nested components must process user inputs or system events. However, in cases of simpler structures or where performance is critical, the added complexity of event propagation through deep hierarchies should be carefully considered.

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
