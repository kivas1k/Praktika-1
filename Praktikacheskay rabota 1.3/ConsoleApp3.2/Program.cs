using System;
using System.IO;

namespace Program2
{
    class Program2
    {
        public static void Main()
        {
            Console.WriteLine("Укажите точный путь до файла");

            string pathInput = Console.ReadLine();

            string stringNumbers = File.ReadAllText(pathInput);
            
            File.WriteAllText(pathInput, string.Empty);  // Очистка
            
            string write = string.Empty;    // Запись

            foreach (string num in stringNumbers.Split(" "))
            {
                if (num != "" && int.Parse(num) % 2 != 0)
                {
                    write += num + " ";
                }
            }

            File.WriteAllText(pathInput, write);
        }
    }
}