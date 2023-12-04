using System;
using System.IO;

class Program
{
    static void Main()
    {
// Чтение чисел из файла
        int[] numbers = ReadNumbersFromFile(@"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.5\ConsoleApp5.1\bin\Debug\net7.0\numsTask1.txt.txt");
// Поиск минимального числа
        int minIndex = FindMinIndex(numbers);
        if (minIndex >= 0)
        {
// Вычисление произведения элементов после минимального
            int product = CalculateProduct(numbers, minIndex);
            
            Console.WriteLine("Произведение элементов после минимального числа: " + product);
        }
        else
        {
            Console.WriteLine("Минимальное число не найдено");
        }
        Console.ReadLine();
    }
    static int[] ReadNumbersFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        int[] numbers = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            numbers[i] = int.Parse(lines[i]);
        }
        return numbers;
    }
    static int FindMinIndex(int[] numbers)
    {
        int minIndex = -1;
        int minValue = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
                minIndex = i;
            }
        }
        return minIndex;
    }
    static int CalculateProduct(int[] numbers, int startIndex)
    {
        int product = 1;

        for (int i = startIndex + 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}