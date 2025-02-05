//WAP to understand the use of library functions.

using System;
class LibraryFunctions
{
    static void Main()
    {
        double num = -25.75;
        Console.WriteLine("Absolute value of num: " + Math.Abs(num));
        Console.WriteLine("Square root of 16: " + Math.Sqrt(16));
        Console.WriteLine("Power (2^3): " + Math.Pow(2, 3));
        Console.WriteLine("Ceiling of 4.3: " + Math.Ceiling(4.3));
        Console.WriteLine("Floor of 4.7: " + Math.Floor(4.7));
        Console.WriteLine("Round 3.5: " + Math.Round(3.5));
        Console.WriteLine("\n------ String Library Functions ------");
        string str = "Hello, World!";
        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Uppercase: " + str.ToUpper());
        Console.WriteLine("Lowercase: " + str.ToLower());
        Console.WriteLine("Substring (0, 5): " + str.Substring(0, 5));
        Console.WriteLine("String Length: " + str.Length);
        Console.WriteLine("Replaced String: " + str.Replace("World", "C#"));
        Console.WriteLine("\n------ DateTime Library Functions ------");
        DateTime currentDate = DateTime.Now;
        Console.WriteLine("Current Date and Time: " + currentDate);
        Console.WriteLine("Current Year: " + currentDate.Year);
        Console.WriteLine("Current Month: " + currentDate.Month);
        Console.WriteLine("Current Day: " + currentDate.Day);
        Console.WriteLine("Short Date Format: " + currentDate.ToShortDateString());
        Console.WriteLine("Long Date Format: " + currentDate.ToLongDateString());
    }
}

