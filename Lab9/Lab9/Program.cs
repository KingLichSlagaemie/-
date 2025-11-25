using MathLibrary;
using Newtonsoft;
using Newtonsoft.Json;

namespace Lab9
    internal class Program
    { 
        //3
        public delegate void Logger(string message);
        static void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }
        static void PrintLength(string? input)
        {
            if (input != null)
            {
                Console.WriteLine(input.Length);
            }
            else
            {
                Console.WriteLine("строка отсутствует.");
            }
        }


        static void Main(string[] args)
        {
            //1
            MathTools mathTools = new MathTools();
            Console.WriteLine(mathTools.Add(4, 5));
            Console.WriteLine(mathTools.Multiply(4, 5));
            Logger logger = LogToConsole;
            logger("Hello world!");
            //4
            Thermometer thermometer = new Thermometer();
            thermometer.TemperaturePLUS(120);
            //5
            PrintLength(Console.ReadLine());
            PrintLength(Console.ReadLine());
            //6
            SmartLight light = new(true, 75);
            light.Toggle();
            light.Toggle();
            light.Toggle();
            string json = JsonConvert.SerializeObject(light);
            Console.WriteLine(light);
            var deserialized = JsonConvert.DeserializeObject<SmartLight>(json);
            Console.WriteLine(light);
        }
            
            
        }
    }

