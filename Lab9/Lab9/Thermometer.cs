internal class Thermometer
{
    public event Action TemperatureTooHigh;
    private int temperature = 0;
    public void Measure()
    {
        Console.WriteLine("Температура превышена!");
        TemperatureTooHigh?.Invoke();
    }
    internal void TemperaturePLUS(int value)
    {
        temperature += value;
        if (temperature >= 100)
        {
            Measure();
        }
    }
}

