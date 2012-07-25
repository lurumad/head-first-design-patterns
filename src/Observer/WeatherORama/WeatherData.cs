using System.Collections.Generic;

namespace WeatherORama
{
    public class WeatherData : ISubject
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        public List<IObserver> Observers { get; private set; }

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }
    
        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (Observers.Contains(observer))
                Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Observers.ForEach(observer => 
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
