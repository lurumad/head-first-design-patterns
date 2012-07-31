using System;

namespace WeatherORama.Framework4.Displays
{
    public class CurrentConditionsDisplay : DisplayBase
    {
        private readonly string _name;

        public CurrentConditionsDisplay(string name)
        {
            _name = name;
        }

        public override void OnNext(WeatherInformation value)
        {
            Console.WriteLine("{0} Current conditions: {1} F degrees and {2} % humidity", _name, value.Temperature, value.Humidity);
        }

        public override void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public override void OnCompleted()
        {
            Console.WriteLine("The Weather station has completed transmitting data to {0}.", _name);
            Unsuscribe();
        }
    }
}
