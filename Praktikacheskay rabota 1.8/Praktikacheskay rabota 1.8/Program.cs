namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            
            if (args.Length > 0)
            {
                string city = args[0];
                
                weatherData.GetWeather(city);
            }
            else
            {
                Console.Write("Enter city: ");
                
                string defaultCity = Console.ReadLine();
                
                weatherData.DefaultCity = defaultCity;
                
                weatherData.GetWeather(weatherData.DefaultCity);
            }
        }
    }
}