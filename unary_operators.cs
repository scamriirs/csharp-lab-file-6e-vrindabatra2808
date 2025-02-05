//WAP to demonstrate the use of Unary Operators.

using System;
class UnaryOperators
{
    static void Main()
    {
        int a,b;
        Console.WriteLine("Enter the value of a: ");
        a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b: ");
        b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Original value of a: " + a);
        Console.WriteLine("Original value of b: " + b);
        Console.WriteLine("Unary Plus (+a): " + (+a));
        Console.WriteLine("Unary Minus (-a): " + (-a));
        Console.WriteLine("Pre-increment (++a): " + (++a));
        Console.WriteLine("Post-increment (a++): " + (a++));  
        Console.WriteLine("After Post-increment, a: " + a);
        Console.WriteLine("Pre-decrement (--b): " + (--b));
        Console.WriteLine("Post-decrement (b--): " + (b--)); 
        Console.WriteLine("After Post-decrement, b: " + b);
    }
}

