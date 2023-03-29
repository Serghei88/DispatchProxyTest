namespace DispatchProxyTest.Services;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetWeatherForecast();
}