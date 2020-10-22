using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace CustomEnumeratorYield
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class Garage //: IEnumerable
    {
        private readonly Car[] _arrayCar = new Car [4];

        public Garage()
        {
            _arrayCar[0] = new Car("Ford", 60);
            _arrayCar[1] = new Car("Kia", 50);
            _arrayCar[2] = new Car("Toyota", 80);
            _arrayCar[3] = new Car("Subaru", 85);
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
        //public IEnumerator GetEnumerator()
        //{
        //    return _arrayCar.GetEnumerator();
        //}

        /*
         * yield нужен для удобного доставания переменной
         * Сохраняет текущую позацию
         * Применяется для создания собственных итераторов
         * пример метод GetTheCars
         */
        public IEnumerable GetTheCars(bool reversed = false)
        {
            //Проверка на ошибки?
            return ActualEnumerable();

            IEnumerable ActualEnumerable()
            {
                if (reversed)
                {
                    for (var i = _arrayCar.Length; i != 0; i--)
                        yield return _arrayCar[i - 1];
                }
                else
                {
                    foreach (var car in _arrayCar)
                    {
                        yield return car;
                    }
                }
                    
            }
        }
    }
}
