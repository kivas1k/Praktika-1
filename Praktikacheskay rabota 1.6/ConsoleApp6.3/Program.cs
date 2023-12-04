using System;

class Program
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 && number % 10 == 0)
        {
            Console.WriteLine("Число четное и кратно 10");
        }
        else
        {
            Console.WriteLine("Число не является четным и кратным 10");
        }
    }
}