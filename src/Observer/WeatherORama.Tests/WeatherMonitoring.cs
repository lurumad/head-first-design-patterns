using NUnit.Framework;
using WeatherORama.Displays;

namespace WeatherORama.Tests
{
    [TestFixture]
    public class WeatherMonitoring
    {
        [Test]
        public void WhenCreateDisplayExpectWeatherDataObserverListHasOneObserver()
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            Assert.AreEqual(1, weatherData.Observers.Count);
        }

        [Test]
        public void WhenCreateDisplayAndCallRemoveObserverExpectWeatherDataObserverListIsEmpty()
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.RemoveObserver(currentConditionsDisplay);

            Assert.AreEqual(0, weatherData.Observers.Count);
        }

        [Test]
        public void WhenCreateDisplayAndCallSetMeasurementsMethodExpectAllObserversAreNotified()
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 50, 80);

            Assert.AreEqual("Current conditions: 80 F degrees and 50 % humidity", currentConditionsDisplay.Display());
            Assert.AreEqual("Forecast: Improving weather on the way!", forecastDisplay.Display());
        }

        [Test]
        public void WhenCreateForecastDisplayAndCallSetMeasurementsMethodExpectDisplayMethodReturnImprovingMessage()
        {
            var weatherData = new WeatherData();
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 50, 80);

            Assert.AreEqual("Forecast: Improving weather on the way!", forecastDisplay.Display());
        }

        [Test]
        public void WhenCreateForecastDisplayAndCallSetMeasurementsMethodTwiceAndCurrentPressureIsLowerThanLastPressureExpectDisplayMethodReturn()
        {
            var weatherData = new WeatherData();
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 50, 80);
            weatherData.SetMeasurements(80, 50, 60);

            Assert.AreEqual("Forecast: Watch out for cooler, rainy weather", forecastDisplay.Display());
        }

        [Test]
        public void WhenCreateForecastDisplayAndCallSetMeasurementsMethodTwiceAndLastPressureIsEqualThanCurrentPressureExpectDisplayMoreOfTheSameMessage()
        {
            var weatherData = new WeatherData();
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 50, 80);
            weatherData.SetMeasurements(80, 50, 80);

            Assert.AreEqual("Forecast: More of the same", forecastDisplay.Display());
        }

        [Test]
        public void WhenCreateCurrentConditionsDisplayAndCallSetMeasurementsMethodExpectDisplayMethodReturnCurrentConditionsMessage()
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 50, 80);

            Assert.AreEqual("Current conditions: 80 F degrees and 50 % humidity", currentConditionsDisplay.Display());
        }

        [Test]
        public void WhenCreateStatisticsDisplayAndCallSetMeasurementsMethodOnceExpectDisplayMethodReturnStatisticsMessageAvg80Max80Min80()
        {
            var weatherData = new WeatherData();
            var statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(80, 50, 80);

            Assert.AreEqual("Avg/Max/Min temperature = 80 / 80 / 80", statisticsDisplay.Display());
        }

        [Test]
        public void WhenCreateStatisticsDisplayAndCallSetMeasurementsMethodTwiceExpectDisplayMethodReturnStatisticsMessageAvg40Max80Min60()
        {
            var weatherData = new WeatherData();
            var statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(80, 50, 80);
            weatherData.SetMeasurements(60, 50, 80);

            Assert.AreEqual("Avg/Max/Min temperature = 70 / 80 / 60", statisticsDisplay.Display());
        }

        [Test]
        public void WhenCreateHeatIndexDisplayAndCallSetMeasurementsMethodExpectDisplayMethodReturnHeatIndexMessage()
        {
            var weatherData = new WeatherData();
            var heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 50, 80);

            Assert.AreEqual("Heat index is: 81,07396", heatIndexDisplay.Display());
        }
    }
}
