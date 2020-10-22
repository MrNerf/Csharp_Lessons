using System;
using System.Diagnostics.CodeAnalysis;

namespace ComparableCar
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class Car : IComparable
    {
        #region Fields

        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; }
        public string CarName { get; set; }
        public int CarId { get; set; }

        private bool _carDead;
        private readonly Radio _carRadio = new Radio();
        
        #endregion

        #region ctors

        public Car() { }

        public Car(string carName, int currentSpeed, int carId)
        {
            CarName = carName;
            CurrentSpeed = currentSpeed;
            CarId = carId;
        }
        #endregion

        #region Methods

        public void RadioTune(bool state) => _carRadio.TurnOn(state);

        public void Accelerate(int delta)
        {
            if (_carDead)
                Console.WriteLine($"{CarName} is broken");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    //Console.WriteLine
                    CurrentSpeed = 0;
                    _carDead = true;
                    throw new Exception($"{CarName} is overheated") { HelpLink = "https://www.google.ru/" };
                }
                Console.WriteLine($"=> current speed = {CurrentSpeed}");
            }
        }

        #endregion

        #region RealixationMethods

        /*
         * В данном случае сортировка будет по полю CarId
         * Для других полей надо иначе реализовывать интефейс
         */

        int IComparable.CompareTo(object obj)
        {
            /*
             * Сводка возращаемых значений
             * Любое число меньше нуля - этот экземпляр находится перед указанным объектом в порядку сортировки
             * Любое число больше нуля - этот экземпляр находится после указанного объекта в порядку сортировки
             * Ноль - Экземпляр равен указанному объекту
             */
            if (!(obj is Car tempCar))
                throw new ArgumentException("Переданный параметр не является объектом класса Car");
            if (CarId > tempCar.CarId)
                return 1;
            if (CarId < tempCar.CarId)
                return -1;
            return 0;

        }

        #endregion

    }
}
