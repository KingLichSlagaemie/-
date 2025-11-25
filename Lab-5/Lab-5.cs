using System.Threading.Channels;
using System.Windows.Markup;

namespace zhadaev_lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //void SayHello()
            //{
            //    Console.WriteLine("hello");
            //}
            //SayHello();

            //void SayHello1() => Console.WriteLine("Hello");
            //SayHello1();


            //void Game()
            //{
            //    string mygame = "The Witcher";
            //    Console.WriteLine(mygame);
            //}
            //Game();


            //Console.Write("Введите свое имя: ");
            //string? name = Console.ReadLine();
            //Console.Write("Введите ваш язык (русский, немецкий, английский): ");
            //string language = Console.ReadLine()!.ToLower();

            //void SayHelloRu() => Console.WriteLine($"Привет {name}!");
            //void SayHelloEn() => Console.WriteLine($"Hello {name}!");
            //void SayHelloDe() => Console.WriteLine($"Guten Tag{name}");

            //switch (language)
            //{
            //    case "английский": SayHelloEn(); break;
            //    case "русский": SayHelloRu(); break;
            //    case "немецкий": SayHelloDe(); break;
            //    default: Console.WriteLine("Язык не найден!"); break;
            //}



            //void Print(string message)
            //{
            //    Console.WriteLine(message);
            //}
            //Print(message: "Hello");

            //Console.WriteLine("What is your name?");
            //Console.WriteLine("Enter your name: ");
            //string? name = Console.ReadLine();
            //Print(message: $"Your name : {name}");


            //void Sum(int x, int y)
            //{
            //    int result = x + y;
            //    Console.WriteLine($"{x} + {y} = {result}");
            //}
            //Sum(10, 20);


            //Console.Write("Введите переменную х");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите переменную у");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Sum(x, y);

            //void PrintPerson(string personName, int age)
            //{
            //    Console.WriteLine($"Name: {personName}, Age: {age}");
            //}

            //Console.WriteLine("Enter your name");
            //string personName = Console.ReadLine();
            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());

            //PrintPerson(personName, age);


            //void Person(string name, int age = 18, string vuz = "ВолГУ") =>
            //    Console.WriteLine($"Name: {name}\nAge: {age}\nCollage: {vuz}");
            //Person(name: "Alexander");
            //Person(name: "Ivan", age:30);
            //Person(name: "Dmitriy", age:20, vuz:"MGU");
            //Person(age: 30, name: "Ivan");
            //Person(vuz: "MGU", age: 20, name: "Dmitriy");


            //string GetMessage()
            //{
            //    return "Hello";
            //}
            //Console.WriteLine(GetMessage());


            //int Sum(int a, int b)
            //{
            //    return a + b;
            //}
            //Sum(10, 20);


            //int number = Convert.ToInt32(Console.ReadLine());
            //void CheckVelue(int number)
            //{
            //    if (number < 0)
            //    {
            //        Console.WriteLine("Отрицательное число");
            //        return;
            //    }
            //    Console.WriteLine("Положительное число");
            //}
            //CheckVelue(number);


            //string GetMessage() 
            //{
            //    return "Hello";
            //}
            //string message = GetMessage();
            //Console.WriteLine(message);


            //string GetMessage()
            //{
            //    return "Hello";
            //}
            //void PrintMessage(string message)
            //{
            //    Console.WriteLine(message);
            //}
            //PrintMessage(GetMessage());


            //string GetMessage()
            //{
            //    return "hello";
            //}
            //int Sum(int x, int y)
            //{
            //    return x + y;
            //}

            //string GetMessage() => "hello";
            //int Sum(int x, int y) => x + y;


            //void PrintPerson(string name, int age)
            //{
            //    if (age > 120 || age < 1)
            //    {
            //        Console.WriteLine("Недопустимый возраст");
            //        return;
            //    }
            //    Console.WriteLine($"Имя: {name} Возраст: {age}");
            //}
            //PrintPerson(name: "Alex", age: 32);
            //PrintPerson(name: "Bob", age: 148);


            //Random random = new Random();
            //int number = random.Next(0, 100);
            //Console.WriteLine($"Случайное число: {number}");
            //double randomDouble = random.NextDouble();
            //Console.WriteLine($"Случайное число: {randomDouble}");



            //void ShowWelcomeMessage() => Console.WriteLine("Прогоз погоды");
            //void ShowGoodbyeMessage() => Console.WriteLine("Спасибо");
            //string GetWeather() 
            //{
            //    string[] weathers = ["Солнечно", "Облачно", "Дождь", "Снег", "Гроза"];
            //    Random random = new Random();
            //    int index = random.Next(weathers.Length);
            //    return weathers[index];
            //}
            //ShowWelcomeMessage();
            //string currentWeather = GetWeather();
            //Console.WriteLine($"Погода на сегодня: {currentWeather}");
            //ShowGoodbyeMessage();


            //int Factorial(int n)
            //{
            //    if (n == 1) return 1;
            //    return n * Factorial(n - 1);
            //}


            //int Factorial(int n)
            //{
            //    if (n == 1) return 1;
            //    return n * Factorial(n: n - 1);
            //}

            //int factorial = Factorial(n: 4);
            //int factorial1 = Factorial(n: 5);
            //int factorial2 = Factorial(n: 6);

            //Console.WriteLine($"4 = {factorial}");
            //Console.WriteLine($"5 = {factorial1}");
            //Console.WriteLine($"6 = {factorial2}");



            //void Compare(int[] numbers1, int[] numbers2)
            //{
            //    int numbers1Sum = 0;
            //    int numbers2Sum = 0;
            //    foreach (int number in numbers1)
            //        numbers1Sum += number;
            //    foreach (int number in numbers2) 
            //        numbers2Sum += number;
            //    if (numbers1Sum > numbers2Sum)
            //        Console.WriteLine("Сумма чисел нам1 больше");
            //    else if (numbers1Sum < numbers2Sum)
            //        Console.WriteLine("Сумма чисел нам2 больше");
            //    else
            //        Console.WriteLine("Сумма маасивов равны");
            //    return;

            //    int Sum(int[] numbers)
            //    {
            //        int result = 0;
            //        foreach (int number in numbers)
            //            result += number;
            //        return result;
            //    }
            //}


            //int Sum(int[] numbers)   {
            //    int limit = 0;
            //    int result = 0;



            //    foreach (int number in numbers) {
            //        if (IsPassed(number, lim:limit)) result += number;
            //    }

            //    return result;
            //    static bool IsPassed(int number, int lim) {
            //        return number > lim;
            //        bool IsPassed(int number) {
            //        return number > limit;
            //    }


            //}

            //}
            //int[] numbers1 = [-3, -2, -1, 0, 1, 2, 3];
            //int[] numbers2 = [3, -4, 5, -6, 7];
            //Console.WriteLine(Sum(numbers1));
            //Console.WriteLine(Sum(numbers2));



            //Задание 1

            //1.3
            //2.2
            //3.2
            //4.2
            //5.2

            //Задание 2

            //void GreetUser(string name)
            //{
            //    Console.WriteLine($"Привет, {name}! Добро пожаловать в программу");
            //}
            //GreetUser("Данил");

            //Задание 3

            //void number1(int num1,int num2)
            //{
            //    int result = num1 + num2;
            //    Console.WriteLine($"{num1} + {num2} = {result}");
            //}
            //number1(2, 2);

            //Задание 4

            // bool IsEven (int a)
            //{
            //    return a % 2 == 0;
            //}
            //Console.WriteLine(IsEven(5)); 

            //Задание 5

            //int[] nums = { 1, 2, 3, 4, 5 };
            //int result = FindMax(nums);
            //Console.WriteLine(result);

            //int FindMax(int[] numbers)
            //{

            //    int max = numbers[0];

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] > max)
            //        {
            //            max = numbers[i];
            //        }
            //    }
            //    return max;

            //}

            //Задание 6

            //Console.WriteLine();
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //int num = 0;
            //int temp = ConvertCelsiusToFahrenheit(num);
            //Console.WriteLine(temp);

            //int ConvertCelsiusToFahrenheit (int a)
            //{
            //    return a * 9 / 5 + 32;
            //}

            //Задание 7

            //string text = "Hello World";
            //int result = CountVowels(text);
            //Console.WriteLine(result);

            //int CountVowels(string input)
            //{
            //    string vowels = "aeiouAEIOU";
            //    int count = 0;

            //    foreach (char i in input)
            //    {
            //        if (vowels.Contains(i))
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //}


            //Задание 8

            //int length = 10;
            //string password = GeneratePassword(length);
            //Console.WriteLine(password);

            //static string GeneratePassword(int length)
            //{

            //    string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            //    var random = new Random();
            //    var result = new char[length];

            //    for (int i = 0; i < length; i++)
            //    {
            //        result[i] = text[random.Next(text.Length)];
            //    }
            //    return new string(result);
            //}


            //Задание 10

        
            void ReverxeArray(string[]words)
            {
                foreach (string i in words)
                { 
                
                }
            }


            //Задание 11

            //Console.WriteLine("Введите номер операции (1, 2, 3, 4)");
            //int operation = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите первое число");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //void operation1 (int num1, int num2)
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //void operation2 (int num1, int num2)
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //void operation3 (int num1, int num2)
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //void operation4 (int num1, int num2)
            //{
            //    Console.WriteLine(num2 / num2);
            //}

            //switch (operation)
            //{
            //    case 1: operation1(num1, num2); break;
            //    case 2: operation2(num1, num2); break;
            //    case 3: operation3(num1, num2); break;
            //    case 4: operation4(num1, num2); break;
            //    default: Console.WriteLine("Такой операции нет");break;
            //}








































        }
    }
}


