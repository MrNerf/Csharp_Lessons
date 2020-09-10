using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ArraysAndStructures
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Arrays and structures console program";
            Console.ForegroundColor = ConsoleColor.Green;
            ObjectArray();
            Console.WriteLine();
            MultiArray(5,5);
            Console.WriteLine();
            ArrayFunctionality();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Реализация метода с модификатором ref");
            var s1 = "Flip";
            var s2 = "Flop";
            Console.WriteLine($"Начальные значения строк: S1= {s1}, S2= {s2}");
            SwapFunc(ref s1, ref s2);
            Console.WriteLine($"Измененные значения строк: S1= {s1}, S2= {s2}");
            Console.WriteLine();
            Console.WriteLine();
            string[] array = {s1, s2, s1};
            Console.WriteLine($"Начальные значения: [0]= {array[0]}, [1]= {array[1]}, [2]={array[2]}");
            ref var tmp = ref RefFunction(array, 1);
            tmp = "Что-то новое";
            Console.WriteLine($"Измененные значения: [0]= {array[0]}, [1]= {array[1]}, [2]={array[2]}");
            Console.WriteLine();
            Console.WriteLine();
            var rnd = new Random();
            var doubleArray = new double[50];
            for (var i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = rnd.NextDouble();
            }

            var result = CalculateAverage(doubleArray);
            Console.WriteLine($"Результат:= {result}");
            result = CalculateAverage(40.1,56.1,2.56,46.99);
            Console.WriteLine($"Результат:= {result}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Вызов функции с параметром по умолчанию");
            Console.WriteLine("Вызов без изменения параметра");
            DefaultFunc("log №1");
            Console.WriteLine("Вызов с изменением параметра");
            DefaultFunc("log №2", "Viacheslav");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Пример функции с передачей параметров не по порядку");
            Console.WriteLine("Вывод базовых значений");
            DisplayMessage();
            Console.WriteLine("Изменим цвет фона");
            DisplayMessage(backgroundColor: ConsoleColor.White);
            Console.WriteLine("Изменим цвет текста и сам текст");
            DisplayMessage(ConsoleColor.Cyan, message: "Новый текст");
            Console.ReadLine();
        }

        #region Array region

        private static void ObjectArray()
        {
            Console.WriteLine("Создание массива объектов");
            var arrayObj = new object[5];
            arrayObj[0] = new Guid();
            arrayObj[1] = 666;
            arrayObj[2] = "какая-то строка";
            arrayObj[3] = new DateTime(2020, 9, 10, 13, 40, 00);
            arrayObj[4] = false;
            foreach (var obj in arrayObj)
            {
                Console.WriteLine($"Тип: {obj.GetType()}, Значение:= {obj}");
            }
        }

        private static void MultiArray(int length, int width)
        {
            Console.WriteLine("Двумерный массив");
            var rnd = new Random();
            var array = new int[length, width];
            for (var i = 0; i < length; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    array[i, j] = rnd.Next(100);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        private static void ArrayFunctionality()
        {
            Console.WriteLine("Базовые функции работы с массивами");
            string[] stringArray = { "second elemenst", "first element", "third element" };
            Console.WriteLine("Базовый массив");
            foreach (var s in stringArray)
            {
                Console.Write(s + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("Реверсивный массив:");
            Array.Reverse(stringArray);
            foreach (var s in stringArray)
            {
                Console.Write(s + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("Отсортированный массив");
            Array.Sort(stringArray);
            foreach (var s in stringArray)
            {
                Console.Write(s + "\t");
            }

            Console.WriteLine();
            Console.WriteLine($"Ранг массива:= {stringArray.Rank} \nДлина массива:= {stringArray.Length}");

            Console.WriteLine("удаленный массив");
            Array.Clear(stringArray, 0, 2);
            foreach (var s in stringArray)
            {
                Console.Write(s + "\t");
            }
            Console.WriteLine();
        }

        #endregion

        #region Fun with functions

        private static void SwapFunc(ref string s1, ref string s2)
        {
            var tmp = s1;
            s1 = s2;
            s2 = tmp;
        }

        private static ref string RefFunction(string[] array, int position)
        {
            return ref array[position];
        }

        //Функция с неограниченным числом входных параметров
        private static double CalculateAverage(params double[] values)
        {
            Console.WriteLine($"Было занесено {values.Length} значений");
            if (values.Length == 0)
                return 0;
            var sum = values.Sum();

            return sum / values.Length;
        }

        //Функция с параметром по умолчанию
        private static void DefaultFunc(string log, string user = "user")
        {
            Console.WriteLine($"Лог номер {log}, автор лога: {user}");
        }

        private static void DisplayMessage(ConsoleColor textColor = ConsoleColor.DarkRed,
            ConsoleColor backgroundColor = ConsoleColor.Gray, string message = "Simple message")
        {
            var oldText = Console.ForegroundColor;
            var oldBack = Console.BackgroundColor;

            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = textColor;
            Console.WriteLine(message);

            Console.BackgroundColor = oldBack;
            Console.ForegroundColor = oldText;
        }
        #endregion
    }
}
