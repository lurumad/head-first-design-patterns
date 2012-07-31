using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherORama.Framework4.Displays;

namespace WeatherORama.Framework4.WeatherMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay1 = new CurrentConditionsDisplay("CurrentConditionsDisplay 1");
            var currentConditionsDisplay2 = new CurrentConditionsDisplay("CurrentConditionsDisplay 2");
            currentConditionsDisplay1.Subscribe(weatherData);
            currentConditionsDisplay2.Subscribe(weatherData);
            weatherData.UpdateMeasurements(new WeatherInformation() { Temperature = 80, Humidity = 30, Pressure = 1024});
            currentConditionsDisplay1.Unsuscribe();
            weatherData.UpdateMeasurements(new WeatherInformation() { Temperature = 80, Humidity = 30, Pressure = 1024 });
            weatherData.EndTransmision();
            Console.Read();
        }
    }
}
