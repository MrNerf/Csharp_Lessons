using System;
using System.Diagnostics.CodeAnalysis;

namespace CarEvents
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
        
        //Объявление делегата
        public delegate void CarEngineHandler(string msgForCaller);

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        #endregion

        #region Methods

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Exploded?.Invoke("К сожалению машина уничтожена");
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaxSpeed - CurrentSpeed)) 
                    AboutToBlow?.Invoke("Машина близка к уничтожению!");

                if (CurrentSpeed >= MaxSpeed)
                    _carIsDead = true;
                Console.WriteLine($"Текущая скорость {CurrentSpeed}");
            }
        }

        #endregion

    }
}
