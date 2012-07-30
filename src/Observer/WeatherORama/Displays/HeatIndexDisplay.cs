using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherORama.Displays
{
    public class HeatIndexDisplay : IDisplayElement, IObserver
    {
        private float _heatIndex;
        private readonly ISubject _subject;

        public HeatIndexDisplay(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public string Display()
        {
            return String.Format("Heat index is: {0}", _heatIndex);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _heatIndex = ComputeHeatIndex(temperature, humidity);
        }

        private float ComputeHeatIndex(float temperature, float humidity)
        {
            return (float)((16.923 + (0.185212 * temperature) + (5.37941 * humidity) - (0.100254 * temperature * humidity)
                + (0.00941695 * (temperature * temperature)) + (0.00728898 * (humidity * humidity))
                + (0.000345372 * (temperature * temperature * humidity)) - (0.000814971 * (temperature * humidity * humidity)) +
                (0.0000102102 * (temperature * temperature * humidity * humidity)) - (0.000038646 * (temperature * temperature * temperature)) + (0.0000291583 *
                (humidity * humidity * humidity)) + (0.00000142721 * (temperature * temperature * temperature * humidity)) +
                (0.000000197483 * (temperature * humidity * humidity * humidity)) - (0.0000000218429 * (temperature * temperature * temperature * humidity * humidity)) +
                0.000000000843296 * (temperature * temperature * humidity * humidity * humidity)) -
                (0.0000000000481975 * (temperature * temperature * temperature * humidity * humidity * humidity)));
        }

    }
}
