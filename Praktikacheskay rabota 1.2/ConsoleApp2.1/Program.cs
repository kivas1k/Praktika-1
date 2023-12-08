class Program
{
    static void Main(string[] args)
    {
        int[] collection = new int[100];

        for (int i = 0; i < collection.Length; i++)
        {
            collection[i] = 100 - (i * 3);
        }

        foreach (int number in collection)
        {
            Console.WriteLine(number);
        }
    }
}