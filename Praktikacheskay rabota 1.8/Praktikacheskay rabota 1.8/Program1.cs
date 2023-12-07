using Newtonsoft.Json;

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
    class WeatherData
    {
        public string path;

        public string city;

        public WeatherData()
        {
            path = Directory.GetCurrentDirectory() + "/default.txt";

            city = File.ReadAllText(path);

            if (city.Equals(string.Empty))
            {
                Console.WriteLine("Nothing");
            }
            else
            {
                GetWeather(city);
            }
        }
        
        public string DefaultCity { get; set; }

        public void GetWeather(string city)
        {
            string apiKey = "56e7fe704b986ccde6b69740196c1f65";
            
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {

                var response =  client.GetAsync(apiUrl).Result;
                
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = response.Content.ReadAsStringAsync().Result;;
                    
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(responseBody);

                    Console.WriteLine($"Weather in {city}:");
                    
                    Console.WriteLine($"Temperature: {weatherResponse.main.temp}°C");
                    
                    Console.WriteLine($"Feels like: {weatherResponse.main.feels_like}°C");
                    
                    Console.WriteLine($"Description: {weatherResponse.weather[0].description}");
                    
                    Console.WriteLine($"Wind speed: {weatherResponse.wind.speed} m/s");
                }
                else
                {
                    Console.WriteLine("Failed to retrieve weather data. Please try again.");
                }
            }
        }
    }
}