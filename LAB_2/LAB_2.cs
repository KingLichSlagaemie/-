//double a = 30;
//double b = 3;
//double c = a / b;
//Console.WriteLine($"Peremennaya c = {c}");
//double x = 10 / 3;
//Console.WriteLine($"Peremennaya x = {x}");


//int x1 = 4;
//int y1 = ++x1;
//Console.WriteLine($"x1 = {x1}, y1 = {y1}");

//int x2 = 4;
//int y2 = x2++;
//Console.WriteLine($"x2 = {x2}, y2 = {y2}");

//int x = 1;
//Console.WriteLine(x++ + ++x);

//double a = 0.1;
//double b = 0.2;
//double c = a + b;
//double d = 0.3;
//Console.WriteLine(c == d);//не точный расчет


//decimal a = 0.1m;
//decimal b = 0.2m;
//decimal c = a + b;
//decimal d = 0.3m;
//Console.WriteLine(c == d);//точный расчет


//bool x1 = (5 > 6) | (4 < 6);
//bool x2 = (5 > 6) | (4 > 6);
//Console.WriteLine(x1);
//Console.WriteLine(x2);


//int a = 10;
//byte b = (byte)(a + 30);

//double number = 1234.56789;
//Console.WriteLine("{0:F2}", number);
//Console.WriteLine("{0:C}", number);
//Console.WriteLine("{0:P}", 0.1234);


//int x;


//Console.WriteLine("Введите целое число: ");
//string? input = Console.ReadLine();
//int number = Convert.ToInt32(input);

//if (number > 0)
//{
//    Console.WriteLine("Число положительное.");
//}
//else if (number < 0)
//{
//    Console.WriteLine("Число отрицательное.");
//}
//else
//{
//    Console.WriteLine("Это ноль.");
//}


//int x = 3;
//int y = 2;

//int z = x < y ? (x + y) : (x - y);
//Console.WriteLine(z);


//string game = Console.ReadLine();

//switch (game)
//{
//    case "Dota 2":
//        Console.WriteLine("Ваша игра - Dota 2");
//        break;
//    case "CS":
//        Console.WriteLine("Ваша ира - CS");
//        break;
//    case "Minecraft":
//        Console.WriteLine("Ваша игра - Minecraft");
//        goto case "Dota 2";
//    default:
//        Console.WriteLine("Игра не найдена");
//        break;
//}

//Задание 1

//Console.WriteLine("Введите число:");
//string? input = Console.ReadLine();
//int number = Convert.ToInt32(input);

//if (number % 2 == 0)
//{
//    Console.WriteLine("Число четное");
//}
//else
//{
//    Console.WriteLine("Число нечетное");
//}

//Задание 2

//Console.WriteLine("Введите пароль");
//var password = Console.ReadLine();
//Console.WriteLine("Подтвердите пароль");
//var passwordtrue = Console.ReadLine();

//if (password == passwordtrue)
//{
//    Console.WriteLine("Пароль принят");
//}
//else if (password != passwordtrue)
//{
//    Console.WriteLine("Пароль не принят");
//}

//Задание 3

//Console.WriteLine("Введите чтырехзначное число");
//int number = int.Parse(Console.ReadLine());
//int first = number / 1000;
//int second = (number / 100) % 10;
//int third = (number / 10) % 10;
//int fourth = number % 10;
//if (first + fourth == second - third)
//{
//    Console.WriteLine("DA");
//}
//else
//{
//    Console.WriteLine("NET");
//}

//Задание 4

//Console.WriteLine("Введите возраст");
//int age = int.Parse(Console.ReadLine());
//if (age >= 18)
//{
//    Console.WriteLine("Доступ разрешен");
//}
//else
//{
//    Console.WriteLine("Доступ запрещен");
//}

//Задание 5

//Console.WriteLine("Введите первое число");
//int number_one = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//int number_two = int.Parse(Console.ReadLine());
//if (number_one < number_two)
//{
//    Console.WriteLine($"{number_one}");
//}
//else if (number_one > number_two)
//{
//    Console.WriteLine($"{number_two}");
//}

//Задание 6

//Console.WriteLine("Введите первое число");
//int first = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//int second = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите операцию(сложение, вычитание, умножение или деление)");
//string operation = Console.ReadLine().ToLower();
//if (operation == "сложение")
//{
//    Console.WriteLine($"{first + second}");
//}
//else if (operation == "вычитание")
//{
//    Console.WriteLine($"{first - second}");
//}
//else if (operation == "умножение")
//{
//    Console.WriteLine($"{first * second}");
//}
//else
//{
//    Console.WriteLine($"{first / second}");
//}

//Задание 7

//string week = Console.ReadLine();
//switch (week)
//{
//    case "1":
//        Console.WriteLine("Понедельник");
//        break;
//    case "2":
//        Console.WriteLine("Вторник");
//        break;
//    case "3":
//        Console.WriteLine("Среда");
//        break;
//    case "4":
//        Console.WriteLine("Четверг");
//        break;
//    default:
//        Console.WriteLine("День не найден");
//        break;

