using System;

namespace CarEventArgs
{
    public class CarEventArgs : EventArgs
    {
        public string Msg { get; }

        public CarEventArgs(string msg) => Msg = msg;
    }
}
