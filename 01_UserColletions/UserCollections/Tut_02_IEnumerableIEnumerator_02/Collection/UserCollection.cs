namespace Tut_02_IEnumerableIEnumerator_02.Collection
{
    public class UserCollection
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
        /// Указатель текущего элемента коллекции
        /// </summary>
        private int _position = -1;
        
        // Повторяем интерфейс IEnumerator, но без наследования
        public Element Current
        {
            get { return _elements[_position]; }
        }
        
        public bool MoveNext()
        {
            if (_position < _elements.Length - 1)
            {
                _position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            _position = -1;
        }
        
        // Повторяем интерфейс IEnumerable (без наследования)

        public UserCollection GetEnumerator()
        {
            return this;
        }
    }
}