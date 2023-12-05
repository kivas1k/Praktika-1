using System;
using System.IO;

class Program
{
    static void Main()
    {
        
        string content = File.ReadAllText(@"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.4\ConsoleApp4.3\bin\Debug\net7.0\numsTask3.txt.txt");
        
        string[] numbers = content.Split(',');
        
        int min = int.MaxValue;
        int max = int.MinValue;

// Проходим по каждому числу в массиве и находим минимальное и максимальное число
        foreach (string number in numbers)
        {
            int num = int.Parse(number);

            if (num == 0)
            {
                break;
            }

            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }
        }
// Проверяем, что минимальное и максимальное числа не остались равными и 0 не было найдено
        if (min != int.MaxValue && max != int.MinValue)
        {
            double ratio = (double) min / max;
            
            Console.WriteLine($"Отношение минимального и максимального чисел: {ratio}");
        }
        else
        {
            Console.WriteLine("Файл не содержит подходящих чисел");
        }
    }
}