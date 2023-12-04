using System.Globalization;
using System.IO;

namespace Program3
{
    class Program
    {
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

        private static int getSumBeforeIndex(ref int[] numbers, int beforeIndex)
        {
            int result = 0;

            for (int i = 0; i < beforeIndex; i++)
            {
                result += numbers[i];
            }

            return result;
        }

        public static void Main()
        {
            string pathInput = @"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.5\ConsoleApp5.3\bin\Debug\net7.0\numsTask3.txt.txt";

            StreamReader input = new StreamReader(pathInput);

            int[] numbers = Array.ConvertAll(input.ReadLine().Split(" "), int.Parse);

            input.Close();

            int indexMinNumber = getIndexMinElement(ref numbers);

            float averageBeforeIndex = getSumBeforeIndex(ref numbers, indexMinNumber) / (float)indexMinNumber;

            Console.WriteLine($"Результат: {averageBeforeIndex}");
        }
    }
}