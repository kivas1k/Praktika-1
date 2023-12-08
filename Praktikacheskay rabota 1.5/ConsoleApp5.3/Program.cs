namespace Program3
{
    class Program
    {
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
        
        private static int SumBeforeIndex(ref int[] numbers, int beforeIndex)
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
            string pathInput = @"C:\Users\Kivi\Desktop\Praktika-1\Praktikacheskay rabota 1.5\ConsoleApp5.3\bin\Debug\net7.0\numsTask3.txt.txt";
            
            string text = File.ReadAllText(pathInput);
            
            int[] numbers = Array.ConvertAll(text.Split(" "), int.Parse);
            
            int indexMinNumber = IndexMinElement(ref numbers);
            
            float averageBeforeIndex = SumBeforeIndex(ref numbers, indexMinNumber) / (float)indexMinNumber;
            
            Console.WriteLine($"Результат: {averageBeforeIndex}");
        }
    }
}