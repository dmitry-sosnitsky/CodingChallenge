# CodingChallenge
Paymentsense coding challenge

## The task
Display the list of countries from RestCountries API


## The solution

**Technologies and frameworks used:**

*Back-end:*

1) ASP.NET Core — provides the means to handle HTTP requests, easily serialize/deserialize data, and perform dependency injection
2) RestSharp — a HTTP client library for communication with REST APIs
3) NUnit, Moq & FluentAssertions — for unit testing

*Front-end:*

1) Angular
2) Angular Grid — for grid with pagination
3) Jasmine, Karma — for unit testing


**Running the project**

*Back-end:*

Prequisites: VisualStudio 2019, .NET Core 3.1 installed
Steps to run:
1) Open `Paymentsense.Coding.Challenge.Api.sln` in VisualStudio
2) Set `Paymentsense.Coding.Challenge.Api` as startup project
3) Select `IIS Express` profile for Windows, or `Paymentsense.Coding.Challenge.Api` for non-Windows
4) Ctrl+F5 to launch the project at `http://localhost:44341/`

*Front-end:*

Prequisites: NPM
Steps to run:
1) Open `paymentsense-coding-challenge-website` folder
2) Run `npm install` in command line
3) Run `npm start` in command line