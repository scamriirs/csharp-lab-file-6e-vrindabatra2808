//write a program to show the use of this keyword in a class

using System;

class Person
{
    private string name;
    public Person(string name)
    {
        this.name = name;
    }
    public void ShowName()
    {
        Console.WriteLine("Name: " + this.name);
    }
    static void Main()
    {
        Person p = new Person("vrinda");
        p.ShowName();
    }
}
