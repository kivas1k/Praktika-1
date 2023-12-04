using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите положительное число a:");
        
        int a = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        
        while (a > 0)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number < 0)
            {
                break;
            }
            
            if (number % a == 0)
            {
                sum += number;
            }
        }
        
        Console.WriteLine("Сумма чисел, делящихся нацело на число a: " + sum);
    }
}