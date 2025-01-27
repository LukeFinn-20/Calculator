# Calculator Application

## Prototype Student C# project to build a basic UI interface to perform basic calculations through the console.

This project is a simple C# project to learn/implement the basics of C#. This project will perform the following actions:
...
* Perform addition, subtraction, multiplication, and division on multiple numbers.
* Interactive user interface with step-by-step input prompts.
* Input validation to ensure correct and meaningful data.
...
## What Each File Does
1. Main.cs
* Purpose: Entry point of the application.
* Description: Initializes and starts the user interface by invoking the UI class.

2. Program.cs
* Purpose: Contains the core calculator logic.
* Description: Defines a Calculator class with methods for:
  * Addition(int a, int b)
  * Subtraction(int a, int b)
  * Multiplication(int a, int b)
  * Division(int a, int b)
* Each method performs the corresponding arithmetic operation.

3. UIConsole.cs
* Purpose: Handles the user interface and input/output interactions.
* Description: Displays a menu to the user with options for operations. Prompts users to input numbers, validates them, and ensures at least two numbers are provided. Calls the Calculator methods to compute results and displays the outcome.
...
## How to install application
1. Ensure you have the .NET SDK installed on your machine.
  
2. Clone the repository:
  * git clone https://github.com/your-username/calculator-app.git
  * cd calculator-app
    
3. Build the project:
  * dotnet build
    
4. Run the application:
  * dotnet run
...
## Example Usage
1. Start the application.
2. Choose an operation from the menu:
   * Addition
   * Subtraction
   * Multiplication
   * Division
3. Enter numbers one at a time. Type done to finish entering numbers.
4. The application will compute and display the result.
...
## Basic Error Handling Examples
* Input Validation: Ensures correct user input for menu choices and numbers.
* Minimum Numbers: Requires at least two numbers for calculations.
* Division by Zero: Prevents division by zero through input validation.
...
## Potential Future Improvements
* Support for floating-point numbers.
* Additional operations such as modulus and exponentiation.
* Improved UI with a graphical interface.
