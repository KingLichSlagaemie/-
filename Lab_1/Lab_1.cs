//using System;
//using System.Security.Cryptography;

//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}



//int number = 52; //Объявление
//string word = "Danil"; //Объявление и ицициализация
//double = 10.5; //Объявление



//byte a1 = 1;
//sbyte a2 = 100;
//short a3 = 3;
//ushort a4 = 4;
//int a5 = 5;
//uint a6 = 6;
//long a7 = -10;
//ulong a8 = 8;
//bool a9 = true;
//float b1 = 4.6f;
//double b2 = 5.3;
//decimal b3 = 4.5m;
//char b4 = 'A';
//string b5 = "Hi";
//object b6 = 24;
//string name = null;
//Console.WriteLine(name);
//Console.WriteLine(a1);
//Console.WriteLine(a2);
//Console.WriteLine(a3);
//Console.WriteLine(a4);
//Console.WriteLine(a5);
//Console.WriteLine(a6);
//Console.WriteLine(a7);
//Console.WriteLine(a8);
//Console.WriteLine(a9);
//Console.WriteLine(b1);
//Console.WriteLine(b2);
//Console.WriteLine(b3);
//Console.WriteLine(b4);
//Console.WriteLine(b5);
//Console.WriteLine(b6);

//Шаг 6

//Console.WriteLine(int.MaxValue);
//Console.WriteLine(int.MinValue);
//Console.WriteLine(double.MaxValue);
//Console.WriteLine(double.MinValue);

//Шаг 7

//Console.WriteLine("Введите возраст: ");
//int age = int.Parse(Console.ReadLine());


//string naumStr = "123";
//string nullStr = null;
//int number1 = Convert.ToInt32(nullStr);
//int number2 = int.Parse(nullStr);

//Шаг 10

//string hello = "Привет мир";
//Console.WriteLine(hello);
//Console.WriteLine("Я изучаю C#");
//Console.WriteLine("Пока мир...");
//Console.WriteLine(36.6);

//string name = "Danil";
//int age = 18;
//double height = 1.85;
////Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м");
//Console.WriteLine("Имя: {0} Возраст: {1} Рост: {2}м", name, age, height);

//string hello = "Привет мир";
//Console.Write(hello);
//Console.Write(" Я изучаю C#");
//Console.Write(" Пока мир...");
//Console.Write(36.6);

//Console.Write("Введите свое имя: ");
//string? name = Console.ReadLine();
//Console.WriteLine($"Привет {name}");

//Шаг 12

//Console.Write("Введите ваше имя:");
//string name = Console.ReadLine();
//Console.Write("Введите ваш возраст");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine($"Привет, {name}");
//Console.WriteLine($"Через год тебе будет {age + 1}");

//Задание 1

//Console.Write("Ваша любимая игра:");
//string game = Console.ReadLine();
//Console.Write("Ваша любимая цифра:");
//int number = int.Parse(Console.ReadLine());
//double p = 3.12;
//Console.WriteLine($"Значение числа пи:{p}");
//Console.Write("Ваша любимая буква алфавита:");
//string letter = Console.ReadLine();

//Задание 2

//Console.WriteLine("I");
//Console.WriteLine("need");
//Console.WriteLine("more");
//Console.WriteLine("power!");

//Задание 3

//Console.WriteLine("\"Hello There\"");

//Задание 4

//Console.Write("Стоимость монитора:");
//int monitor = int.Parse(Console.ReadLine());
//Console.Write("Стоимость системного блока:");
//int system_unit = int.Parse(Console.ReadLine());
//Console.Write("Стоимость клавиатуры:");
//int keyboard = int.Parse(Console.ReadLine());
//Console.Write("Стоимость мыши:");
//int mouse = int.Parse(Console.ReadLine());
//Console.WriteLine($"Стоимость трех компьютеров - {(monitor + system_unit + keyboard + mouse) * 3} серебрянников");

//Задание 5

//Console.Write("a = ");
//int a = int.Parse(Console.ReadLine()); 
//Console.Write("b = ");
//int b = int.Parse(Console.ReadLine());
//int result = 3 * (a + b) * (a + b) * (a + b) + 275 * b * b - 127 * a - 41;
//Console.WriteLine(result);

//Задание 6

//Console.WriteLine("Введите ваше имя");
//string name = Console.ReadLine();
//Console.WriteLine("Введите ваш возраст");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine($"Привет, {name}!");
//Console.WriteLine($"Сейчас тебе {age}");
//Console.WriteLine($"В следующем году тебе будет {age + 1}");

//Задание 7

//string name = Console.ReadLine();
//int age = int.Parse(Console.ReadLine());
//string city = Console.ReadLine();
//Console.WriteLine($"Привет, {name}! Тебе {age} лет и ты живешь в городе {city}");

//Задание 8

//Console.Write("Введите температу C:");
//double temp = double.Parse (Console.ReadLine());
//Console.Write("Температура в F:");
//double result = temp * 9 / 5 + 32;
//Console.WriteLine(result);


