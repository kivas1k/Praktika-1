using Newtonsoft.Json;

namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            if (args.Length > 0)
            {
                string city = args[0];
                
                await weatherData.GetWeather(city);
            }
            else
            {
                Console.Write("Enter city: ");
                
                string defaultCity = Console.ReadLine();
                
                weatherData.DefaultCity = defaultCity;
                
                await weatherData.GetWeather(weatherData.DefaultCity);
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
                printDefault(city);
                Thread.Sleep(900);
            }
        }

        public string DefaultCity { get; set; }

        public async Task GetWeather(string city)
        {
            string apiKey = "56e7fe704b986ccde6b69740196c1f65";
            
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(responseBody);

                    Console.WriteLine($"Weather in {city}:");
                    
                    Console.WriteLine($"Temperature: {weatherResponse.main.temp}°C");
                    
                    Console.WriteLine($"Feels like: {weatherResponse.main.feelslike}°C");
                    
                    Console.WriteLine($"Description: {weatherResponse.weather[0].description}");
                    
                    Console.WriteLine($"Wind speed: {weatherResponse.wind.speed} m/s");
                }
                else
                {
                    Console.WriteLine("Failed to retrieve weather data. Please try again.");
                }
            }
        }

        public static async Task printDefault(string city)
        {
            string apiKey = "56e7fe704b986ccde6b69740196c1f65";
            
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(responseBody);

                    Console.WriteLine($"Weather in {city}:");
                    
                    Console.WriteLine($"Temperature: {weatherResponse.main.temp}°C");
                    
                    Console.WriteLine($"Feels like: {weatherResponse.main.feelslike}°C");
                    
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