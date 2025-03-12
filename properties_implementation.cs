// Demonstrating Read-Only Property
using System;
class Program
{
    private int r = 32;
    public int Roll_no
    {
        get { 
          return r; 
        }
    }
    public static void Main(String[] args)
    {
        Program obj = new Program();
        Console.WriteLine("Roll no: " + obj.Roll_no);
    }
}
