using System;
using Tut_02_IEnumerableIEnumerator_02.Collection;

namespace Tut_02_IEnumerableIEnumerator_02
{
    class Program
    {
        /// <summary>
        /// Пример с повторением методов из интерфейсов IEnumerable и IEnumerator
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var collection = new UserCollection();

            collection[0] = new Element(1, 2);
            collection[1] = new Element(3, 4);
            collection[2] = new Element(5, 6);
            collection[3] = new Element(7, 8);

            foreach (Element element in collection)
            {
                Console.WriteLine("{0} {1}", element.FieldA, element.FieldB);
            }
            
            Console.ReadLine();
        }
    }
}