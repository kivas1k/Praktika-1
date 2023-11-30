using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int[] numbers = new int [10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100);
        }
        int minValue = numbers[0];
        int minIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
                minIndex = i;
            }
        }
        Console.WriteLine("Индекс минимального элемента: " +  minIndex);
    }
}
