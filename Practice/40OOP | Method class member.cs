using System;

class Person
{
    public string name;
    public int age;

    public void SetValue(string n,int a)
    {
        name = n;
        age = a;

    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Person Name: {name} and age: {age}");

    }
}
class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        //p1.name = "Md. Saiful Islma";
        //p1.age = 23;
        p1.SetValue("Md.Saiful Islam", 23);
        //Console.WriteLine($"Person 1. Name={p1.name} and age ={p1.age}");
        p1.DisplayInfo();

        Person p2 = new Person();
        //p2.name = "Anisul Islam";
        //p2.age = 33;
        p2.SetValue("Anisul Islam", 33);

        //Console.WriteLine($"Person 2. Name = {p2.name} and age = {p2.age}");
        p2.DisplayInfo();


    }

}
