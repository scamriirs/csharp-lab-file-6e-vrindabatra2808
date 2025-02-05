//static constructor
using System;
class Example
{
static Example()
{
    Console.WriteLine("Static Constructor");
}
Example()
{
    Console.WriteLine("Non-Static Constructor");
}
public static void Main()
{
    Example e1=new Example();
    Example e2=new Example();
}
}
