using System;
public class Student
{
    //value assign -decalaration + constructor
    public readonly int age ;

    public Student(int age)
    {
       this.age = age; //this key word use to refere current object
    }
}
public class MyClass
{
    public static void Main(string[] args)
    {
        Student s1 = new Student(30) ;
        //s1.age = 23;

        Console.WriteLine($"{s1.age}");
    }
}

