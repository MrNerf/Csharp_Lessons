using System;

namespace MultiLambdaParameters
{
    public class MathEventArgs : EventArgs
    {
        public string Msg { get;}
        public int Result { get;}

        public MathEventArgs(string msg, int result)
        {
            Msg = msg;
            Result = result;
        }
    }
}
