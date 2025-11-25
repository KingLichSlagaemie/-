

namespace lab8
{
    public struct Person1
    {
        public string name;
        public int age;

        public Person1(string name = "Tom", int age = 1)
        {
            this.name = name; this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {name} Возраст: {age}");
        }
    }
}
