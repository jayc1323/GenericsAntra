using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAntra
{
    internal class MyStack<T>
    {

        int numItems;
        List<T> items;
        public MyStack()
        {
            items = new List<T>();
            numItems = 0;
        }

        public void Push(T item)
        {
            items.Add(item);
            numItems++;
        }

        public T Pop()
        {
            if (numItems == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T item = items[numItems - 1];
            items.RemoveAt(numItems - 1);
            numItems--;
            return item;

        }

        public int Count()
        {
            return numItems;
        }





    }
}
