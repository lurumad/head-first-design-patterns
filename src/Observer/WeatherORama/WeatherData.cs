using System.Collections.Generic;

namespace WeatherORama
{
    public class WeatherData : ISubject
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private readonly List<IObserver> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
    
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(observer => 
                observer.Update(_temperature, _humidity, _pressure));
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
