//WAP to demonstrate the use of relational operators.

using System;
class RelationalOperators
{
    static void Main(string[] args)
    {
        int x, y;
        Console.Write("Enter the value of x: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value of y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x and y are equal: " + (x == y));
        Console.WriteLine("x is not equal to y: " + (x != y));
        Console.WriteLine("x is greater than y: " + (x > y));
        Console.WriteLine("y is greater than x: " + (x < y));
        Console.WriteLine("x is greater than or equal to y: " + (x >= y));
        Console.WriteLine("y is greater than or equal to x: " + (y >= x)); 
    }
}
