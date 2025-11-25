

internal class Car
{
    private string brand = "";
    private string model = "";
    private int year = 0;
    private int mileage = 0;

    public string Brand
    {
        get { return brand; }
        set
        {
            brand = value;
        }
    }
    public string Model
    {
        get { return model; }
        set
        {
            model = value;
        }
    }
    public int Year
    {
        get { return year; }
        set 
        { 
            year = value; 
        }
    }
    public int Mileage
    {
        get { return mileage; }
        set 
        { 
            mileage = value; 
        }
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Brend: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Mileage: {Mileage}");
    }
       

}

