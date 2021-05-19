using System;
using System.Collections;
using System.Reflection.Emit;
using Tut_02_IEnumerableIEnumerator_01.Collection;

namespace Tut_02_IEnumerableIEnumerator_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new UserCollection();

            collection[0] = new Element(1, 2);
            collection[1] = new Element(3, 4);
            collection[2] = new Element(5, 6);
            collection[3] = new Element(7, 8);
            
            Console.WriteLine("Перебор через foreach");

            foreach (Element element in collection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }
            
            Console.WriteLine(new string('-', 5));

            // Код аналогичен тому, который использует компилятор при преобразовании foreach
            Console.WriteLine("Ручной перебор коллекции:");

            IEnumerator enumerator = ((IEnumerable)collection).GetEnumerator();

            while (enumerator.MoveNext())
            {
                Element element = (Element)enumerator.Current;
                
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }

            ((IDisposable)collection).Dispose();
            
            Console.ReadLine();
        }
    }
}