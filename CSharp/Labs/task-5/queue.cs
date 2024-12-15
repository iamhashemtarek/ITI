using System;

namespace task_5
{
    internal class Queue<T>
    {
        private T[] arr;
        private int start;
        private int end;  
        private int size;  
        public Queue(int size)
        {
            this.size = size;
            arr = new T[size];
            start = -1; 
            end = -1;  
        }

        public void Enqueue(T item)
        {
            if (IsFull())
                throw new Exception("Queue is full");

            if (start == -1)
                start = 0;

            end = (end + 1) % size; 
            arr[end] = item;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty");

            T item = arr[start]; 

            if (start == end) 
            {
                start = -1;
                end = -1;
            }
            else
            {
                start = (start + 1) % size; 
            }

            return item;
        }

        public bool IsEmpty()
        {
            return start == -1 && end == -1;
        }

        public bool IsFull()
        {
            return (end + 1) % size == start;
        }
        public T Peak()
        {
            if (!this.IsEmpty())
                throw new Exception("queue is empty");
            
            T item = arr[start];
            return item;
        }
    }
}
