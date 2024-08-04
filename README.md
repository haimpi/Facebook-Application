# Facebook-Application

## Overview
BasicFacebookFeatures is a C# application that provides various functionalities to interact with Facebook using the [Facebook SDK](https://github.com/facebook-csharp-sdk/facebook-csharp-sdk). This application includes features such as user login, check-in tracking, friend matching, and more. It is designed to provide a simple interface for users to manage and interact with their Facebook data.

## Features

### AppSettings
The `AppSettings` class handles the storage and retrieval of application settings, including the last access token and whether the user chose to be remembered.

### CheckinsFinder
The `CheckinsFinder` functionality allows users to search for check-ins made by their friends based on specific criteria such as location and date.

### FriendMatcher
The `FriendMatcher` feature provides a way to find the best matching friends based on specific criteria such as gender, age, location, and liked pages.

### MainForm
The main form (`FormMain`) serves as the entry point of the application, providing options to log in, view basic information, post statuses, and more.

## Design Patterns

The project makes use of several design patterns to ensure a clean, maintainable, and scalable codebase:

- **Strategy Pattern**: 
  - Implemented in the `IFriendScoreStrategy` interface and its implementations (`LikedPagesScoreStrategy`, `LocationScoreStrategy`). This pattern allows the application to select different scoring strategies for matching friends based on various criteria.

- **Facade Pattern**: 
  - Implemented in the `CheckinsFinderService` and `FriendMatcherService` classes. These services provide a simplified interface to the complex subsystems involved in finding check-ins and matching friends, respectively.

- **Iterator Pattern**: 
  - Implemented in the `CheckinInfoIterator` and related classes. This pattern provides a way to access the elements of a collection (like check-ins) sequentially without exposing the underlying representation.

## Project Structure

- **AppSettings.cs**: Manages application settings.
- **CheckinInfo.cs**: Represents information about a check-in.
- **CheckinsFinderLogic.cs**: Contains logic to filter check-ins.
- **FriendMatcherLogic.cs**: Implements logic for matching friends based on various criteria.
- **FormCheckinsFinder.cs**: User interface for the CheckinsFinder feature.
- **FormFriendMatcher.cs**: User interface for the FriendMatcher feature.
- **FormLogin.cs**: Handles user login and authentication.
- **FormMain.cs**: Main interface of the application.
- **IFriendScoreStrategy.cs**: Interface for different friend score strategies.
- **LikedPagesScoreStrategy.cs**: Scoring based on liked pages.
- **LocationScoreStrategy.cs**: Scoring based on location.
- **CheckinInfoIterator.cs**: Iterator for check-in information.
- **IAggregate.cs**: Interface for creating iterators.
- **IIterator.cs**: Interface for iterators.
- **CheckinsFinderService.cs**: Service class for CheckinsFinder logic.
- **FriendMatcherService.cs**: Service class for FriendMatcher logic.
- **LoginService.cs**: Handles the login and authentication process.
- **MainService.cs**: Central service class for various functionalities.
