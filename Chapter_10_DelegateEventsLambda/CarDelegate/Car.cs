using System;
using System.Diagnostics.CodeAnalysis;

namespace CarDelegate
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Car
    {
        #region Fields

        private bool _carIsDead;

        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string CarName { get; set; }

        #endregion

        #region Ctors

        public Car() { }

        public Car(string carName, int currentSpeed, int maxSpeed)
        {
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
            CarName = carName;
        }

        #endregion

        #region Delegates
        //Переменная-член делегата
        private CarEngineHandler _listOfHandler;

        //Объявление делегата
        public delegate void CarEngineHandler(string msgForCaller);

        //Функция для вызывающего кода
        public void RegisterWithCarEngine(CarEngineHandler methodToCall) => _listOfHandler += methodToCall;

        #endregion

        #region Methods

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                _listOfHandler?.Invoke("К сожалению машина уничтожена");
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaxSpeed - CurrentSpeed))
                    _listOfHandler("Машина близка к уничтожению!");
                if (CurrentSpeed >= MaxSpeed)
                    _carIsDead = true;
                Console.WriteLine($"Текущая скорость {CurrentSpeed}");
            }
        }

        #endregion

    }
}
