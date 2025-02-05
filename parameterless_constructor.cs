//Parameterless constructor
using System;
public class Student
    {
        int studentid;
        string studentname;
        Student()
        {
            studentid=0;
            studentname="Ram";
        }
        public static void Main()
        {
            Student s1=new Student();
            Console.WriteLine(s1.studentid);
            Console.WriteLine(s1.studentname);
        }
    
    }
