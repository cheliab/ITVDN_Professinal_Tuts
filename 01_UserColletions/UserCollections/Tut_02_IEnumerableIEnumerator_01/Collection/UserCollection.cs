using System;
using System.Collections;

namespace Tut_02_IEnumerableIEnumerator_01.Collection
{
    public class UserCollection: IEnumerable, IEnumerator, IDisposable
    {
        // Поле
        private readonly Element[] _elements = new Element[4];

        // Индексатор
        public Element this[int index]
        {
            get { return _elements[index]; }
            set { _elements[index] = value; }
        }

        /// <summary>
        /// Указатель текущего элемента в коллекции
        /// </summary>
        private int _position = -1;
        
        // Реализация интерфейса IEnumerator:
        #region IEnumerator
        
        // Метод MoveNext()
        public bool MoveNext()
        {
            if (_position < _elements.Length - 1)
            {
                _position++;
                return true;
            }

            return false;
        }

        // Метод Reset
        public void Reset()
        {
            _position = -1;
        }

        // Свойство Current
        public object Current
        {
            get { return _elements[_position]; }
        }
        
        #endregion

        // Реализация интерфейса IEnumerable
        #region IEnumerable
        
        /// <summary>
        /// Возвращаяет ссылку на енумератор
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator) this;
        }
        
        #endregion


        public void Dispose()
        {
            ((IEnumerator)this).Reset();
        }
    }
}