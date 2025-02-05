//private constructor

//can we create an object of a class having private constructor. Show it with the help of program how can we access the fields & method of that class.
using System;
class Example {
    public static string name;
    public static int num;
    private Example() {
        Console.WriteLine("Private Constructor");
    }
    public Example(string a, int b) {
        name = a;
        num = b;
    }
}
class Example1 {
    static void Main() {
        Example obj1 = new Example("Ram", 2);
        Console.WriteLine(Example.name + ", " + Example.num);
    }
}
