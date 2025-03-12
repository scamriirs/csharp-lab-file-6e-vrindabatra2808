//Creating and implementing an Indexer
using System;

class Student
{
    private int[] rollno = new int[10];

    public int this[int index]  
    {
        get
        {
            return rollno[index];
        }
        set
        {
            rollno[index] = value;
        }
    }
}

class Program  
{
    public static void Main()
    {
        Student s = new Student();
        s[0] = 1;
        s[1] = 2;
        s[2] = 3;  

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Roll no {0} : {1}", i, s[i]);  
        }
    }
}
