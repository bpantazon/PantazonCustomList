using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] firstArray = new T[4];
        public int Count  { get; set; }
        private int Capacity { get; set; }
        
        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            firstArray = new T[Capacity];
        }
        public void Add(T item)
        {
            if (Count == Capacity)
            {
                Capacity += 4;
                T[] newArray = new T[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = firstArray[i];
                }
                firstArray = newArray;
                firstArray[Count] = item;
                Count++;
            }
            else
            {
                firstArray[Count] = item;

                Count++;
            }           
        }
        public void Remove(T item)
        {

        }
        
    }
}
