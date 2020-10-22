using System;

namespace CustomEnumeratorYield
{
    public class Radio
    {
        public void TurnOn(bool on) => Console.WriteLine(on ? "Radio on" : "Radio off");
    }
}
