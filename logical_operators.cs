//WAP to demonstrate the use of logical operators.


using System;
class LogicalOperators
{
    public static void Main()
    {
        bool a, b;
        
        Console.Write("Enter true or false for A: ");
        a = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Enter true or false for B: ");
        b = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("\nLogical AND (A && B): " + (a && b));
        Console.WriteLine("Logical OR (A || B): " + (a || b));
        Console.WriteLine("Logical NOT (!A): " + (!a));
        Console.WriteLine("Logical NOT (!B): " + (!b));
    }
}
