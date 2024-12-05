namespace PublisherSubscriber;

/// <summary>
/// subscriber
/// </summary>
public class WeatherDisplay
{
    private readonly string _displayName;

    public WeatherDisplay(string displayName)
    {
        _displayName = displayName;
    }

    public void OnWeatherChanged(object sender, WeatherEventArgs e)
    {
        Console.WriteLine($"{_displayName} received weather update: {e.WeatherCondition}");
    }
}