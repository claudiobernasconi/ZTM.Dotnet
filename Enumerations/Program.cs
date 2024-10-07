var temperature = new Temperature(TemperatureUnit.Celcius, 10);
Console.WriteLine($"Temperature: {temperature.ValueInCelsius.ToString("0.0")}°C");

// Underlying values are int
Console.WriteLine((int)TemperatureUnit.Celcius);
Console.WriteLine((int)TemperatureUnit.Fahrenheit);
Console.WriteLine((int)TemperatureUnit.Kelvin);

// Casting values from int to TemperatureUnit
// Warning: 7 can be casted but is not defined.
int temperature2 = 7;
TemperatureUnit kelvin = (TemperatureUnit)temperature2;
Console.WriteLine(kelvin);

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
            if (Unit == TemperatureUnit.Celcius)
            {
                return Value;
            }

            if (Unit == TemperatureUnit.Fahrenheit)
            {
                return (Value - 32) * 5 / 9;
            }

            if (Unit == TemperatureUnit.Kelvin)
            {
                return Value - 273.15m;
            }

            return 0;
        }
    }
}