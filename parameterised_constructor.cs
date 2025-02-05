//Parameterised Constructor
using System;
public class Student
    {
        int studentid;
        string studentname;
        Student(int id, string s)
        {
            studentid=id;
            studentname=s;
        }
        public static void Main()
        {
            Student s1=new Student(2,"Ram");
            Console.WriteLine(s1.studentid);
            Console.WriteLine(s1.studentname);
        }
    
    }
