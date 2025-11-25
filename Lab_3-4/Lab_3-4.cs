namespace lab_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            namespace AlekseevaFirsovaLab4
    {
        enum Hero { Воин, Маг, Вор }
        enum TimeOfDay { Утро, День, Вечер, Ночь }
        enum TrafficLight { Red, Yellow, Green }
        enum ORstate { New, Processing, Shipped, Delivered }
        internal class Program
        {
            static void Main(string[] args)
            { //LAB 3
                ///*
                //for
                //}
                //*/
                ////for (int i = 0, j = 0; i < 10; i++, j++)
                ////{
                ////    Console.WriteLine($"{i*j}");
                ////}

                ////int sum = 0;
                ////for (int i = 1; i <= 10; i++)
                ////{
                ////    sum += i;
                ////}
                ////Console.WriteLine(sum);

                ////int i = 10;
                ////while(i > 0)
                ////{
                ////    Console.WriteLine(i);
                ////    i--;
                ////}

                //int j = -1;
                //do
                //{
                //    Console.WriteLine(j);
                //    j--;
                //}
                //while(j > 0);

                //string text = "hello world";
                //foreach(var symbol in text)
                //{
                //    Console.WriteLine(symbol);
                //}

                //for (int i = 1; i < 10; i ++)
                //{
                //    for (int j = 1; j < 10; j++)
                //    {
                //        Console.WriteLine($"{i * j} \t");
                //    }
                //    Console.WriteLine();
                //}

                ///*
                //Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine("введите фразы для повторения или 'выход'");
                //while (true)
                //{ Console.Write("> ");
                //    string us = Console.ReadLine();
                //    ().ToLower();
                //    if (us == "выход") break;
                //    Console.WriteLine(us);
                //}
                //int number = 10;
                //DayOfWeek day = DayOfWeek.Суббота;   
                //Console.WriteLine((int)day);
                //switch (day)
                //{
                //    case DayOfWeek.Суббота:
                //    case DayOfWeek.Воскресенье:
                //        Console.WriteLine("Выходной");
                //            break; 
                //    default:
                //        Console.WriteLine("Будний день");
                //            break;
                //}
                //enum DayOfWeek
                //{
                //    Понедельник = 1, Вторник, Среда = 2, Четверг = 2, Пятница, Суббота, Воскресенье
                //}

                //var times = Enum.GetValues(typeof(TimeOfDay));
                //var heroes = Enum.GetValues(typeof(Hero));

                //for (int i = 0; i < times.Length; i++)
                //{
                //    TimeOfDay time = (TimeOfDay)times.GetValue(i);
                //    Console.WriteLine($"\nВремя сейчас {time}:");

                //    for (int j = 0; j < heroes.Length; j++)
                //    {
                //        Hero h = (Hero)heroes.GetValue(j);
                //        Console.Write($"{h} - ");

                //        switch (time)
                //        {
                //            case TimeOfDay.Утро:
                //                Console.WriteLine(h switch
                //                {
                //                    Hero.Воин => "делает зарядку",
                //                    Hero.Маг => "заваривает зелья",
                //                    Hero.Вор => "крадётся по базару",
                //                    _ => "ничего не делает"
                //                });
                //                break;
                //            case TimeOfDay.День:
                //                Console.WriteLine(h switch
                //                {
                //                    Hero.Воин => "тренируется на арене",
                //                    Hero.Маг => "изучает древние книги",
                //                    Hero.Вор => "прячется в тенях",
                //                    _ => "ничего не делает"
                //                });
                //                break;
                //            case TimeOfDay.Вечер:
                //                Console.WriteLine(h switch
                //                {
                //                    Hero.Воин => "ест мясо у костра",
                //                    Hero.Маг => "создаёт магический щит",
                //                    Hero.Вор => "планирует налет",
                //                    _ => "ничего не делает"
                //                });
                //                break;
                //            case TimeOfDay.Ночь:
                //                Console.WriteLine(h switch
                //                {
                //                    Hero.Воин => "спит в палатке",
                //                    Hero.Маг => "медитирует под луной",
                //                    Hero.Вор => "лезет в чужой дом",
                //                    _ => "ничего не делает"
                //                });
                //                break;
                //        }
                //    }


                // задание 1
                //TrafficLight now = TrafficLight.Green;
                //TrafficLight next;
                //if (now == TrafficLight.Green)
                //{
                //    next = TrafficLight.Red;
                //}
                //else if (now == TrafficLight.Green)
                //{
                //    next = TrafficLight.Yellow;
                //}
                //else
                //{
                //    next = TrafficLight.Red;
                //}
                //Console.WriteLine("Текущий цвет светофора: " + now);
                //Console.WriteLine("Следующий цвет светофора: " + next);

                // задание 2
                //Console.WriteLine("Выберите статус заказа:");
                //Console.WriteLine("1 - New");
                //Console.WriteLine("2 - Processing");
                //Console.WriteLine("3 - Shipped");
                //Console.WriteLine("4 - Delivered");
                //int inp = int.Parse(Console.ReadLine());
                //OrderStatus now;
                //if (inp == 1)
                //{
                //    now = OrderStatus.New;
                //    Console.WriteLine($"Статус заказа: " + now);
                //    Console.WriteLine("Заказ можно отменить");
                //}
                //else if (inp == 2)
                //{
                //    now = OrderStatus.Processing;
                //    Console.WriteLine($"Статус заказа: " + now);
                //    Console.WriteLine("Заказ можно отменить");
                //}
                //else if (inp == 3)
                //{
                //    now = OrderStatus.Shipped;
                //    Console.WriteLine($"Статус заказа: " + now);
                //    Console.WriteLine("Заказ нельзя отменить");
                //}
                //else if (inp == 4)
                //{
                //    now = OrderStatus.Delivered;
                //    Console.WriteLine($"Статус заказа: " + now);
                //    Console.WriteLine("Заказ нельзя отменить");
                //}

                // задание 3
                //for (int i = 10; ; i--)
                //{
                //    Console.WriteLine(i);
                //    if (i == 1)
                //        break;
                //}

                // задание 4
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine($"5 x {i + 1} = {5 * (i + 1)}");
                //}

                // задание 5
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine("Запомни: всего одна ошибка и ты ошибся.");
                //}

                // задание 6
                //int n = int.Parse(Console.ReadLine());
                //for (int i = 0; i < n; i++)
                //{
                //    Console.WriteLine($"Квадрат числа {i + 1} равен {Math.Pow(i+1,2)}");
                //}

                // задание 7
                //int tries = int.Parse(Console.ReadLine());
                //string pr = Console.ReadLine();
                //for (int i = 0; i < tries; i++)
                //{
                //    Console.WriteLine(pr);
                //}

                // задание 8
                //for (int i = 0; i < 10; i++)
                //{
                //    int num = int.Parse(Console.ReadLine());
                //    if (num % 2 == 0)
                //    {
                //        Console.WriteLine("YES");
                //    }
                //    else
                //    {
                //        Console.WriteLine("NO");
                //    }
                //}

                // задание 9
                //Console.WriteLine("Добро пожаловать на стрельбище");
                //Console.WriteLine("Введите 'Стоп', чтобы завершить стрельбу.");
                //int s = 0;
                //for (int i =0; ; i++)
                //{
                //    Console.Write("Нажмите Enter для выстрела: ");
                //    string shoot = Console.ReadLine();
                //    if (shoot == "Стоп")
                //        break;
                //    s += 1;
                //    Console.WriteLine("Выстрел совершен.");
                //}
                //Console.WriteLine("Стрельба завершена");
                //Console.WriteLine($"Израсходовано боеприпасов: {s}");

                //LAB 4
                //int[] number = [12, 23, 45, 56];
                //int[] num = { 12, 23, 45, 56 };
                //int[] number3 =new int[] { 12, 23, 45, 56 };
                //int[] number4 = new int[4] { 12, 23, 45, 56 };
                //int[] number5 = new [] { 12, 23, 45, 56 };
                //foreach (var i in number)
                //{
                //    Console.WriteLine(i);
                //}
                //number[0] = 345;
                //Console.WriteLine(number.Length);
                //Console.WriteLine(number3[^1]);    


                //int[] numbers = [-1, -2, -3, 4, 5, 6, 0, 43, 56, -34, 12, 45, 102,76, -45, 96,-4, -3,5,76, 6,8,2,0,5, 9];
                //int result = 0;
                //foreach (int number in numbers)
                //{
                //    if (number > 0)
                //        result++;
                //}
                //Console.WriteLine($"Число элементов больше нуля: {result}");

                //int[] numbers = [-1, -2, -3, 4, 5, 6, 0, 43, 56, -34, 12, 45, 102, 76, -45, 96, -4, -3, 5, 76, 6, 8, 2, 0, 5, 9];
                //int result = 0;
                //for (int i = 0; i < numbers.Length; i++)
                //{
                //    if (numbers[i] > 0)
                //        result++;
                //}
                //Console.WriteLine($"Число элементов больше нуля: {result}");

                //int[] numbers = [-1, -2, -3, 4, 5, 6, 0, 43, 56, -34, 12, 45, 102, 76, -45, 96, -4, -3, 5, 76, 6, 8, 2, 0, 5, 9];
                //int result = 0;
                //int index = 0; 
                //while (index < numbers.Length)
                //{
                //    if (numbers[index] > 0)
                //        result++;
                //    index++; 
                //}
                //Console.WriteLine($"Число элементов больше нуля: {result}");

                //int[] numbers = [-1, -2, -3, 4, 5, 6, 0, 43, 56, 34, 12, 45, 102, 76, -45, 96, -4, -3, 5, 76, 6, 8, 2, 0, 5, 9];
                //int n = numbers.Length;
                //int k = n / 2;
                //int temp;// Объявление вспомогательной переменной для обмена значениями
                //for (int i = 0; i < k; i++) {
                //    temp = numbers[i]; // Сохранение текущего элемента в переменной temp
                //    numbers[i] = numbers[n - i - 1]; // Замена текущего элемента на симметричный элемент с конца массива
                //    numbers[n - i - 1] = temp; // Замена симметричного элемента на сохраненный элемент
                //}
                //foreach (int i in numbers)
                //{
                //    Console.Write($"{i} \t");
                //} // Вывод текущего элемента массива табуляцией

                // int[] nums = {54, 7, 41, 2, 4, 2, 89, 33, 5, 12};
                // int temp;
                //for (int i = 0; i < nums.Length - 1; i++)
                // {
                //    for (int j = i + 1; j < nums.Length; j++)
                //     {
                //        if (nums[i] > nums[j])
                //       {
                //          temp = nums[i];
                //            nums[i] = nums[j];
                //            nums[j] = temp;
                //         }
                //    }

                // }
                // Console.WriteLine("Вывод отсортированного массива:");
                //for (int i = 0; i < nums.Length; i++)
                // {
                //     Console.WriteLine(nums[i]);
                // }
                //List<string> student = ["Билли", "Игорь", "Степан"];
                //student.Add("Van"); // добавление нового элемента в список
                //student.AddRange(["Антон", "Денис"]);
                //student.Insert(1, "Кирилл"); // вставляет элемент item в список по индексу index
                //student.InsertRange(1, ["Mike", "Kate"]); // вставляет коллекцию элементов
                //                                          // начиная с индекса index
                //student.Insert(7, "Михаил"); // вставляет элемент item в список по индексу index
                //foreach (var person in student)
                //{
                //    Console.WriteLine(person);
                //}
                //var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
                //people.RemoveAt(1); // удаляем второй элемент
                //people.Remove("Tom"); // удаляем элемент: "Том"
                //people.RemoveRange(1, 2);
                //people.Clear();


                // задание 1
                //string[] items = ["sword", "shield", "potion", "sword", "potion", "potion"];

                // задание 2
                //int[] points = [10, 20, 15, 30, 25];
                //int c = 0;
                //foreach (int score in points)
                //{
                //    c += score;
                //}
                //Console.WriteLine(c);

                // задание 3
                //int[] numbers = [1, 3, 7, 2, 5];
                //int res = numbers[0];
                //for (int i = 1; i < numbers.Length; i++)
                //{
                //    if (numbers[i] > res)
                //    {
                //        res = numbers[i];
                //    }
                //}
                //Console.WriteLine(res);

                // задание 4
                //int[] nums = [1, 2, 3, 4, 5];
                //int ch = 0;
                //int nech = 0;
                //foreach (int num in nums)
                //{
                //    if (num % 2 == 0)
                //    {
                //        ch++;
                //    }
                //    else if(num % 2 == 1 )
                //    {
                //        nech++;
                //    }
                //}
                //Console.WriteLine($"Четные: {ch}");
                //Console.WriteLine($"Нечетные: {nech}");

                // задание 5
                //int[] time = [120, 95, 110, 105, 100];
                //int mintime = time[0];
                //for (int i = 0; i < time.Length; i++)
                //{
                //    if (time[i] < mintime)
                //    {
                //        mintime = time[i];
                //    }
                //}
                //Console.WriteLine(mintime);

                // задание 6
                //string[] win_lose = ["win", "lose", "win", "win", "lose"];
                //int win = 0;
                //int lose = 0;
                //foreach(string i in win_lose)
                //{
                //    if (i == "win")
                //    {
                //        win++;
                //    }
                //    else if (i == "lose")
                //    {
                //        lose++;
                //    }
                //}
                //Console.WriteLine($"Победы: {win}");
                //Console.WriteLine($"Проигрыши: {lose}");

                // задание 7
                //int[] nums = [15, 20, 25, 30, 10];
                //int sum = 0;
                //foreach(int num in nums)
                //{
                //    sum += num;
                //}
                //Console.WriteLine($"{sum / nums.Length}");

                // задание 8
                //string[] inv1 = ["Меч", "Ласточка", "Бомба", "Зелье Гром", "Ласточка"];
                //foreach (string inv in inv1)
                //{
                //    Console.Write(inv + ' ');
                //}
                //string po = "Кошка";
                //for(int item = 0; item < inv1.Length; item++)
                //{
                //    if (inv1[item] == "Ласточка")
                //    {
                //        inv1[item] = po ;
                //    }

                //}
                //Console.WriteLine();
                //foreach (string inv in inv1)
                //{
                //    Console.Write(inv + ' ');
                //}

                // задание 9
                //string[] party = ["Garrus", "Tali", "Mordin", "Grunt", "Jack"];
                //for(int human = 0; human < party.Length; human++)
                //{
                //    if (party[human] == "Garrus")
                //    {
                //        Console.WriteLine($"Лидер команды: {party[human]}");
                //    }
                //    else if (party[human] == "Tali")
                //    {
                //        Console.WriteLine($"Техник: {party[human]}");
                //    }
                //    else if (party[human] == "Mordin")
                //    {
                //        Console.WriteLine($"Биотик: {party[human]}");
                //    }
                //    else if (party[human] == "Grunt")
                //    {
                //        Console.WriteLine($"Солдат: {party[human]}");
                //    }
                //    else if (party[human] == "Jack")
                //    {
                //        Console.WriteLine($"Поддержка: {party[human]}");
                //    }



            }

        }
    }
}
    }
}
