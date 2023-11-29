using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Введите числа. Введите 0, чтобы закончить ввод.");
        while (true)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
                break;
            numbers.Add(number);
        }

        int sum = 0;
        int product = 1;
        foreach (int number in numbers)
        {
            sum += number;
            product *= number;
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"Сумма всех чисел: {sum}");
        Console.WriteLine($"Произведение всех чисел: {product}");
        Console.WriteLine($"Среднее значение: {average}");
    }
}