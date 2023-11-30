using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.3\ConsoleApp3.1\bin\Debug\net7.0\input.txt");

        string[] chosenNumbers = lines[0].Split(' ');

        int n = int.Parse(lines[1]);

        List<string> results = new List<string>(); // List для хранения результатов

        for (int i = 0; i < n; i++)
        {
            string[] ticketNumbers = lines[i + 2].Split(' '); // Разделение строк на числа 
            int count = 0;

            foreach (string num in ticketNumbers)
            {

                foreach (string num2 in chosenNumbers)
                {
                    if (num == num2)
                    {
                        ++count;
                        break;
                    }
                }
            }

            if (count >= 3)
            {
                results.Add("Lucky"); // Если билет выигрышный, сохраняем результат в List
            }
            else
            {
                results.Add("Unlucky"); // Если билет проигрышный, сохраняем результат в List
            }
        }

        File.WriteAllLines(@"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.3\ConsoleApp3.1\bin\Debug\net7.0\output.txt", 
            results.ToArray()); // Запись результатов в файл
    }
}