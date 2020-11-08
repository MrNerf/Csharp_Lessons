using System;
using System.Diagnostics.CodeAnalysis;

namespace MultiLambdaParameters
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class MyMath
    {
        public EventHandler<MathEventArgs> MathEvent;

        public void Add(int x, int y) => MathEvent?.Invoke(this, new MathEventArgs("Произошло сложение", x+y));
    }
}
