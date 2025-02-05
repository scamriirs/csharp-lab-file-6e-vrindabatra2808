//WAP to find size of various datatypes.

using System;
public class Sizeofdatatypes
{
    public static void Main(string[] args)
    {
        int size_of_int= sizeof(int);
        Console.WriteLine ("Size of int datatype is " + size_of_int);
        float size_of_float = sizeof(float);
        Console.WriteLine("Size of float datatype is " +size_of_float);
        short size_of_short = sizeof(short);
        Console.WriteLine("Size of short datatype is " +size_of_short);
        long size_of_long = sizeof(long);
        Console.WriteLine("Size of long datatype is " +size_of_long);
        double size_of_double =sizeof(double);
        Console.WriteLine("Size of double datatype is "+size_of_double);
        uint size_of_uint=sizeof(uint);
        Console.WriteLine("Size of unsigned int is "+size_of_uint);
        byte size_of_byte=sizeof(byte);
        Console.WriteLine("Size of byte is "+size_of_byte);
        sbyte size_of_sbyte=sizeof(sbyte);
        Console.WriteLine("Size of signed byte is "+size_of_sbyte);
    }
}
