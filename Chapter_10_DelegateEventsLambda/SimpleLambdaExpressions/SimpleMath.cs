using System.Diagnostics.CodeAnalysis;

namespace SimpleLambdaExpressions
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class SimpleMath
    {
        public delegate void MathMessage(string msg, int result);

        private MathMessage _delMessage;

        public void SetMathHandler(MathMessage target) => _delMessage = target;

        public void Add(int x, int y) => _delMessage?.Invoke("Сложение прошло успешно", x + y);

    }
}
