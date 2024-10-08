# Security System - Combining Command, Composite, State, Strategy & Singleton Patterns

This project presents the combination of five design patterns — **Command**, **Composite**, **State**, **Strategy**, and **Singleton** — as a use-case scenario to create a scalable and maintainable **security system** that supports hierarchical organization, dynamic state changes, and flexible response strategies to detected threats.

## Design Patterns Overview

- **Command**: This pattern encapsulates requests as objects, allowing different commands to be executed. In the security system, commands are used to manage the state of components.

- **Composite**: This pattern organizes objects into tree-like structures to represent part-whole hierarchies. In this system, the security components are organized into composite structures, where parent components influence their children.

- **State**: This pattern manages state transitions for security components. The components can be locked or unlocked, and their behavior is dictated by their current state.

- **Strategy**: This pattern allows dynamic switching of algorithms or behaviors. The security system can use different strategies to respond to security breaches, such as sounding an alarm or notifying the police.

- **Singleton**: The Singleton pattern ensures there is only one instance of a central control point.

## Key Elements of the Combination

- **`SecurityComponent`** Abstract Class and Subclasses (`Camera`, `MotionSensor`, `SecurityComponentZone`): They represent the core components of the security system, which can be part of a composite structure.

- **`ControlCenter`** Class: It is responsible for executing commands and managing response strategies.

- **`State`** Abstract Class and Subclasses (`LockedState`, `UnlockedState`): They represent the states of security components.

- **`BaseCommand`** Abstract Class and Subclasses (`LockCommand`, `UnlockCommand`): They represent operations performed on security components.

## Benefits of the Combination

- **Extensibility**: New components (cameras, sensors, zones) and response strategies can easily be added. Adding new states or commands affects only the relevant parts of the system.

- **Centralized Control**: The `ControlCenter` provides a single point of coordination, ensuring consistent and centralized management of the system.

- **Dynamic State and Strategy Management**: The system can adjust its state and strategies at runtime based on detected threats, offering enhanced flexibility.

- **Hierarchical Organization**: The Composite pattern enables structuring components into zones, which simplifies managing large, complex security systems.

## Considerations

- **Increased Complexity**: The combination of multiple patterns introduces complexity, particularly when managing many classes and interfaces. Careful design is required to maintain simplicity as the system grows.

- **Performance**: The use of multiple layers of abstraction may introduce performance overhead, especially when managing many components or dynamically switching states and strategies.

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
