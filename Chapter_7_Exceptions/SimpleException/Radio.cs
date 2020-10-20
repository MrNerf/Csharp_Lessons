using System;

namespace SimpleException
{
    public class Radio
    {
        public void TurnOn(bool on) => Console.WriteLine(on ? "Radio on" : "Radio off");
    }
}
