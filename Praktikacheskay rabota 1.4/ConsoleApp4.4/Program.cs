using System;
using System.IO;

class Program
{
    static void Main()
    {
        string file = @"C:\Users\gr622_sivvya\Desktop\Praktika 1\Praktikacheskay rabota 1.4\ConsoleApp4.4\bin\Debug\net7.0\numsTask4.txt.txt";
        
            string[] num = File.ReadAllLines(file)[0].Split(' ');

            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (i + 1 < num.Length && num[i + 1].Equals(""))
                {
                    break;
                }

                if ( i + 1 < num.Length && num[i].Equals(num[i + 1]))
                {
                    ++count;
                } 
                else if ( i - 1 >= 0 && num[i].Equals(num[i - 1]))
                {
                    ++count;
                }
            }
            Console.WriteLine("Количество одинаковых рядом стоящих чисел: " + count);
    }
}
