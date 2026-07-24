# C# and .NET Bootcamp

![C# and .NET Bootcamp](https://img.shields.io/badge/C%23-.NET-blue) 
![License](https://img.shields.io/badge/License-MIT-green)

Welcome to the **C# and .NET Bootcamp** repository, part of the [Zero to Mastery](https://claudiobernasconi.ch/dotnet-course) learning platform. This repo contains all the source code, projects, and examples you'll need to follow along with the course.

## Course Overview

This bootcamp is designed to teach you everything you need to know about C# and .NET development. Whether you're a complete beginner or looking to sharpen your skills, you'll learn through hands-on examples, coding projects, and comprehensive lessons.

> 📚 **Course Link**: [https://claudiobernasconi.ch/dotnet-course](https://claudiobernasconi.ch/dotnet-course)

### What You'll Learn:
- The .NET Platform
- C# Introduction
- Object-oriented Programming
- Intermediate C# Programming
- C# Arrays & Collections
- Advanced C#
- LINQ Fundamentals
- Automated Testing

## Getting Started
1. Clone the repository
2. Open the **ZTM.DotNet.sln** in Visual Studio or open the different projects in Visual Studio Code (or any other IDE).

## Branches & .NET Versions
C# and .NET fundamentals haven't changed for a long time. Since the unification of .NET with .NET 5 in 2020, the APIs haven't experienced many breaking changes.

* The **main** branch contains the code originally written for .NET 6 and .NET 7 as shown in the course.
* The **net10** branch contains the updated code for .NET 10. (There are only two code changes):
   * [Home.razor](/BlazorMudBlazor/Components/Pages/Home.razor) in the BlazorMudBlazor project (due to changes in `MudBlazor`)
   * [CalculatorTest.cs](/UnitTests/Calculator.cs) in the UnitTests project (due to changes in `MsTest`)