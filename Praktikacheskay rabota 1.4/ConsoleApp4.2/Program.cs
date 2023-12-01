using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main()
    {
        double sum = 0;
        using (StreamReader reader = new StreamReader(@"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.4\ConsoleApp4.2\bin\Debug\net7.0\numsTask2.txt.txt"))

        {
            string line = reader.ReadLine();
            string[] num = line.Split(";");

            foreach (var el in num)
            {
                double value = double.Parse(el, CultureInfo.InvariantCulture);
                
                if (value == 0)
                    break;

                if (value > 0)
                    sum += value;
            }
        }

        Console.WriteLine("Сумма элементов последовательности " + sum);
    }
}
