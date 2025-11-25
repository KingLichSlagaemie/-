using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace Lab_10_C
{
    internal class Program
    {
        //static IEnumerable<int> GenereteNumbers()
        //{
        //    Console.WriteLine("Начинаем генерацию...");
        //    yield return 1;
        //    Console.WriteLine("Пауза...");
        //    yield return 2;
        //    Console.WriteLine("И ёще раз...");
        //    yield return 3;
        //    Console.WriteLine("Готово!");
        //}
        //delegate int MathOperation(int a, int b);
        //static void Main(string[] args)
        //{
            //foreach(int number in GenereteNumbers())
            //{
            //    Console.WriteLine($"Получено число: {number}");
            //}
            //var monster = new
            //{
            //    Name = "Дракон",
            //    Damage = 50,
            //    IsBoss = true,
            //    Description = "Древний огнедышащий змей"
            //};
            //Console.WriteLine(monster.Description);

            //var products = new[]
            //{
            //    new{Name = "Молоко", Price = 59.99, Category = "Продукты"},
            //    new{Name = "Ноутбук", Price = 49999.99, Category = "Электроника"},
            //    new{Name = "Щетка для зубов", Price = 59.99, Category = "Гигиена"}
            //};

            //Console.WriteLine("Список товаров: ");
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.Name} ({product.Category}) - {product.Price} р.");
            //};

            //Student1 student1 = new Student1();
            //student1.Name = "Max";
            //student1.University = "VOLGY";
            //student1.SayHello();
            ////Console.WriteLine($"Учится в: {student1.University}");
            //Person student2 = new Person();
            //student2.Name = "Denis";
            //student2.SayHello();

            //Animal[] animals =
            //{
            //new Dog() { Name = "Rex" },
            //new Cat() { Name = "Timmy" }
            //};
            //foreach (var animal in animals)
            //{
            //    animal.Info();
            //    animal.MakeSound();
            //}


            //int Square(int x)
            //{
            //    return x * x;
            //}
            //Console.WriteLine(Square(5));

            //Func<int, int> square = x => x * x;
            //Console.WriteLine(square(5));

            //Button button = new Button();
            //button.onClick += () => Console.WriteLine("Кнопка нажата!");
            //button.Click();

            //List<ISound> sounds = new List<ISound>()
            //{
            //    new Bird(),
            //    new Phone()
            //};
            //foreach(var sound in sounds)
            //{
            //  sound.MakeSound();
            //}

            //Book book = new Book { Name = "Война и мир" };
            //Console.WriteLine(book.Name);

            //Duck duck = new Duck();
            //((IFlier)duck).Fly();
            //((ISwimmmer)duck).Swim();

            //List<int> numbers = new List<int> { 5, 22, 13, 50, 77, 90, 9, 7 };

            //List<int> evenNumbers = new List<int>();
            //foreach (var num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        evenNumbers.Add(num);
            //    }
            //}

            //List<int> multiplied = new List<int>();
            //foreach (var num in evenNumbers)
            //{
            //    multiplied.Add(num * 10);
            //}
            //multiplied.Sort((a, b) => b.CompareTo(a));
            //Console.WriteLine("Результат (без LINQ):");
            //foreach (var num in multiplied)
            //{
            //    Console.WriteLine(num);
            //}

            //var result = numbers
            //    .Where(n => n % 2 == 0)
            //    .Select(n => n * 10)
            //    .OrderByDescending(n => n);
            //Console.WriteLine("Результат (c LINQ):");
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}

            //List<string> names = new List<string> { "Анна", "Иван", "Мария", "Пётр" };

            //var linqLongNames = names.Where(name => name.Length > 4);

            //foreach (var name in linqLongNames)
            //{
            //    Console.WriteLine(name);
            //}

            //List<int> nums = new List<int> { 10, 5, 20, 3 };

            //int linqMin = nums.Min();
            //Console.WriteLine($"Минимальное число (с LINQ): {linqMin}");

            //List<int> numbers2 = new List<int> { 1, 2, 3, 4 };

            //var LingSquares = numbers2.Select(n => n * n);
            //Console.WriteLine("Квадраты чисел (с LINQ):");
            //Console.WriteLine(string.Join(", ", LingSquares));

            //List<Student1> students = new()
            //{
            //    new Student1 { Name = "Андрей", Score = 90 },
            //    new Student1 { Name = "Вика", Score = 78 },
            //    new Student1 { Name = "Денис", Score = 84 },
            //    new Student1 { Name = "Лена", Score = 95 },
            //    new Student1 { Name = "Олег", Score = 65 }
            //};
            //var goodStudents = students
            //    .Where(s => s.Score > 80)
            //    .OrderBy(s => s.Name);

            //var averageScore = students.Average(s => s.Score);

            //Console.WriteLine("Студенты с баллом > 80:");
            //foreach (var s in goodStudents)
            //    Console.WriteLine($"{s.Name} - {s.Score}");

            //Console.WriteLine($"Средний балл: {averageScore:F1}");


            //Func<int, int, int> sum = (a, b) => a + b;
            //Console.WriteLine(sum(3, 7)); 

            //Func<int, string> numberToWord = num =>
            //{
            //    switch (num)
            //    {
            //        case 1: return "один";
            //        case 2: return "два";
            //        default: return "много";
            //    }
            //};
            //Console.WriteLine(numberToWord(2)); 


            //MathOperation add = (a, b) => a + b;
            //Console.WriteLine(add(2, 3)); // 5

            //static IEnumerable<string> WaitCoroutine()
            //{
            //    yield return "Ждём... 1 секунда";
            //    yield return "Ждём... 2 секунды";
            //}

            //static void Main(string[] args)
            //{
            //    foreach (var step in WaitCoroutine())
            //    {
            //        Console.WriteLine(step);
            //        Thread.Sleep(1000);
            //    }
            //    Console.WriteLine("Готово!");
            //}

            //static async Task Main()
            //{
            //    Console.WriteLine("Ждём... 2 секунды");
            //    await Task.Delay(2000);
            //    Console.WriteLine("Готово!");
            //}
            //Arena arena = new();
            //arena.AddUnit(new Warrior("Боромир"));
            //arena.AddUnit(new Archer("Эльфус"));
            //arena.AddUnit(new Mage("Леголас"));
            //arena.StartBattle();



            //HomeWork
            // EX1
            //var students = new[]
            //{
            //    new {Name = "Max", Age = 18, Group = "ISP-232"},
            //    new {Name = "Kolya", Age = 17, Group = "ISP-233"},
            //    new {Name = "Eva", Age = 21, Group = "ISP-231"}
            //};
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Меня зовут {student.Name}, мне {student.Age} лет, учусь в группе: {student.Group}");
            //}

            // EX2
            //List<int> list1 = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //List<int> chet = list1.FindAll(n => n % 2 == 0);
            //List<int> ctri = list1.FindAll(n => n % 3 == 0);

            //foreach (int a in chet)
            //{
            //    Console.Write($"{a} ");
            //}
            //Console.WriteLine();
            //foreach(int b in ctri)
            //{
            //    Console.Write($"{b} ");
            //}

            // EX3
            //List<IPrintable> sp = new()
            //{
            //    new Book1 {Name = "Золотая рыбка", Year = 1833},
            //    new Book1 {Name = "Война и мир", Year = 1867},
            //    new Magazine1 {Name = "Мурзилка", Year = 2000},
            //    new Magazine1 {Name = "Мода", Year = 2007},
            //};
            //foreach(var x in sp)
            //{
            //    x.PrintInfo();
            //}

            // EX4
            //List<string> cities = new List<string>
            //{
            //    "Москва",
            //    "Саратов",
            //    "Воронеж",
            //    "Краснодар",
            //};
            //var citiesK = cities.Where(x => x.StartsWith("К"));
            //cities.Sort((a, b) => a.Length.CompareTo(b.Length));
            //var lenght = cities.Where(x => x.Length > 6);

            //foreach(var p in citiesK)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine();
            //foreach(var h in cities)
            //{
            //    Console.WriteLine(h);
            //}
            //Console.WriteLine();
            //foreach (var c in lenght)
            //{
            //    Console.WriteLine(c);
            //}

            //EX6
            static async Task Main()
            {
                List<IPerson> persons = new()
                {
                new Teacher2 { Name = "Alex", Age = 25, Kaf = "Програмирование" },
                new Teacher2 { Name = "Marina",Age = 24, Kaf = "Геодезия"},
                new Student2 {Name = "Alisa", Age = 20},
                new Student2 {Name = "Sasha", Age = 19},
                new Student2 {Name = "Kolya", Age = 21},
                new Student2 {Name = "Max", Age = 22},
                };
                var ages = persons.OfType<Student2>().Where(g => g.Age >= 20);
                var kafs = persons.OfType<Teacher2>().Where(h => h.Kaf == "Геодезия");

                await LoadStudentsAsync();
                foreach (var person in ages)
                {
                    Console.WriteLine($"Имя: {person.Name} | Возраст: {person.Age} лет");
                }

                Console.WriteLine();
                foreach (var person in kafs)
                {
                    Console.WriteLine($"Имя: {person.Name} | Возраст: {person.Age} лет | Кафедра: {person.Kaf}");
                }
                Console.WriteLine();
                var all = persons.OrderBy(s => s.Name);
                foreach (var person in all)
                {
                    Console.WriteLine($"{person.Name}");
                }
           
            }
    //}
        public static async Task<string>  LoadStudentsAsync()
        {
            Console.WriteLine("Загрузка данных...");
            await Task.Delay(3000);
            return "Данные загружены!";
        }

        //EX5
        //static async Task Main()
        //{
        //    Console.WriteLine("Ждём данные…");
        //    int result = await GetDataAsync();
        //    Console.WriteLine($"Данные получены! Результат: {result}");
        //}

        //public static async Task<int> GetDataAsync()
        //{
        //    Console.WriteLine("Обработка данных...");
        //    await Task.Delay(2000);
        //    return 123;
        //}

        //public static async Task<string> MakeSoupAsync()
        //{
        //    Console.WriteLine("Начали варить суп...");
        //    await Task.Delay(3000);
        //    return "Суп";
        //}
        //public static async Task<string> MakeSaladAsync()
        //{
        //    Console.WriteLine("Начали резать салат...");
        //    await Task.Delay(1000);
        //    return "Салат";
        //}
        //public static async Task CookDinnerAsync()
        //{
        //    Task<string> soupTask = MakeSoupAsync();
        //    Task<string> saladTask = MakeSaladAsync();

        //    string soup = await soupTask;
        //    string salad = await saladTask;

        //    Console.WriteLine($"Готово: {soup} и {salad}");
        //}
        //static async Task Main()
        //{
        //    Console.WriteLine("Начинаем готовить ужин...");
        //    await CookDinnerAsync();
        //    Console.WriteLine("Ужин готов!");
        //}




    }

}
        //static async Task Main()
        //{
        //    Console.WriteLine("1. Включаем чайник...");

        //    Task boilTask = BoilWaterAsync();
        //    Task slicelemon = SliceLemonAsync();
        //    await Task.WhenAll(boilTask, slicelemon);

        //    Console.WriteLine("3. Завариваем чай!");
        //}
        //static async Task BoilWaterAsync()
        //{
        //    Console.WriteLine("2. Кипятим воду (ждем 3 секунды)...");
        //    await Task.Delay(3000);
        //    Console.WriteLine("...вода закипела!");
        //}
        //static async Task SliceLemonAsync()
        //{
        //    Console.WriteLine("3. Режем лимон (ждем 2 секунды)... ");
        //    await Task.Delay(2000);
        //    Console.WriteLine("... лимон порезан!");
        //}

        
        


