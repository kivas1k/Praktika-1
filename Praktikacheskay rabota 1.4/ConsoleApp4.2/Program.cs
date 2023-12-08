using System.Globalization;

class Program
{
    static void Main()
    {
        double sum = 0;
        
        string content = File.ReadAllText(@"C:\Users\Kivi\Desktop\Praktika-1\Praktikacheskay rabota 1.4\ConsoleApp4.2\bin\Debug\net7.0\numsTask2.txt.txt");
        
        string[] num = content.Split(";");

        foreach (var el in num)
        {
            double value = double.Parse(el, CultureInfo.InvariantCulture);
            
            if (value == 0)
                break;

            if (value > 0)
                sum += value;
        }

        Console.WriteLine("Сумма элементов последовательности " + sum);
    }
}
