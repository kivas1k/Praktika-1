class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\Kivi\Desktop\Praktika-1\Praktikacheskay rabota 1.6\ConsoleApp6.2\bin\Debug\net7.0\numsTask2.txt.txt";
        
        string[] lines = File.ReadAllLines(filePath);

        // Создаем пустую строку
        string result = "";

        // Перебираем все строки
        foreach (string line in lines)
        {
            string[] words = line.Split(' ');
            
            foreach (string word in words)
            {
                result += word + " ";
            }
        }
        
        result = result.TrimEnd();

        // Выводим полученную строку
        Console.WriteLine(result);
    }
}