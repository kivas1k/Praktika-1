using System.Globalization;

namespace Program5
{
    class Program5
    {
        public static void Main()
        {
            Console.WriteLine("Введите число a: "); 
            
            float numA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Введите число b: "); // y
            
            float numB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ((numA >= -1 && numA <= 3) && (numB >= -2 && numB <= 4))
            {
                Console.Write("Точка входит в эту область");
            }
            else
            {
                Console.Write("Точка не входит в эту область");
            }
        }
    }
}