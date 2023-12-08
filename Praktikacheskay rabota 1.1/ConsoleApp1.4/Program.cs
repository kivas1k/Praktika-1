public class RandomNumberGenerator
{
    public static List<int> GenerateRandomNumbers(int start, int end)
    {
        Random random = new Random();
        
        List<int> numbers = new List<int>();

        for (int i = start; i <= end; i++)
        {
            int randomNumber = random.Next(start, end + 1);
            
            numbers.Add(randomNumber);
        }

        return numbers;
    }

    public static void Main()
    {
        int start = Convert.ToInt32(Console.ReadLine());
        
        int end = Convert.ToInt32(Console.ReadLine());

        List<int> randomNumbers = GenerateRandomNumbers(start, end);

        foreach (var number in randomNumbers)
        {
            Console.Write(number + " ");
        }
        
    }
}