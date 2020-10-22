using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace ComparableCar
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class Garage : IEnumerable
    {
        private readonly Car[] _arrayCar = new Car [4];

        public Garage()
        {
            _arrayCar[0] = new Car("Toyota", 80, 3);
            _arrayCar[1] = new Car("Kia", 50, 4);
            _arrayCar[2] = new Car("Ford", 60, 2);
            _arrayCar[3] = new Car("Subaru", 85, 1);
        }

        /*
         * Реализовывать дополнительно методы интерфейса IEnumerator не нужно
         * Класс Array уже реализовывает эти методы
         * В дальнейшем возиожно придется реализовывать самому
         *
         * Для того чтобы скрыть данный метод для объектов класса
         * необходимо реализовывать интерфейс явно
         * пример: IEnumerator IEnumerable.GetEnumerator()
         * Тогда конструкция foreach будет работать
         * Однако самим методом будет пользоваться нельзя
         */
        public IEnumerator GetEnumerator() => _arrayCar.GetEnumerator();

        public IEnumerable ReverseOrSort(bool param = false)
        {
            if (param)
            {
                for (var i = _arrayCar.Length; i != 0; i--)
                {
                    yield return _arrayCar[i-1];
                }
            }
            else
            {
                var tempArray = _arrayCar;
                /*
                 * В данном случае сортировка будет по полю CarId
                 * Для других полей надо иначе реализовывать интефейс
                 */
                Array.Sort(tempArray);
                foreach (var car in tempArray)
                {
                    yield return car;
                }
            }
        }
    }
}
