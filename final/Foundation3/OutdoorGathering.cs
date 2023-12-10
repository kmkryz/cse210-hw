using System;

class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this._weatherForecast = weatherForecast;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    public override string ShortDescription()
    {
        return $"Type: Outdoor Gathering\nEvent: {_title}\nDate: {_date}";
    }
}
