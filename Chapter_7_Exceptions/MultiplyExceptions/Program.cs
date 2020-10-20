using System;
using System.Diagnostics.CodeAnalysis;

namespace MultiplyExceptions
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Обработка множества исключений";
            var car = new Car("Nissan", 50);
            car.RadioTune(true);
            try
            {
                car.Accelerate(100);
            }
            //Данное исключение не обрабатывается по вторникам
            catch (CarIsDeadException e)
            when(e.ErrorDateTime.DayOfWeek != DayOfWeek.Tuesday)
            {
                Console.WriteLine($"Сообщение исключения: {e.Message}");
                Console.WriteLine($"Причина исключения: {e.CauseOfError}");
                Console.WriteLine($"Время исключения: {e.ErrorDateTime}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Сообщение исключения {e.Message}");
            }
            /*
             * Обработчик прочих исключений
             * Всегда помещается последним в блоках catch
             * Иначе будет ошибка компиляции
             * Обработчик прочих исключений поможет выявить фантомные ошибки
             */
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                car.RadioTune(false);
            }
            Console.ReadLine();
        }
    }
}
