using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
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
            if (count == capacity)
            {
                T[] temporary = new T[count];
                for (int i = 0; i < count; i++)
                {
                    temporary[i] = items[i];
                }
                items = new T[capacity *= 2];
                for (int i = 0; i < count; i++)
                {
                    items[i] = temporary[i];
                }
            }
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            for(int i =0; i < count; i++)
            {
                if (item.Equals(items[i]))
                {
                    items[i] = default;
                    for(int a = i; a < count; a++)
                    {
                        items[a] = items[a + 1];
                    }
                    count--;
                    break;
                }
            }
        }


        public override string ToString()
        {
            string newString;
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < count; i++)
            {
                builder.Append(items[i]);
            }
            newString = builder.ToString();
            return newString;
        }

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> list = new CustomList<T>();
            for (int i = 0; i < a.Count; i++)
            {
                list.Add(a[i]);
            }
            for(int x = 0; x < b.Count; x++)
            {
                list.Add(b[x]);
            }
            return list;
        }

        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> list = new CustomList<T>();
            for (int i = 0; i < a.Count; i++)
            {
                list.Add(a[i]);
            }
            for (int x = 0; x < b.Count; x++)
            {
                list.Remove(b[x]);
            }
            return list;
        }

        public void Zip(CustomList<T> list)
        {
            T[] zipList = new T[capacity];
            int zipCount = 0;
            int arrayCount = 0;
            while (zipCount < count || zipCount < list.Count)
            {
                if (zipCount < count)
                {
                    if (arrayCount == capacity)
                    {
                        T[] temporary = new T[arrayCount];
                        for (int i = 0; i < arrayCount; i++)
                        {
                            temporary[i] = zipList[i];
                        }
                        zipList = new T[capacity *= 2];
                        for (int i = 0; i < arrayCount; i++)
                        {
                            zipList[i] = temporary[i];
                        }
                    }
                    zipList[arrayCount] = items[zipCount];
                    arrayCount++;
                }
                if (zipCount < list.Count)
                {
                    if (arrayCount == capacity)
                    {
                        T[] temporary = new T[arrayCount];
                        for (int i = 0; i < arrayCount; i++)
                        {
                            temporary[i] = zipList[i];
                        }
                        zipList = new T[capacity *= 2];
                        for (int i = 0; i < arrayCount; i++)
                        {
                            zipList[i] = temporary[i];
                        }
                    }
                    zipList[arrayCount] = list[zipCount];
                    arrayCount++;
                }
                zipCount++;
            }

            count = arrayCount;
            items = new T[capacity];
            for (int i = 0; i < arrayCount; i++)
            {
                items[i] = zipList[i];
            }
            
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }
    }
}
