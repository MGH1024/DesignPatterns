namespace PublisherSubscriber;

/// <summary>
/// my EventArg Class
/// </summary>
public class WeatherEventArgs
{
    public string WeatherCondition { get; set; }
    public WeatherEventArgs(string weatherCondition)
    {
        WeatherCondition = weatherCondition;
    }
}