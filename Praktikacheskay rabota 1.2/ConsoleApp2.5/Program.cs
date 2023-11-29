using System;
using System.Collections.Generic;

namespace Program5
{
    class Program5
    {
        public static Random _rand = new Random();

        public static Dictionary<string, int[]> GetRandomFilledTemperatureDictionary()
        {
            Dictionary<string, int[]> temperatureYear = new Dictionary<string, int[]>();
            string[] months = 
            {
                "January", "February", "March",
                "April", "May", "June",
                "July", "August", "September",
                "October", "November", "December"
            };

            int[] averageTemperature = 
            {
                -16, -15, -7,
                3, 17, 20,
                23, 20, 11,
                0, -10, -15
            };

            for (int i = 0; i < 12; i++)
            {
                int[] monthTemperatures = new int[30];
                for (int j = 0; j < 30; j++)
                {
                    monthTemperatures[j] = _rand.Next(averageTemperature[i] - 10, averageTemperature[i] + 10);
                }
                temperatureYear.Add(months[i], monthTemperatures);
            }

            return temperatureYear;
        }

        public static Dictionary<string, int> GetAverageTemperaturePerMonth(Dictionary<string, int[]> temperatureYear)
        {
            Dictionary<string, int> averageTemperatures = new Dictionary<string, int>();

            foreach (var month in temperatureYear)
            {
                int sum = 0;
                foreach (var temp in month.Value)
                {
                    sum += temp;
                }
                int averageTemp = sum / month.Value.Length;
                averageTemperatures.Add(month.Key, averageTemp);
            }

            return averageTemperatures;
        }

        public static void Main()
        {
            Dictionary<string, int[]> temperatureYear = GetRandomFilledTemperatureDictionary();
            
            Dictionary<string, int> averageTemperatures = GetAverageTemperaturePerMonth(temperatureYear);

            Console.WriteLine("Average temperatures by month:");
            
            float averageTemperaturesYear = 0;
            
            foreach (var month in averageTemperatures)
            {
                Console.WriteLine($"{month.Key}: {month.Value}°C");
                averageTemperaturesYear += month.Value;
            }
            Console.WriteLine($"Average temperature for the year: {(int)(averageTemperaturesYear / 12)}°C");
        }
    }
}