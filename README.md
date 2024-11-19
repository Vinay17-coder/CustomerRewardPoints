**Overview **:

The Rewards Points Web API is a .NET Core-based application designed to calculate customer reward points efficiently.

Features
Calculate Reward Points: Processes Customer transactions and calculates reward points based on  business logic.(e.g. a $120 purchase = 2x$20 + 1x$50 = 90 points).

RESTful Endpoints: Exposes endpoints for retrieving calculated Monthly and Total reward points for customer .
Scalable Design: Optimized for high performance, handling multiple customers or transactions concurrently.
Dependency Injection: Follows clean architecture principles with built-in dependency injection.

Technologies Used
Framework: .NET Core web api
Language: C#
Database: SQL Server (or any supported relational database)
DataSet: Used Json data for testing.
Asynchronous Programming: Task and Task.WhenAll
Tools: GitHub for version control

**Installation and Setup**

1.Clone the Repository

git clone [https://github.com/yourusername/rewards-points-webapi.gitcd rewards-points-webapi](https://github.com/Vinay17-coder/CustomerRewardPoints.git)

2.Build the Solution Open the solution in Visual Studio or use the .NET CLI:   
dotnet build

3.Run the Application :  
dotnet run

4.Access the API By default, the API will run on http://localhost:5000. Use tools like swagger or Postman to test endpoints.
