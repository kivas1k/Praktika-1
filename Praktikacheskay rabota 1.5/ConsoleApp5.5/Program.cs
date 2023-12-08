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
        private static int IndexMinElement(ref int[] numbers)
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
            float average = 0;
            
            for (int i = startIndex + 1; i < endIndex; i++)
            {
                average += numbers[i];
            }
            return average / (endIndex - startIndex - 1);
        }
        public static void Main()
        {
            string pathInput = @"C:\Users\Kivi\Desktop\Praktika-1\Praktikacheskay rabota 1.5\ConsoleApp5.5\bin\Debug\net7.0\numsTask5.txt.txt";
            
            string inputText = File.ReadAllText(pathInput);
            
            int[] numbers = Array.ConvertAll(inputText.Split(" "), int.Parse);
            
            int indexMaxElement = getIndexMaxElement(ref numbers);
            
            int indexMinElement = IndexMinElement(ref numbers);
            
            int startIndex = Math.Min(indexMinElement, indexMaxElement);
            
            int endIndex = Math.Max(indexMinElement, indexMaxElement);
            
            float averageBetweenMinMaxElement = getAverageBetween(ref numbers, startIndex, endIndex);
            
            Console.WriteLine($"Среднее арифметическое между минимальным и максимальным: {averageBetweenMinMaxElement}");
        }
    }
}