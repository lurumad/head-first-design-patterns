using System;
using System.Collections.Generic;

namespace WeatherORama.Framework4
{
    public class WeatherData : IObservable<WeatherInformation>
    {
        private readonly List<IObserver<WeatherInformation>> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver<WeatherInformation>>();
        }
    
        public IDisposable Subscribe(IObserver<WeatherInformation> observer)
        {
            if (observer == null) 
                throw new ArgumentNullException("observer");

            if (!_observers.Contains(observer))
                _observers.Add(observer);

            return new Unsuscribe(observer, _observers);
        }

        public void UpdateMeasurements(WeatherInformation weatherInformation)
        {
            foreach (var observer in _observers)
            {
                if (weatherInformation == null)
                {
                    observer.OnError(new NullReferenceException("WeatherInformation is null"));
                }
                else
                {
                    observer.OnNext(weatherInformation);
                }
            }
        }

        public void EndTransmision()
        {
            foreach (var observer in _observers.ToArray())
            {
                observer.OnCompleted();
            }
        }

        private class Unsuscribe : IDisposable
        {
            private readonly IObserver<WeatherInformation> _observer;
            private readonly IList<IObserver<WeatherInformation>> _observers;

            public Unsuscribe(IObserver<WeatherInformation> observer, IList<IObserver<WeatherInformation>> observers)
            {
                _observer = observer;
                _observers = observers;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
