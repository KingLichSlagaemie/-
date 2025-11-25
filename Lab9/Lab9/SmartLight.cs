internal class SmartLight
{
    private bool IsOn {  get; set; }
    private int Brightness { get; set; }

    public SmartLight(bool isOn, int brightness)    
    {
        IsOn = isOn;
        Brightness = brightness;
    }
    public event Action OnStateChanged;
    public void Toggle()
    {
        OnStateChanged?.Invoke();
        if (IsOn)
        {
            IsOn = false;
            Console.WriteLine($"Свет включён, Brightness = {Brightness}%");
        }
        else { IsOn = true;  Console.WriteLine("Свет выключен"); }
    }
}

