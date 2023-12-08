class Program
{
    static void Main(string[] args)
    {
        // Создаем и заполняем массив со случайными дробными числами
        Random random = new Random();
        
        int length = random.Next(1, 10);
        
        double[] array = new double[length];
        
        for (int i = 0; i < length; i++)
        {
            array[i] = random.NextDouble() * (random.Next(0, 2) == 0 ? -1 : 1);
        }

        // Создаем два новых массива для положительных и отрицательных элементов
        List<double> positiveElements = new List<double>();
        
        List<double> negativeElements = new List<double>();

        // Разделяем элементы исходного массива на положительные и отрицательные
        foreach (double number in array)
        {
            if (number > 0)
            {
                positiveElements.Add(number);
            }
            else if (number < 0)
            {
                negativeElements.Add(number);
            }
        }

        // Выводим результаты
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.WriteLine("\nПоложительные элементы:");
        PrintArray(positiveElements.ToArray());

        Console.WriteLine("\nОтрицательные элементы:");
        PrintArray(negativeElements.ToArray());

        Console.ReadLine();
    }

    static void PrintArray(double[] array)
    {
        foreach (double number in array)
        {
            Console.Write(number + " ");
        }
    }
}