using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public static class ApiService
    {
        public static async Task<Root?> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response=await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid=db8fe23444dfe6300c731f2a88ba0845",latitude,longitude));
            return JsonConvert.DeserializeObject<Root>(response);
        }

        public static async Task<Root?> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("api.openweathermap.org/data/2.5/forecast?q={city name}&appid=db8fe23444dfe6300c731f2a88ba0845", city));
            return JsonConvert.DeserializeObject<Root>(response);
        }

    }
}
