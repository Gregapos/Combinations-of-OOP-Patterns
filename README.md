# Exploring Valuable Combinations and Applications of Object-Oriented Patterns

**Date of defense: April 10, 2024**

This repository contains the source code and documentation for my diploma thesis titled **"Exploring Valuable Combinations and Applications of Object-Oriented Patterns"**. The aim of the thesis is to investigate how various object-oriented design patterns can be combined to create scalable, maintainable, and modular software solutions. Each subproject demonstrates a unique combination of popular design patterns, showcasing how they work together to solve complex software design challenges.

## Project Structure

The repository is organized into subprojects, each of which explores a different combination of design patterns. Each folder contains the respective implementation, class diagram, and a README with explanations and instructions.

```bash
Combinations-of-OOP-Patterns
├───BuilderWithAbstractFactory
├───BuilderWithComposite
├───ChainOfResponsibilityWithComposite
├───CommandWithMemento
├───Command_Composite_State_Strategy_Singleton
├───CompositeWithVisitor
├───CoRWithCommand_1 (Handlers as Commands)
├───CoRWithCommand_2 (Requests as Commands)
├───IteratorWithComposite
└───IteratorWithFactory
```

## Subproject Descriptions

- **Builder with Abstract Factory**: Demonstrates how the Builder pattern can work in combination with Abstract Factory to create complex objects, whose individual elements may have different implementations.

- **Builder with Composite**: Explores the benefits of combining the Builder pattern with Composite to efficiently create tree structures.

- **Chain of Responsibility with Composite**: Shows how to use Chain of Responsibility with Composite for handling hierarchical request processing.

- **Command with Memento**: Combines Command and Memento patterns to allow undoable operations.

- **Command, Composite, State, Strategy, and Singleton**: A complex security system is built using these five patterns to manage hierarchical components, dynamic states, and flexible strategies.

- **Composite with Visitor**: Focuses on using Visitor with Composite for separating algorithms from the structure of an object hierarchy.

- **CoR with Command (Handlers as Commands)**: Illustrates how Chain of Responsibility works when handlers themselves are commands.

- **CoR with Command (Requests as Commands)**: Focuses on request processing where commands encapsulate request data.

- **Iterator with Composite**: Combines Iterator with Composite to traverse hierarchical structures uniformly.

- **Iterator with Factory Method**: Explores the combination of Iterator and Factory Method for flexible collection traversal.

## Design Patterns Covered

The following object-oriented design patterns are used in the various subprojects:

- Creational Patterns: Factory Method, Abstract Factory, Builder, Singleton.
- Structural Patterns: Composite
- Behavioral Patterns: Chain of Responsibility, Command, Iterator, Memento, State, Strategy, Visitor.

Each subproject provides a detailed implementation and illustrates the benefits of combining multiple design patterns to create more robust systems.

## How to Run

To explore a specific combination of patterns, navigate into the corresponding folder and follow the instructions in the respective README.md file. The instructions provide steps to build and run the projects using .NET.

## Thesis

For a detailed explanation of the research, refer to the full thesis, which is available in the University of the Peloponnese library [here](https://cs-msc.uop.gr/node/234).
