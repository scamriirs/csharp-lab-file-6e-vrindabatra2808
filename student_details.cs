//WAP to simply print details including Student Name, Roll Number, Class Name, Semester, Subject Name and Project Idea.
using System;
class StudentDetails
{
    static void Main(string[] args)
    {
        string name, rollNumber, className, semester, subjectName,   projectName;
        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter your roll number: ");
        rollNumber = Console.ReadLine();
        Console.WriteLine("Enter your class name: ");
        className = Console.ReadLine();
        Console.WriteLine("Enter your semester: ");
        semester = Console.ReadLine();
        Console.WriteLine("Enter your subject name: ");
        subjectName = Console.ReadLine();
        Console.WriteLine("Enter your project idea:");
        projectName = Console.ReadLine();
        Console.WriteLine("Details are: ");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Class: " + className);
        Console.WriteLine("Semester: " + semester);
        Console.WriteLine("Subject: " + subjectName);
        Console.WriteLine("Project Idea: " + projectName); 
    }
}
