using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherORama.Framework4.Displays
{
    public abstract class DisplayBase : IObserver<WeatherInformation>
    {
        private IDisposable _disposable;

        public abstract void OnNext(WeatherInformation value);

        public abstract void OnError(Exception error);

        public abstract void OnCompleted();

        public virtual void Subscribe(IObservable<WeatherInformation> provider)
        {
            if (provider != null)
            {
                _disposable = provider.Subscribe(this);
            }
        }

        public void Unsuscribe()
        {
            _disposable.Dispose();
        }
    }
}
