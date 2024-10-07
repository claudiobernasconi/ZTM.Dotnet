var temperature = new Temperature(TemperatureUnit.Celcius, 110.7m);
Console.WriteLine($"Temperature: {temperature.ValueInCelsius.ToString("0.0")}°C");

enum TemperatureUnit
{
    Celcius,
    Fahrenheit,
    Kelvin
}

class Temperature
{
    public Temperature(TemperatureUnit unit, decimal value)
    {
        Unit = unit;
        Value = value;
    }

    public TemperatureUnit Unit { get; set; }
    public decimal Value { get; set; }

    public decimal ValueInCelsius
    {
        get
        {
            return Unit switch
            {
                TemperatureUnit.Celcius when Value > 100 => Math.Round(Value, 0),
                TemperatureUnit.Celcius => Value,
                TemperatureUnit.Fahrenheit => (Value - 32) * 5 / 9,
                TemperatureUnit.Kelvin => Value - 273.15m,
                _ => 0
            };
        }
    }
}