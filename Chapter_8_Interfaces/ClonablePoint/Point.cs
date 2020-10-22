using System;
using System.Diagnostics.CodeAnalysis;

namespace CloneablePoint
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class Point : ICloneable
    {
        #region Fields

        public int X { get; set; }
        public int Y { get; set; }
        public PointerDescription Description = new PointerDescription();

        #endregion

        #region Ctors

        public Point() { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Description.PointName = name;
        }

        #endregion

        public override string ToString() => $"X: {X}, Y: {Y}\nName: {Description.PointName}, ID: {Description.PointGuid}";

        /*
         * MemberwiseClone() копирует все поля класса
         * Но можно и реализовыввать иначе
         *      Пример:
         * public object Clone() => new Point(X,Y);
         *
         * Если в объекте присутствует ссылочный тип
         * Реализация метода расширяется.
         */
        public object Clone()
        {
            var clonePoint = (Point)MemberwiseClone();

            var cloneDescription = new PointerDescription
            {
                PointName = Description.PointName, PointGuid = Description.PointGuid
            };

            clonePoint.Description = cloneDescription;
            return clonePoint;

        }
    }
}
