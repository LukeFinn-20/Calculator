Calculator Application
Overview
This is a simple console-based calculator program written in C#. The application allows users to perform basic arithmetic operations, including addition, subtraction, multiplication, and division. Users can input multiple numbers and choose the desired operation from the provided menu.

Features
Perform addition, subtraction, multiplication, and division on multiple numbers.
Interactive user interface with step-by-step input prompts.
Input validation to ensure correct and meaningful data is provided.
Files
1. Main.cs
This file serves as the entry point of the application. It initializes and starts the user interface.

2. Program.cs
This file contains the core functionality of the calculator. It defines a Calculator class with the following methods:

Addition(int a, int b)
Subtraction(int a, int b)
Multiplication(int a, int b)
Division(int a, int b)
Each method performs the corresponding arithmetic operation.

3. UIConsole.cs
This file implements the user interface logic. It:

Welcomes the user and presents the menu options.
Accepts user input for selecting operations and entering numbers.
Validates inputs to ensure proper functionality.
Calls the appropriate methods from the Calculator class to perform calculations and displays the results.
How to Run
Ensure you have the .NET SDK installed on your machine.
Open the project directory in your terminal or IDE.
Build the project using:
bash
Copy
Edit
dotnet build
Run the application using:
bash
Copy
Edit
dotnet run
Example Usage
Start the application.
Choose an operation from the menu (e.g., 1 for addition).
Enter numbers one by one. Type "done" when you are finished.
The application will display the result of the operation on the entered numbers.
Error Handling
The application ensures valid user inputs for menu choices and numbers.
At least two numbers must be provided for the calculations to proceed.
Division by zero is handled gracefully by not allowing invalid inputs during number entry.
Improvements
The application can be further enhanced by:

Adding support for floating-point numbers.
Implementing additional operations like modulus, exponentiation, etc.
Improving the UI to include a graphical interface.
Adding localization support for multiple languages.
