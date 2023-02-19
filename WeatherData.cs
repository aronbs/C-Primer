using System;

class WeatherData
{
    private double temperature;
    private double humidity;
    private char scale;

    public WeatherData(double temperature, double humidity, char scale)
    {
        if (temperature < -60 || temperature > 60)
        {
            Console.WriteLine("Invalid temperature. Must be between -60 and 60 Celsius.");
        }
        else
        {
            this.temperature = temperature;
        }

        if (humidity < 0 || humidity > 100)
        {
            Console.WriteLine("Invalid humidity. Must be between 0 and 100.");
        }
        else
        {
            this.humidity = humidity;
        }

        if (scale == 'C' || scale == 'F')
        {
            this.scale = scale;
        }
        else
        {
            Console.WriteLine("Invalid input. Must be 'C' or 'F'.");
        }
    }

    public void SetTemperature(double temperature)
    {
        if (temperature < -60 || temperature > 60)
        {
            Console.WriteLine("Invalid temperature. Must be between -60 and 60 Celsius.");
        }
        else
        {
            this.temperature = temperature;
        }
    }

    public void SetHumidity(double humidity)
    {
        if (humidity < 0 || humidity > 100)
        {
            Console.WriteLine("Invalid humidity. Must be between 0 and 100.");
        }
        else
        {
            this.humidity = humidity;
        }
    }

    public void SetScale(char scale)
    {
        if (scale == 'C' || scale == 'F')
        {
            this.scale = scale;
        }
        else
        {
            Console.WriteLine("Invalid input. Must be 'C' or 'F'.");
        }
    }

    public void Convert()
    {
        if (scale == 'C')
        {
            temperature = temperature * 9 / 5 + 32;
            scale = 'F';
        }
        else if (scale == 'F')
        {
            temperature = (temperature - 32) * 5 / 9;
            scale = 'C';
        }
    }

    public void PrintData()
    {
        Console.WriteLine("Temperature: " + temperature + " " + scale);
        Console.WriteLine("Humidity: " + humidity + "%");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter humidity: ");
        double humidity = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter scale 'C' or 'F': ");
        char scale = Convert.ToChar(Console.ReadLine().ToUpper());

        WeatherData data = new WeatherData(temperature, humidity, scale);

        Console.WriteLine("Before conversion:");
        data.PrintData();

        data.Convert();

        Console.WriteLine("After conversion:");
        data.PrintData();
    }
}
