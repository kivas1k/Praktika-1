class Program
{
    static void Main()
    {
        string filename = @"C:\Users\Kivi\Desktop\Praktika-1\Praktikacheskay rabota 1.6\ConsoleApp6.1\bin\Debug\net7.0\numsTask1.txt.txt";
        
        // Читаем слова из файла
        string[] words = File.ReadAllText(filename).Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Выводим все слова нечетной длины
        foreach (string word in words)
        {
            if (word.Length % 2 != 0)
            {
                Console.WriteLine(word);
            }
        }
    }
}