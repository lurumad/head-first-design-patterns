using System;
using System.Text;

namespace WeatherORama.Displays
{
    public class ForecastDisplay : IDisplayElement, IObserver
    {
        private float _lastPressure;
        private float _currentPressure = 29.92F;
        private ISubject _subject;

        public ForecastDisplay(ISubject subject)
        {
            if (subject == null) 
                throw new ArgumentNullException("subject");

            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public string Display()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Forecast: ");

		    if (_currentPressure > _lastPressure) 
            {
			    stringBuilder.Append("Improving weather on the way!");
		    }
            else if (Math.Abs(_currentPressure - _lastPressure) < 0.000001f)
            {
			   stringBuilder.Append("More of the same");
		    } 
            else if (_currentPressure < _lastPressure)
            {
                stringBuilder.Append("Watch out for cooler, rainy weather");
            }

            return stringBuilder.ToString();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
        }
    }
}
