using System;
using System.Collections;
using static System.String;

namespace ComparableCar
{
    public class NameCompare : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            if (x is Car car1 && y is Car car2)
            {
                return CompareOrdinal(car1.CarName, car2.CarName);
            }
            throw new ArgumentException("Parameter is not Car");
        }
    }
}
