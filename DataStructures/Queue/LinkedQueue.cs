using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
   public class LinkedQueue<T>
    {
        private Item<T> head;
        private Item<T> tail;
        public int Count { get; private set;}
        public LinkedQueue(T data)
        {
            head = new Item<T>(data);
            tail = new Item<T>(data);
            tail.Next = head;
            Count++;
        }
        public void Enqueue(T data)
        {
            
            Item<T> item = new Item<T>(data);
            item.Next = tail;
            tail = item;
            Count++;
        }
        public T Dequeue()
        {
           var item = tail;
           while(item.Next != head)
           {
                item = item.Next;
           }
            head = item;
            Count --;
            return item.Data;
        }
        public T Peek()
        {
            return head.Data;
        }
    }
}
