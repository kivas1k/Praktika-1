using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Путь к файлу с числами
        string filePath = @"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.6\ConsoleApp6.2\bin\Debug\net7.0\numsTask2.txt.txt";

        // Считываем все строки из файла
        string[] lines = File.ReadAllLines(filePath);

        // Создаем пустую строку
        string result = "";

        // Перебираем все строки
        foreach (string line in lines)
        {
            // Добавляем каждое слово в строку, разделяя пробелами
            // Можно сделать string.Join(" ", words);

            string[] words = line.Split(' ');
            foreach (string word in words)
            {
                result += word + " ";
            }
        }

        // Удаляем лишний пробел в конце строки
        result = result.TrimEnd();

        // Выводим полученную строку
        Console.WriteLine(result);
    }
}