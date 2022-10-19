using System.Collections;
namespace Lab03_class;

public class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable<T>
{
    private readonly List<T> _data;
    public PriorityQueue()
    {
        _data = new List<T>();
    }
    
    public void Add(T element)
    {
        if (_data.Count == 0)
        {
            _data.Add(element);
        }
        else
        {
            int i = 0;
            int compare = 0;
            do
            {
                compare = element.CompareTo(_data[i]);
                if (compare == -1 || compare == 0)
                {
                    i++;
                }

            } while (compare == -1);
        
            _data.Insert(i, element);
        }
        
    }

    public T Peek()
    {
        return _data.First();
    }

    public T Remove()
    {
        T front = _data.First();
        _data.Remove(_data.First());
        return front;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new Iterator(this);
    }
    
    public class Iterator : IEnumerator<T>
    {
        private readonly PriorityQueue<T> _list;
        private int _current;

        public Iterator(PriorityQueue<T> list)
        {
            _list = list;
            _current = -1;
        }

        public bool MoveNext()
        {
            _current++;
            return _current < _list._data.Count;
        }

        public void Reset()
        {
            _current = -1;
        }

        public T Current => _list[_current];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
    public T this[int i] => _data[i];
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}