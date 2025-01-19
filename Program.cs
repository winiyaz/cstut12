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

        Console.ResetColor();
    }
}

