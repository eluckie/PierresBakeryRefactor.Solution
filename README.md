# Pierre's Bakery

#### By E. Luckie ☀️

#### C# webpage application acting as an ordering medium for a faux bakery. Users are shown how much each bakery item costs and are able to input how many of each item they want. Their order and order total is then displayed back to them.

## Technologies Used

* C#
* Dotnet
* MSTest
* Markdown
* Git

## Description

This C# webpage application was created to demonstrate understanding of using TDD with C#, namespaces, classes, and auto-implemented properties. Once the application is ran via command in the computer's terminal, users are greeted by the bakery and displayed the prices of the baked goods available. Each baked good has the price for a singular item as well as sales for higher quantities. Pastries are buy 3 get 1 free, bread is buy 2 get 1 free. After reviewing the prices, users are asked if they would like to place an order or not. If they choose no, the application shows a goodbye message and exits. If they choose yes, they're prompted to enter their desired quantity of both pastries and bread. Once entered, the quantities are displayed back to the user to confirm. They're then able to confirm or reject the order.

* If user **confirms** the quantities: their order is calculated and displayed back to them. This includes the quantity & cost of each baked good and the grand total
* If user **rejects** the quantities: they're prompted to re-enter their quantities & the confirmation process restarts

Upon displaying their confirmed order and grand total, users are prompted to choose if they would like to create a new order or exit.

## Setup/Installation Requirements

1. Clone this repo
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called **PierresBakery**
3. In the command line, run the command ``dotnet watch run`` to compile and execute the console application in your browser in development mode
* This will also automatically run the _restore_ command to retrieve and install the necessary packages for this application
* Optionally, you can run ``dotnet build`` to compile this console app without running it

### To Run Tests
1. Navigate to this project's test directory called **PierresBakery.Tests**
2. If the project already hasn't been restored, run ``dotnet restore``
3. In the command line, run the command ``dotnet test`` to perform the tests and verify 100% pass-rate

## Known Bugs

* No known bugs.

## License

MIT License

Copyright (c) 2023 Luckie