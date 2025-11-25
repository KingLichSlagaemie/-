using Base;
class Person
{
    private string name = "Undefined";
    private int age = 1;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Age
    {
        set
        {
            if (value < 1 || value > 120)
                Console.WriteLine("Возраст долен быть в диапозоне от 1 до 120");
            else
                age = value;
        }
        get { return age; }
    }
    
}