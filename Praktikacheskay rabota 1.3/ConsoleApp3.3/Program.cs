namespace Program3
{
    class Program3
    {
        public static void Main()
        {
            string pathInput = @"C:\Users\Kivi\Desktop\Praktika-1\Praktikacheskay rabota 1.3\ConsoleApp3.3\bin\Debug\net7.0\Input.txt";
            
            int[] numbersInput;
            
            string[] input = File.ReadAllLines(pathInput);
            
            numbersInput = Array.ConvertAll(input[0].Split(" "), int.Parse);
            
            int maxVolume = MaxVolume(ref numbersInput);
            
            Console.WriteLine($"Максимальный возможный объем: {maxVolume}");
        }

        public static int MaxVolume(ref int[] numbersInput)
        {
            int result = 0;
            
            for (int i = numbersInput.Length - 1; i >= 0; --i)
            {
                for (int j = 0; j < i; j++)
                {
                    int minHeight = (numbersInput[i] < numbersInput[j]) ? numbersInput[i] : numbersInput[j];
                    
                    int resulFor = (i - j) * minHeight;
                    
                    if (resulFor > result)
                    {
                        result = resulFor;
                    }
                }
            }
            return result;
        }
    }
}