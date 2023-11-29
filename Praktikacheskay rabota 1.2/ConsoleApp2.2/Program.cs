using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10; // количество элементов в массиве
        int[] arr = new int[n];
        int num = 1;
        
        for (int i = 0; i < n; i++)
        {
            arr[i] = num;
            num += 2;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}