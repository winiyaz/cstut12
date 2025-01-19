/*
 Starting the course here 
 */

using System;

class Program
{
    // Main function which doesnt have an output but calling the function below it
    static void Main()
    {
        PrintToConsole();
        MyPrintaz(); // Car Graphic 
        VariableAndTypes();
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
        Console.ForegroundColor= ConsoleColor.DarkCyan;

        Console.WriteLine(@"
-----------------------
Variables and Types
-----------------------
");
        
        //Integer variables - Signed or Unsigned 
        int age = 20;
        Console.WriteLine(age);


        Console.ResetColor();
    }
}

