# Pratik Dependency Injection Example

This project demonstrates a simple **Dependency Injection** implementation using .NET Core. The example includes two classes: `Teacher` and `Classroom`. The `Classroom` class depends on an instance of the `Teacher` class, which is injected via **constructor injection**.

## Project Structure

- **Models**
  - `ITeacher`: A base interface for the `Teacher` class.
  - `Teacher`: A class that implements the `ITeacher` interface. It contains the teacher's first and last name.
  - `Classroom`: A class that receives a `Teacher` instance through dependency injection and can return the teacher's information.

- **Controllers**
  - `ClassRoomController`: An API controller that provides a GET endpoint to fetch the teacher's info.

## Features

- **Constructor Injection**: The `Teacher` class is injected into the `Classroom` class via its constructor.
- **Interface Abstraction**: The `ITeacher` interface allows us to inject any class that implements the teacher logic, promoting loose coupling.
- **API Endpoint**: A REST API endpoint to retrieve teacher information.
