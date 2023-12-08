class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое положительное число ");
        
        int n = Convert.ToInt32(Console.ReadLine());

        int product = 1;

        for (int i = 3; i <= n; i+=3)
        {
            product *= i;
        }
        Console.WriteLine("Ответ: " + product);
    }
}