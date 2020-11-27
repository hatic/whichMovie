using System;

namespace whichMovie
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
    //https://api.themoviedb.org/3/movie/550?api_key=3084def8015d0c58c6c8041a07e4de4e
}
