using PublisherSubscriber;

WeatherStation weatherStation = new WeatherStation();

// Create subscribers
WeatherDisplay display1 = new WeatherDisplay("Display 1");
WeatherDisplay display2 = new WeatherDisplay("Display 2");

// Subscribe to the event
weatherStation.WeatherChanged += display1.OnWeatherChanged;
weatherStation.WeatherChanged += display2.OnWeatherChanged;

// Update weather
weatherStation.UpdateWeather("Sunny");
weatherStation.UpdateWeather("Rainy");

// Unsubscribe one of the displays
weatherStation.WeatherChanged -= display2.OnWeatherChanged;

// Update weather again
weatherStation.UpdateWeather("Cloudy");