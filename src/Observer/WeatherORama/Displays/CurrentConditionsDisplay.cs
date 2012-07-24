using System;

namespace WeatherORama.Displays
{
    public class CurrentConditionsDisplay : IDiplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            if (weatherData == null) 
                throw new ArgumentNullException("weatherData");

            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public string Display()
        {
            return String.Format("Current conditions: {0} F degrees and {1} % humidity", _temperature, _humidity);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }
    }
}
