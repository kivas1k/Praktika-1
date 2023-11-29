using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> elements = new List<string>();

        string input;
        do
        {
            Console.WriteLine("Введите элемент списка");
            input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                elements.Add(input);
            }

        } while (!string.IsNullOrEmpty(input));

        if (elements.Count > 0)
        {
            string shortest = elements[0];
            string longest = elements[0];

            foreach (string element in elements)
            {
                if (element.Length < shortest.Length)
                {
                    shortest = element;
                }

                if (element.Length > longest.Length)
                {
                    longest = element;
                }
            }

            Console.WriteLine("Самый короткий элемент: " + shortest);
            Console.WriteLine("Самый длинный элемент: " + longest);
        }
    }
}