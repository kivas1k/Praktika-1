using System.Globalization;
using System.IO;

namespace Program4
{
    class Program4
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

        private static int getSumElDifferin1MaxNumber(ref int[] numbers, int indexMax)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[indexMax] - numbers[i] == 1)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public static void Main()
        {
            string pathInput = @"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.5\ConsoleApp5.4\bin\Debug\net7.0\numsTask4.txt.txt";

            StreamReader input = new StreamReader(pathInput);

            int[] numbers = Array.ConvertAll(input.ReadLine().Split(" "), int.Parse);

            input.Close();

            int indexMaxNumber = getIndexMaxElement(ref numbers);

            int sumElDifferin1MaxNumber = getSumElDifferin1MaxNumber(ref numbers, indexMaxNumber);

            Console.WriteLine($"Результат: {sumElDifferin1MaxNumber}");
        }
    }
}