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
        private static int SumElDifferin1MaxNumber(ref int[] numbers, int indexMax)
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
            string pathInput = @"C:\Users\Kivi\Desktop\Praktika-1\Praktikacheskay rabota 1.5\ConsoleApp5.4\bin\Debug\net7.0\numsTask4.txt.txt";
            
            string inputText = File.ReadAllText(pathInput);
            
            int[] numbers = Array.ConvertAll(inputText.Split(" "), int.Parse);
            
            int indexMaxNumber = getIndexMaxElement(ref numbers);
            
            int MaxNumber = SumElDifferin1MaxNumber(ref numbers, indexMaxNumber);
            
            Console.WriteLine($"Результат: {MaxNumber}");
        }
    }
}