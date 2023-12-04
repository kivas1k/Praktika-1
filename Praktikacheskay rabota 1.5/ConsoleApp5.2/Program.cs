﻿using System.Globalization;
using System.IO;

namespace Program1
{
    class Program
    {
        public static void SortFloatArray(ref float[] arrayFloat)
        {
            for (int i = 0; i < arrayFloat.Length; ++i)
            {
                for (int j = 0; j < arrayFloat.Length - i - 1; ++j)
                { 
            
                    if (arrayFloat[j] > arrayFloat[j + 1])
                    {
                        float swap = arrayFloat[j];
                        arrayFloat[j] = arrayFloat[j + 1];
                        arrayFloat[j + 1] = swap;
                    }
                }
            }
    
        }
        public static void Main()
        {
            string pathInput = @"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.5\ConsoleApp5.2\bin\Debug\net7.0\numsTask2.txt.txt";

            StreamReader input = new StreamReader(pathInput);

            string[] stringNumbers = input.ReadLine().Split(";");

            float[] numbers = new float[stringNumbers.Length];

            for (int i = 0; i < stringNumbers.Length; i++)
            {
                numbers[i] = float.Parse(stringNumbers[i], CultureInfo.InvariantCulture);
            }

            input.Close();

            File.WriteAllText(pathInput, string.Empty);

            SortFloatArray(ref numbers);

            string write = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                write += ((i != numbers.Length - 1) ? $"{numbers[i]};" : $"{numbers[i]}").Replace(",", ".");
            }

            StreamWriter writer = new StreamWriter(pathInput);
            writer.WriteLine(write);

            writer.Close();
        }
    }
}