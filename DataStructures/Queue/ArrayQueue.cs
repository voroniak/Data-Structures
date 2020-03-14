using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    public class ArrayQueue<T>
    {
        private T [] _items;
        private T Head => _items[Count-1];
        private T Tail => _items[0];
        public int Count => _items.Length;
        public ArrayQueue() { }
        public ArrayQueue(T data)
        {
            _items = new T[1];
            _items[0] = data;
        }
        public void Enqueue(T data)
        {
            T[] ts = new T[Count + 1];
            ts[0] = data;
            _items.CopyTo(ts,1);
            _items = ts;
           
        }
        public T Dequeue()
        {
            var item = Head;
            T[] ts = new T[Count - 1];
            for (int i = 0; i < Count - 1; i++)
            {
                ts[i] = _items[i];
            }
            _items = ts;
      
            return item;
        }
        public T Peek()
        {
            return Head;
        }

    }
}
