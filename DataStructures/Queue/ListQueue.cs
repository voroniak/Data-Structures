using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
   public class QueueList<T>
    {
        private List<T> _items = new List<T>();
        private T Head => _items.Last();
        private T Tail => _items.First();
        public int Count => _items.Count;
        public QueueList() { }
        public QueueList(T data)
        {
            _items.Add(data);
        }
        public void Enqueue(T data)
        {
            _items.Insert(0, data);
        }
        public T Dequeue()
        {
            var item = Head;
            _items.RemoveAt(Count - 1);
            return item;
        }
        public T Peek()
        {
            return Head;
        }

    }
}
