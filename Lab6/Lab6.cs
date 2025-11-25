namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int x = 5;
            //    int y = x / 0;
            //    Console.WriteLine($"Результат: {y}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Блок finally");
            //}
            //Console.WriteLine("Конец программы");

            //Console.WriteLine("Введите первое число: ");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите второе число: ");
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите операцию (+, -, *, .): ");
            //string? op = Console.ReadLine();
            //double result = 0;

            //if (op == "+") result = number1 + number2;
            //else if (op == "-") result = number1 - number2;
            //else if (op == "*") result = number1 * number2;
            //else if (op == "/") result = number1 / number2;
            //else Console.WriteLine("Неизвестная операция");
            //while (true)
            //{
            //    try
            //    {
            //        switch (op)
            //        {
            //            case "+": result = number1 + number2; break;
            //            case "-": result = number1 - number2; break;
            //            case "*": result = number1 * number2; break;
            //            case "/":
            //                if (number2 == 0)
            //                    throw new DivideByZeroException("Нельзя делить на ноль!");
            //                result = number2 / number1; break;
            //            default: Console.WriteLine("Неизвестная операция"); return;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Ошибка ввода! Введите корректные числа.");
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Произошла непревиденная ошибка: {ex.Message}");
            //    }
            //}

            //int number = 12;
            //Console.WriteLine(number.ToString());
            //bool boolean = true;
            //Console.WriteLine(boolean.ToString());
            //DateTime now = DateTime.Now;
            //Console.WriteLine(now.ToString());
            //object me = new();
            //Console.WriteLine(me.ToString());

            //int age = int.Parse("27");
            //DateTime birthday = DateTime.Parse("4 July 1980");

            //Console.Write("Какой максимальный балл по дисциплинам? ");
            //string? input = Console.ReadLine();
            //if (int.TryParse(input, out int count))
            //{
            //    Console.WriteLine($"Это {count} баллов.");
            //}
            //else
            //{
            //    Console.WriteLine("Некорректный ввод.");
            //}

            //Console.Write("Введите сумму: ");
            //string? amount = Console.ReadLine();
            //try
            //{
            //    decimal amountValue = decimal.Parse(amount);
            //}
            //catch (FormatException) when (amount.Contains("$"))
            //{
            //    Console.WriteLine("В суммах нельзя использовать знак доллара!");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Суммы должны содержать только цифры!");
            //}

            //try
            //{
            //    checked
            //    {
            //        int x = int.MaxValue - 1;
            //        Console.WriteLine($"Initial value: {x}");
            //        x++;
            //        Console.WriteLine($"After incrementing: {x}");
            //        x++;
            //        Console.WriteLine($"After incrementing: {x}");
            //        x++;
            //        Console.WriteLine($"After incrementing: {x}");
            //    }
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The code overflowed but I caught the exception.");
            //}

            // задание 1

            //while (true)
            //{
            //    Console.WriteLine("Введите первое число: ");
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Введите второе число: ");
            //    double b = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Введите операцию (+, -, *, /, ^) or 'exit' to stop working: ");

            //    string? op = Console.ReadLine();

            //    if (op == "exit")
            //        break;

            //    double result = 0;

            //    static double Sum(double a, double b)
            //    {
            //        return a + b;
            //    }
            //    static double Minus(double a, double b)
            //    {
            //        return a - b;
            //    }
            //    static double Umn(double a, double b)
            //    {
            //        return a * b;
            //    }
            //    static double Del(double a, double b)
            //    {
            //        if (b == 0)
            //        {
            //            return 0;
            //        }
            //        return a / b;
            //    }
            //    static double Step(double a, double b)
            //    {
            //        return Math.Pow(a, b);
            //    }
            //    switch (op)
            //    {
            //        case "+": result = Sum(a, b); break;
            //        case "-": result = Minus(a, b); break;
            //        case "*": result = Umn(a, b); break;
            //        case "/": result = Del(a, b); break;
            //        case "^": result = Step(a, b); break;
            //    }
            //    Console.WriteLine(result);
            //}

            // Задание 3 

            //Console.Write("Введите делимое: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b;
            //double result = 0;

            //while (true)
            //{
            //    Console.Write("Введите делитель: ");
            //    b = Convert.ToDouble(Console.ReadLine());

            //    if (b == 0)
            //    {
            //        Console.Write("На ноль делить нельзя. Повторите ввод делителя: ");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //result = a / b;
            //Console.WriteLine($"Результат деления: {result}");

            // задание 4

            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("Введите целое число: ");
            //        int a = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Неверный ввод!");
            //    }
            //}

            // задание 5

            while (true)
            {
                try
                {
                    // ИСПРАВЛЕНИЕ 1: Добавлена обработка FormatException
                    Console.WriteLine("Введите первое число: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите второе число: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите операцию (+, -, *, /, ^) or 'exit' to stop working: ");
                    string? op = Console.ReadLine();

                    if (op == "exit")
                        break;

                    double result = 0;

                    static double Sum(double a, double b)
                    {
                        return a + b;
                    }
                    static double Minus(double a, double b)
                    {
                        return a - b;
                    }
                    static double Umn(double a, double b)
                    {
                        return a * b;
                    }
                    static double Del(double a, double b)
                    {
                        // ИСПРАВЛЕНИЕ 2: Правильная проверка деления на ноль
                        if (b == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль!");
                            return 0; // специальное значение для ошибки
                        }
                        return a / b;
                    }
                    static double Step(double a, double b)
                    {
                        // ИСПРАВЛЕНИЕ 3: Исправлено присваивание переменных
                        return Math.Pow(a, b); // ПРАВИЛЬНО: a в степени b
                    }

                    bool validOperation = true;

                    switch (op)
                    {
                        case "+": result = Sum(a, b); break;
                        case "-": result = Minus(a, b); break;
                        case "*": result = Umn(a, b); break;
                        case "/": result = Del(a, b); break;
                        case "^": result = Step(a, b); break;
                        default:
                            Console.WriteLine("Неизвестная операция!");
                            validOperation = false;
                            break;
                    }

                    if (validOperation)
                        Console.WriteLine($"Результат: {result}");
                }
                catch (FormatException)
                {
                    // ИСПРАВЛЕНИЕ 1: Обработка неверного формата ввода.
                    Console.WriteLine("Ошибка! Введите корректное число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                }
            }
        }
    }
}
