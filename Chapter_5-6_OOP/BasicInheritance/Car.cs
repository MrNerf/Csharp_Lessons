namespace BasicInheritance
{
    public class Car
    {
        public readonly int MaxSpeed;
        private int _currentSpeed;

        public int CurrentSpeed
        {
            get => _currentSpeed;
            set => _currentSpeed = value>MaxSpeed ? MaxSpeed : value;
        }

        public Car() : this(55) { }
        public Car(int maxSpeed) => MaxSpeed = maxSpeed;
        
    }
}
