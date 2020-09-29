using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        //member variables
        private int count;
        public int Count   { get { return count; } }
        private int capacity;
        public int Capacity { get { return capacity; } }

        private T[] items;
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        //constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;

            items = new T[capacity];
        }

        //methods
        public void Add(T item)
        {

        }

        public void Remove(T item)
        {

        }
        


    }
}
