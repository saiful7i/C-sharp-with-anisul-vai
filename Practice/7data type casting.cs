using System;
class Program
{
    public static void Main(string[] args)
    {
        /* Implicit / Automatic conversion
        char -> int -> long -> float -> double 
        no data loss possibility 
        */
        int age = 23;
        Console.WriteLine(age);

        double age2 = age;
        Console.WriteLine(age2);
        Console.WriteLine(age2.GetType());

        /* explicit / Manual conversion
        double -> float -> long -> int -> char
        have data loss possibility 
        */

        double salary = 2583.43;
        Console.WriteLine(salary);

        int salary2 = (int)salary;
        Console.WriteLine(salary2);
        Console.WriteLine(salary2.GetType());

        //convert method
        string age3 = Convert.ToString(age2);
        Console.WriteLine(age3);
        Console.WriteLine(age3.GetType());

        //Parse Method to convert string into number

        string number = "24";
        Console.WriteLine(number);

        int number2 = int.Parse(number);
        Console.WriteLine(number2);
        Console.WriteLine(number2.GetType());

        //tryParse method to store the success result in vaiable
        bool isSucess = int.TryParse(number, out int result);
        Console.WriteLine(isSucess);

       Console.ReadKey();

    }

}
