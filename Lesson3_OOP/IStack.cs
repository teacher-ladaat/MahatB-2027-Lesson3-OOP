using System;

namespace Lesson3_OOP
{
    // ממשק - Interface
    // קשר של יכולת
    internal interface IStack<T>
    {
        // push
        void Push(T value);

        // pop
        T Pop();

        // top
        T Top();

        // isEmpty
        bool IsEmpty();

        // makeEmpty
        void MakeEmpty();
    }

    public class MyStackArray<T> : IStack<T>
    {
        T[] arr;
        int index = 0;

        public MyStackArray(int maxSize)
        {
            arr = new T[maxSize];
        }

        public bool IsEmpty()
        {
            return index == 0;
        }

        public void MakeEmpty()
        {
            index = 0;
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T value)
        {
            arr[index++] = value;
        }

        public T Top()
        {
            throw new NotImplementedException();
        }
    }


    class ListStack<T> : IStack<T>
    {
        // Node head;
        public bool IsEmpty()
        {
            // return head == null;
            throw new NotImplementedException();
        }

        public void MakeEmpty()
        {
            // head = null;
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T value)
        {
            throw new NotImplementedException();
        }

        public T Top()
        {
            throw new NotImplementedException();
        }
    }
}
