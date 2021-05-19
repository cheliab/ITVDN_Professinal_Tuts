namespace Tut_01_Iterator.Pattern
{
    public class ConcreteIterator: Iterator
    {
        private readonly ConcreteAggregate aggregate;
        private int current;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        
        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object element = null;

            if (current <= aggregate.Count)
                element = aggregate[current++];
            
            return element;
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }
}