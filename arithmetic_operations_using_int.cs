//WAP to perform basic arithmetic operations using int datatype.
using System;
public class Operations
{
    public static void Main(string[] args)
    {
        int num1, num2, addition, subtraction, multiplication, division, modulus;
        Console.WriteLine("Enter the first number");
        num1 = Convert.ToInt32(Console.ReadLine());  
        Console.WriteLine("Enter the second number");
        num2 = Convert.ToInt32(Console.ReadLine());  
        addition = num1 + num2;
        Console.WriteLine("Addition: " + addition);
        subtraction= num1 - num2;
        Console.WriteLine("Subtraction: "+subtraction);
        multiplication= num1 * num2;
        Console.WriteLine(“Multiplication: "+multiplication);
        division= num1 / num2;
        Console.WriteLine("Division: "+division);
        modulus = num1%num2;
        Console.WriteLine("Modulus: "+modulus);
    }
}
