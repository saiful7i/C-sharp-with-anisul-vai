using System;

class Person
{
    public string name;
    public int age;
}
class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Md. Saiful Islma";
        p1.age = 23;
        Console.WriteLine($"Person 1. Name={p1.name} and age ={p1.age}");

        Person p2 = new Person();
        p2.name = "Anisul Islam";
        p2.age = 33;

        Console.WriteLine($"Person 2. Name = {p2.name} and age = {p2.age}");


    }

}
