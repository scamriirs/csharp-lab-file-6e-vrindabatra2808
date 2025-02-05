//WAP to demonstrate the use of Assignment Operators.


using System;
class AssignmentOperators
{
    public static void Main()
    {
        int x;
        Console.WriteLine("Enter the value of x: ");
        x=Convert.ToInt32(Console.ReadLine());
        x += 5;  
        Console.WriteLine("After x += 5: " + x);
        x -= 3;  
        Console.WriteLine("After x -= 3: " + x);
        x *= 2;  
        Console.WriteLine("After x *= 2: " + x);
        x /= 4;  
        Console.WriteLine("After x /= 4: " + x);
        x %= 3;  
        Console.WriteLine("After x %= 3: " + x);
    }
}

