namespace Program2
{
    class Program2
    {
        public static void Main()
        {
            string path = @"C:\Users\Kivi\Desktop\Praktika-1\Praktikacheskay rabota 1.3\ConsoleApp3.2\bin\Debug\net7.0\nums.txt";
            
            string[] pathInput = File.ReadAllLines(path);
            
            File.WriteAllText(path, string.Empty);  // Очистка
            
            string write = string.Empty;    // Запись

            foreach (string num in pathInput[0].Split(" "))
            {
                if (num != "" && int.Parse(num) % 2 != 0)
                {
                    write += num + " ";
                }
            }
            File.WriteAllText(path, write);
        }
    }
}