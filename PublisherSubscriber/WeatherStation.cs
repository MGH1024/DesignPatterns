namespace PublisherSubscriber;

/// <summary>
/// publisher
/// </summary>
public class WeatherStation
{
    // Define the event using EventHandler<T>
    public event EventHandler<WeatherEventArgs> WeatherChanged;

    public void UpdateWeather(string newWeather)
    {
        Console.WriteLine($"Weather updated to: {newWeather}");
        // Raise the event
        OnWeatherChanged(newWeather);
    }

    protected virtual void OnWeatherChanged(string weatherCondition)
    {
        // Invoke the event if there are subscribers
        WeatherChanged?.Invoke(this, new WeatherEventArgs(weatherCondition));
    }
}