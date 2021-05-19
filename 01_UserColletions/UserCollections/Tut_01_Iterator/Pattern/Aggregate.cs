using System.Runtime.Versioning;

namespace Tut_01_Iterator.Pattern
{
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
        
        public abstract object this[int index] { get; set; }
    }
}