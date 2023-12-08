class Program
{
    static void Main()
    {
        string filename = @"C:\Users\Kivi\Desktop\Praktika-1\Praktikacheskay rabota 1.5\ConsoleApp5.1\bin\Debug\net7.0\numsTask1.txt.txt";
        
        string numbersText = File.ReadAllText(filename);
        
        string[] numbersArray = numbersText.Split(' ');
        
        int[] numbers = Array.ConvertAll(numbersArray, int.Parse);
        
        int minIndex = FindMinIndex(numbers);
        
        if (minIndex >= 0)
        {
            int product = CalculateProduct(numbers, minIndex);
            
            Console.WriteLine("Произведение элементов после минимального числа: " + product);
        }
        else
        {
            Console.WriteLine("Минимальное число не найдено");
        }
        Console.ReadLine();
    }
    
    static int FindMinIndex(int[] numbers)
    {
        int minIndex = -1;
        
        int minValue = int.MaxValue;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
                
                minIndex = i;
            }
        }
        return minIndex;
    }
    
    static int CalculateProduct(int[] numbers, int startIndex)
    {
        int product = 1;
        for (int i = startIndex + 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}