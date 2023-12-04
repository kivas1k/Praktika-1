using System.Globalization;
using System.IO;

namespace Program5
{
    class Program5
    {
        private static int getIndexMaxElement(ref int[] numbers)
        {
            int indexMax = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[indexMax] < numbers[i])
                {
                    indexMax = i;
                }
            }

            return indexMax;
        }

        private static int getIndexMinElement(ref int[] numbers)
        {
            int indexMin = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[indexMin] > numbers[i])
                {
                    indexMin = i;
                }
            }

            return indexMin;
        }

        private static float getAverageBetween(ref int[] numbers, int startIndex, int endIndex)
        {
            float verage = 0;

            for (int i = startIndex + 1; i < endIndex; i++)
            {
                verage += numbers[i];
            }


            return verage / (endIndex - startIndex - 1);
        }

        public static void Main()
        {
            string pathInput = @"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.5\ConsoleApp5.5\bin\Debug\net7.0\numsTask5.txt.txt"; // Указываем путь до файла в коде

            StreamReader input = new StreamReader(pathInput);

            int[] numbers = Array.ConvertAll(input.ReadLine().Split(" "), int.Parse);;

            input.Close();

            int indexMaxElement = getIndexMaxElement(ref numbers);
            int indexMinElement = getIndexMinElement(ref numbers);

            int startIndex = Math.Min(indexMinElement, indexMaxElement);
            int endIndex = Math.Max(indexMinElement, indexMaxElement);

            float averageBetweenMinMaxElement = getAverageBetween(ref numbers, startIndex, endIndex);

            Console.WriteLine($"Среднее арифметическое между минимальным и максимальным: {averageBetweenMinMaxElement}");
        }
    }
}