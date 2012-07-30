using System;

namespace WeatherORama.Displays
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private ISubject _subject;

        public CurrentConditionsDisplay(ISubject subject)
        {
            if (subject == null) 
                throw new ArgumentNullException("subject");

            _subject = subject;
            _subject.RegisterObserver(this);
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
