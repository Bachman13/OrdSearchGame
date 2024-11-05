# Create the solution
dotnet new sln -n OrdSearchGameSolution


# Create the core library project (for game logic)
dotnet new classlib -n OrdSearchGame.Core
# Verkare inte behövas --> dotnet add HangmanGame.Core package System.Collections.Immutable


# Create the console application project
dotnet new console -n OrdSearchGame.ConsoleApp


# Create the test project using xUnit
dotnet new xunit -n OrdSearchGame.Tests
dotnet add OrdSearchGame.Tests package Shouldly


# Add project references
dotnet add OrdSearchGame.ConsoleApp reference OrdSearchGame.Core
dotnet add OrdSearchGame.Tests reference OrdSearchGame.Core


# Add the projects to the solution
dotnet sln OrdSearchGameSolution.sln add OrdSearchGame.Core/OrdSearchGame.Core.csproj
dotnet sln OrdSearchGameSolution.sln add OrdSearchGame.ConsoleApp/OrdSearchGame.ConsoleApp.csproj
dotnet sln OrdSearchGameSolution.sln add OrdSearchGame.Tests/OrdSearchGame.Tests.csproj
