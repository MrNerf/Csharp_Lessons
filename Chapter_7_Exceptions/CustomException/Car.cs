using System;

namespace CustomException
{
    public class Car
    {
        #region Fields

        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; }
        public string CarName { get; set; }

        private bool _carDead;
        private readonly Radio _carRadio = new Radio();
        
        #endregion

        #region ctors

        public Car() { }

        public Car(string carName, int currentSpeed)
        {
            CarName = carName;
            CurrentSpeed = currentSpeed;
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
                    throw new CarIsDeadException($"{CarName} is overheated", "You have a lead foot", DateTime.Now) { HelpLink = "https://www.google.ru/" };
                }
                Console.WriteLine($"=> current speed = {CurrentSpeed}");
            }
        }

        #endregion
    }
}
