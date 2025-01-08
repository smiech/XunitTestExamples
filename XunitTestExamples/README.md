# XunitTestExamples

## Overview
XunitTestExamples is a simple .NET 9 web application that provides weather forecasting and user management functionalities. It includes a RESTful API for handling weather forecasts and user data.

## Project Structure
```
XunitTestExamples
├── XunitTestExamples
│   ├── Controllers
│   │   └── WeatherForecastController.cs
│   ├── Models
│   │   ├── WeatherForecast.cs
│   │   └── User.cs
│   ├── Services
│   │   ├── WeatherService.cs
│   │   └── UserService.cs
│   ├── Program.cs
│   ├── XunitTestExamples.csproj
│   └── appsettings.json
├── XunitTestExamples.Tests
│   ├── Services
│   │   ├── WeatherServiceTests.cs
│   │   └── UserServiceTests.cs
│   ├── XunitTestExamples.Tests.csproj
└── README.md
```

## Setup Instructions
1. Clone the repository to your local machine.
2. Navigate to the project directory.
3. Restore the project dependencies by running:
   ```
   dotnet restore
   ```
4. Run the application using:
   ```
   dotnet run --project XunitTestExamples/XunitTestExamples.csproj
   ```
5. Access the API at `http://localhost:5000`.

## Features
- **Weather Forecasting**: Retrieve weather forecasts through the `WeatherForecastController`.
- **User Management**: Manage user data with the `UserService`.

## Testing
To run the tests, navigate to the test project directory and execute:
```
dotnet test XunitTestExamples.Tests/XunitTestExamples.Tests.csproj
```

## Technologies Used
- .NET 9
- C#
- ASP.NET Core

## License
This project is licensed under the MIT License.