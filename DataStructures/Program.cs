using DataStructures.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public  class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> arrayQueue = new LinkedQueue<int>(3);
            arrayQueue.Enqueue(5);
            arrayQueue.Enqueue(6);
            arrayQueue.Enqueue(7);
            arrayQueue.Enqueue(8);
            arrayQueue.Enqueue(5);
            while (arrayQueue.Count != 0)
            {
                Console.WriteLine(arrayQueue.Dequeue());
            }
        }
    }
}
