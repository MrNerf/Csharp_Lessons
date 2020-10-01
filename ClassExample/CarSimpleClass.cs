using System.Diagnostics.CodeAnalysis;

namespace ClassExample
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class CarSimpleClass
    {
        public string CarName;
        public int Speed;

        public CarSimpleClass()
        {
            CarName = "Default";
            Speed = 0;
        }

        public CarSimpleClass(string nCarName, int nSpeed)
        {
            CarName = nCarName;
            Speed = nSpeed;
        }

        public CarSimpleClass(string carName)
        {
            this.CarName = carName;
            Speed = 50;
        }

        public void SpeedUp() => Speed++;
        public override string ToString()
        {
            return "Машина: " + CarName + ", движется со скоростью: " + Speed + "км/ч";
        }
    }
}
