using System.Globalization;

namespace Program6
{
    class Program6
    {
        public static void Main()
        {
            /* Форумала для кода: ( y - 2 ) / -2.5 = x  */
            Console.WriteLine("Введите число a: "); 
            float numA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Введите число b: "); 
            float numB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (( ((numB - 2) / 2.5f) <= numA && ((numB - 2) / -2.5f) >= numA ) && (numB >= -3 && numB <= 2)) 
            {
                Console.WriteLine("Точка входит в эту область");
            }
            else
            {
                Console.WriteLine("Точка не входит в эту область");
            }
        }
    }
}