/*
 Starting the course here 
 */

class Program
{
    // Main function which doesnt have an output but calling the function below it
    static void Main()
    {
        PrintToConsole();
        MyPrintaz(); // Car Graphic 
        VariableAndTypes(); // Printing Variable types
        MathOpers(); //Math Operations
        ComparisonOpes(); // Comparison operator testin
    }

    // These functions will be called in Main()
    static void PrintToConsole()
    {
        Console.WriteLine("Print-To-Console: Printed");
    }

    // This is my function
    static void MyPrintaz()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@"
Greeningz -- Zoom...zoom...zoom
  -           __
 --          ~( @\   \
---   _________]_[__/_>________
     /  ____ \ <>     |  ____  \
    =\_/ __ \_\_______|_/ __ \__D
________(__)_____________(__)____

");
        Console.ResetColor();
    }

    // Variables Testing
    static void VariableAndTypes()
    {
        // Understanding data datypes here 
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine(@"
-----------------------
Variables and Types
-----------------------
");

        Console.WriteLine(@"
----
Integet Types - Basic
----

");

        //Integer variables - Signed or Unsigned 
        int age = 20;
        Console.WriteLine($"Fetish Misterss Age : {age}");

        // Decimal Point number - Float is faster for running
        float temp = 20.4f;
        Console.WriteLine($"Temperature of punnai : {temp}");

        // Double datatype precision 
        double interestOnLoans = 5.5923;
        Console.WriteLine($"Interest Rates (Double): {interestOnLoans}");

        // Decimal Value 
        decimal stockPrice = 4.33245M;
        Console.WriteLine($"Current Stock Price (Decimal DataType): {stockPrice}");

        // --- New Section --- 
        Console.WriteLine(@"
----
Character types
----

");
        // Character 
        char grade = 'A';
        Console.WriteLine($"Grade Got : {grade}");

        // String variable 
        string nameS = "Niki";
        Console.WriteLine($"Fetish Mistress - {nameS}");

        // --- New Section --- 
        Console.WriteLine(@"
----
Conditiional Logic - Testing conditional logic here
----

");
        // Boolean test - Definng the coniditional logic here
        bool isStudent = true;
        Console.WriteLine(isStudent);

        // --- New Section --- 
        Console.WriteLine(@"
----
Empty Variable definitions - 
----

");
        // Defining an empty variable here for later assignment
        int quantity;
        string product;
        quantity = 5;
        product = "thong";
        Console.WriteLine($"Quanity is {quantity} , product is {product}");

        // --- New Section --- 
        Console.WriteLine(@"
----
Constants - Similar to Constant Value definitions
----

");
        // This is the constant definition
        const double piValue = 3.15;
        Console.Write($"Const piValue = {piValue}");

        Console.ResetColor();
    }

    // Teting math operations
    static void MathOpers()
    {
        // Setting color for this section 
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine(@"
***
Math Operations test
***
");

        double num1 = 6.63587485;
        double num2 = 9.6958744563;

        double addNums = num1 + num2;
        double subNums = num1 - num2;
        double mulNums = num1 * num2;
        double modulusNums = num1 % num2;

        Console.WriteLine($"ADD = Num1={num1} + Num2={num2} = {addNums} ");
        Console.WriteLine($"SUB = Num1={num1} - Num2={num2} = {subNums} ");
        Console.WriteLine($"MUL = Num1={num1} * Num2={num2} = {mulNums} ");
        Console.WriteLine($"Modulus = Num1={num1} % Num2={num2} = {modulusNums} ");

        Console.WriteLine(@"
-----------------------
Handling Division by zero
-----------------------
");

        int num3 = 3;
        int num4 = 0;

        // Try Catch blocks similar to py
        try
        {
            int quot = num3 / num4;
            Console.WriteLine($"Division by zero test {quot}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Stupid Bastard! :" + ex.Message);
        }

        Console.WriteLine(@"
-----------------------
Type Casting
-----------------------
");
        // Casting int to double

        int num6 = 69;
        double num6AsDouble = (Double)num6;
        Console.Write($"num6 = {num6.GetType()} - casted as {num6AsDouble.GetType()}");

        // Reset the color
        Console.ResetColor();
    }

    // Testing comparison operators 
    static void ComparisonOpes()
    {

        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine(@"


***
Comparison Operators
***
");

        // Testing the comparison operators here

        int a = 10;
        int b = 5;

        bool isEqual = (a == b);
        Console.WriteLine($"Is {a} equal to {b} : {isEqual}");

        // checking inequality 
        bool isNotEqual = (a != b);
        Console.WriteLine($"Is {a} not equal to {b} : {isNotEqual}");

        bool isGreaterThanOrEqual = (a >= b);
        Console.WriteLine($"Is {a} greater than or equal to {b} : {isGreaterThanOrEqual}");

        bool isLessThanOrEqual = (a <= b);
        Console.WriteLine($"Is {a} less than or equal to {b} : {isLessThanOrEqual}");

        Console.WriteLine(@"
-----------------------
Logical Operators
-----------------------
");


        Console.ResetColor();
    }
}

