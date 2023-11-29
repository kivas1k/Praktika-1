using System;

namespace Program5
{
    class Program5
    {
        static void Main()
        {
            Console.WriteLine("Введите текст (слова разделяются одним пробелом): ");
            string textUser = Console.ReadLine().Trim(); 
            int countWord = 0;

            if (!string.IsNullOrEmpty(textUser))
            {
                string[] words = textUser.Split(' ');
                countWord = words.Length;

                textUser = $"Start {textUser} End";

                Console.WriteLine(textUser);
                Console.WriteLine($"Количество слов = {countWord}");
            }
            else
            {
                Console.WriteLine("Текст это пустая строка");
            }
        }
    }
}