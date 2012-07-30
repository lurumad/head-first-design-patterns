using System;

namespace WeatherORama.Displays
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private readonly ISubject _subject;
        private float _maxTemperature = 0.0F;
        private float _minTemperature = 200;
        private float _sumTemperature = 0.0F;
        private int _numberOfReadings = 0;

        public StatisticsDisplay(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public string Display()
        {
            return String.Format("Avg/Max/Min temperature = {0} / {1} / {2}", 
                (_sumTemperature / _numberOfReadings), 
                _maxTemperature, 
                _minTemperature);

        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _sumTemperature += temperature;
            _numberOfReadings++;

            if (temperature > _maxTemperature)
            {
                _maxTemperature = temperature;
            }
            
            if (temperature < _minTemperature)
            {
                _minTemperature = temperature;
            }

            Display();
        }
    }
}
