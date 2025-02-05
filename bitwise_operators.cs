//WAP to demonstrate the use of Bitwise Operators.

using System;
class BitwiseOperators
{
    public static void Main()
    {
        int a = 5, b = 3; 
       // 5 = 0101, 3 = 0011 in binary
        Console.WriteLine("a & b (AND) = " + (a & b));   
        // 0101 & 0011 = 0001 (1)
        Console.WriteLine("a | b (OR) = " + (a | b));    
        // 0101 | 0011 = 0111 (7)
        Console.WriteLine("a ^ b (XOR) = " + (a ^ b));   
        // 0101 ^ 0011 = 0110 (6)
        Console.WriteLine("~a (NOT) = " + (~a));         
        // ~0101 = 1010 (-6 in 2's complement)
        Console.WriteLine("b << 1 (Left Shift) = " + (b << 1)); 
        // 0011 << 1 = 0110 (6)
        Console.WriteLine("b >> 1 (Right Shift) = " + (b >> 1)); 
        // 0011 >> 1 = 0001 (1)
    }
}

