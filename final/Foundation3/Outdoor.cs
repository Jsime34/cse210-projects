class Outdoor : Event{
    private string _forecast;

    public Outdoor(string title, string description, string date, string time, Address address, string forecast) : base(title, description, date, time, address){
        _forecast = forecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_forecast}";
    }
}