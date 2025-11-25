using System;
using Base;
using MyApp.Models;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();

            //person.Name = "Ivan";
            //string personName = person.Name;
            //Console.WriteLine(personName);

            //Console.WriteLine(person.Age);
            //person.Age = 37;
            //Console.WriteLine(person.Age);
            //person.Age = -23;
            //Console.WriteLine(person.Age);

            //var apple = new Product { Name = "Яблоко", Price = 10.5m, Quantity = 5 };
            //var banan = new Product { Name = "Банан", Price = 7.2m, Quantity = -2 };
            //Console.WriteLine($"{apple.Name} x {apple.Quantity} = {apple.TotalPrice} Руб.");
            //Console.WriteLine($"{banan.Name} x {banan.Quantity} = {banan.TotalPrice} Руб.");

            //Hero hero = new Hero("Max", 120);
            //Console.WriteLine($"Имя героя: {hero.Name}\nУрвоень героя: {hero.Level}\nМана: {hero.Mana}\nСтатус: {hero.Status}");
            //hero.TakeDamage(50);
            //hero.Heal(30);
            //hero.TakeDamage(200);
            //hero.Heal(50);

            //Person1 garen = new Person1();
            //garen.name = "Garen";
            //garen.age = 25;
            //garen.Print();

            //Person1 timo = new Person1();
            //timo.Print();

            //Person1 ahri = new();
            //Person1 brand = new("Brand");
            //Person1 darius = new("Darius", 25);
            //ahri.Print();
            //brand.Print();
            //darius.Print();

            //var p1 = new Point2D(10, 20);
            //var p2 = new Point2D(13, 24);
            //Console.WriteLine($"Расстояние: {p1.DistanceTo(p2):F2}");

            //Company microsoft = new("Microsoft");
            //Person2 tom = new("Tom", microsoft);
            //tom.Print();

            // задание 1
            //Car car1 = new Car();
            //car1.Brand = "BMW";
            //car1.Model = "M4";
            //car1.Year = 2000;
            //car1.Mileage = 120;
            //car1.PrintInfo();

            //Console.WriteLine();

            //Car car2 = new Car();
            //car2.Brand = "Dodge";
            //car2.Model = "Hellcat";
            //car2.Year = 2001;
            //car2.Mileage = 150;
            //car2.PrintInfo();

            // задание 2
            //User user = new User
            //{
            //    Name = "Алексей Петров",
            //    Email = "alexey@gmail.com",
            //    IsActive = true
            //};

            //Console.WriteLine("Информация о пользователе:");
            //Console.WriteLine($"Имя: {user.Name}");
            //Console.WriteLine($"Email: {user.Email}");
            //Console.WriteLine($"Активен: {(user.IsActive ? "Да" : "Нет")}");

            // задание 3
            //ValueChecker checker = new ValueChecker();
            //checker.CheckType(42);
            //checker.CheckType("Hello");

            // задание 4
            //Имя "System" теперь двусмысленно - есть два разных объекта с одинаковым именем
            //Компилятор не знает, к чему обращаться
            //Класс "перекрывает" глобальное пространство имен
            //global::System.Console.WriteLine();

            // задание 5
            //Point startPoint = new Point(10, 10);
            //Rectangle rect = new Rectangle(startPoint, 20, 15);

            //Point[] testPoints = {
            //new Point(15, 15),
            //new Point(5, 5),
            //new Point(25, 20),
            //new Point(10, 10),
            //new Point(30, 25),
            //new Point(10, 25)
            //};

            //Console.WriteLine(rect);
            //Console.WriteLine($"Площадь: {rect.CalculateArea()}");
            //Console.WriteLine($"Периметр: {rect.CalculatePerimeter()}");
            //Console.WriteLine();

            //Console.WriteLine("Проверка точек:");
            //foreach (Point point in testPoints)
            //{
            //    bool contains = rect.ContainsPoint(point);
            //    Console.WriteLine($"Точка {point} внутри прямоугольника: {contains}");
            //}

        }
    }
}
