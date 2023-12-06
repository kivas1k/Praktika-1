namespace WeatherApp
{
    internal class AttributeWeather
    {
        public string main { get; set; }
        
        public string description { get; set; }
    }

    internal class AttributeMain
    {
        public float temp { get; set; }
        
        public float feelslike { get; set; }
    }

    internal class AttributeWind
    {
        public float speed { get; set; }

    }

    internal class WeatherResponse
    {
        public List<AttributeWeather> weather { get; set; }
        
        public AttributeMain main { get; set; }
        
        public AttributeWind wind { get; set; }
    }
}