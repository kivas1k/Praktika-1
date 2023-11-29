using System;

namespace Program4
{
    class Program4
    {
        public static Random _rand = new Random();

        public static float[,] GetRandomFilledMatrixTemperatureYear()
        {
            float[,] temperatureYear = new float[12, 30];
            int[] averageTemperature =
            {
                -16, -15, -7,
                3, 17, 20,
                23, 20, 11,
                0, -10, -15
            };
            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 30; ++j)
                {
                    temperatureYear[i, j] = _rand.Next(averageTemperature[i] - 10, averageTemperature[i] + 10);
                }
            }
            return temperatureYear;
        }
        public static float[] GetArrAverageTemperaturesMonths(ref float[,] matrixYear)
        {
            float[] averageTemperaturesMonths = new float[12];
            for (int i = 0; i < 12; ++i)
            {
                float averageTemperatureMonth = 0;
                for (int j = 0; j < 30; ++j)
                {
                    averageTemperatureMonth += matrixYear[i, j];
                }
                averageTemperaturesMonths[i] = averageTemperatureMonth / 30;
            }
            return averageTemperaturesMonths;
        }

        public static void SortArrFloat(ref float[] arrFloat)
        {
            Array.Sort(arrFloat);
        }

        public static void Main()
        {
            float[,] temperatureYear = GetRandomFilledMatrixTemperatureYear();
            float[] averageTemperaturesMonths = GetArrAverageTemperaturesMonths(ref temperatureYear);
            SortArrFloat(ref averageTemperaturesMonths);
            float averageTemperaturesYear = 0;

            Console.WriteLine("Sorted array of average temperatures by month:");
            foreach (float temperature in averageTemperaturesMonths)
            {
                Console.WriteLine($"{(int)temperature}°C"); // Приведение к целому числу для отображения целых чисел
                averageTemperaturesYear += temperature;
            }

            Console.WriteLine($"Average temperature for the year: {(int)(averageTemperaturesYear / 12)}°C"); // Приведение к целому числу для отображения целых чисел
        }
    }
}