//}


//string week = Console.ReadLine();
//Console.WriteLine(switch week
//{ 
//    "1" => "Понедельник",
//    "2" => "Вторник",
//    "3" => "Среда",
//    _ => "День не найден"

//});


//Задание 8

//Console.WriteLine("Введите операцию (+,-,/,*)");
//string operation = Console.ReadLine();
//Console.WriteLine("Введите первое число");
//double first = Convert.ToDouble (Console.ReadLine());
//Console.WriteLine("Введите второе число");
//double second = Convert.ToDouble(Console.ReadLine());

//double result;

//switch (operation)
//{
//    case "+":
//        result = first + second;
//        break;
//    case "-":
//        result = first - second;
//        break;
//    case "/":
//        result = first / second;
//        break;
//    case "*":
//        result = first * second;
//        break;
//    default:
//        Console.WriteLine("Операция не найдена");
//        return;
//}
//    Console.WriteLine($"{first} {operation} {second} = {result}");


//Задание 9

//Console.WriteLine("Enter the difficulty level (1,2,3)");
//string level = Console.ReadLine();
//switch (level)
//{
//    case "1":
//        Console.WriteLine("easy");
//        break;
//    case "2":
//        Console.WriteLine("medium");
//        break;
//    case "3":
//        Console.WriteLine("hard");
//        break;
//    default:
//        Console.WriteLine("level not found");
//        return;

//}

//Задание 10

//namespace Program //Конфликтность имен
//{
//    internal class Program //Создание класса
//    {
//        static int health = 1000; //Создание переменной здоровье. Переменная принадлежит классу

//        static void Main(string[] args) //Точка входа в программу
//        {
//            Console.WriteLine($"Здоровье персонажа: {health}"); //Объявление в консоль здоровье персонажа
//            TakeDamage(30); //Полученный урон
//        }

//        static void TakeDamage(int damage) //Добавление переменной для урона
//        {
//            health -= damage; //Отнимаем полученный урон от начального здоровья
//            Console.WriteLine($"Персонаж получил {damage} урона. {health} Текущее здоровье."); //Объявляем в консоль информацию о персонаже
//        }
//    }
//}


//Задание 11

//Console.WriteLine("Select a warrior class(Warrior, Mage, Rogue, Paladin, Barbarian, Hunter, Druid, Priest)");
//string Wclass = Console.ReadLine().ToLower();
//Console.WriteLine(Wclass switch
//{
//    "warrior" => "Close combat",
//    "mage" => "Long-range combat",
//    "rogue" => "Close combat",
//    "paladin" => "Close combat",
//    "barbarian" => "Close combat",
//    "hunter" => "Close combat",
//    "druid" => "Long-range combat",
//    "priest" => "Long-range combat",
//    _ => "Warrior class not found"
//});   

//Задание 12

//Console.WriteLine("Enter 3 positive numbers (each on a new line)");
//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int num3 = int.Parse(Console.ReadLine());
//int sum = 0;
//if (num1 > 0) sum += num1;
//if (num2 > 0) sum += num2;
//if (num3 > 0) sum += num3;
//Console.WriteLine(sum);

//Задание 13

Console.WriteLine("Вы — отважный искатель приключений, отправившийся в Темный Лабиринт, чтобы найти легендарного Dungeon Master’а. Вам предстоит пройти через несколько комнат, каждая из которых может иметь свои опасности и сокровища.");
Console.WriteLine("Выберите первую комнату(1 - Комната с огромным драконом; 2 - Пойти по темному коридору)(напишите номер комнаты)");
int room = int.Parse(Console.ReadLine());
if (room == 1)
{
    Console.WriteLine(@"Дракон - ""Кто не дышит, но живет; хоть не нужно — много пьет; и в жизни, и в смерти тело как лед."" ");
    string answer = Console.ReadLine().ToLower();
    if (answer == "рыба")
    {
        Console.WriteLine("Правильный ответ! (Дракон открыл вам дверь)");
    }
    else
    {
        Console.WriteLine("YOU IS DEAD");
        Console.WriteLine("GAME OVER");
        Console.WriteLine("HA-HA-HA");
    }
}
else if (room == 2)
{
    Console.WriteLine("Вы увидели темную комнату с двумя дверями");
    Console.WriteLine("Выберите дверь(1 или 2)");
    int door1 = int.Parse(Console.ReadLine());
    if (door1 == 1)
    {
        Console.WriteLine("ВЫ НАШЛИ СОКРОВИЩА Dungeon Master’а. ");
        Console.WriteLine("YOU ARE WIN");
    }
    else
    {
        Console.WriteLine("Вы наткнулись на ловушку с ядовитыми шипами");
        Console.WriteLine("GG");
    }    

}


